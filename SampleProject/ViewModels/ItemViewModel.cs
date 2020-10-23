using DevExpress.Mvvm;

namespace SampleProject.ViewModels
{
  public class ItemViewModel : ViewModelBase
  {
    private MainViewModel _parent;
    public string FirstName { get; }
    public string LastName { get; }

    public ItemViewModel(MainViewModel parent, string firstName, string lastName)
    {
      FirstName = firstName;
      LastName = lastName;
      _parent = parent;
    }

    private bool _fixedSelect;
    public bool FixSelect
    {
      get => _fixedSelect;
      set
      {
        if (_fixedSelect != value)
        {
          _fixedSelect = value;
          if (value)
          {
            if (!_parent.FixedSelection.Contains(this))
            {
              _parent.FixedSelection.Add(this);
            }

            if (!_parent.SelectedItems.Contains(this))
            {
              _parent.SelectedItems.Add(this);
            }
          }
          else
          {
            _parent.FixedSelection.Remove(this);
            _parent.SelectedItems.Remove(this);
          }

          RaisePropertyChanged();
        }
      }
    }

  }
}
