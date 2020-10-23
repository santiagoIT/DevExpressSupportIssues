using System.Collections.ObjectModel;
using System.Windows.Input;
using DevExpress.Mvvm;
using SampleProject.ViewModels;

namespace SampleProject
{
  public class MainViewModel : ViewModelBase
  {
    public ObservableCollection<ItemViewModel> Items { get; } = new ObservableCollection<ItemViewModel>();
    public ObservableCollection<ItemViewModel> SelectedItems { get; } = new ObservableCollection<ItemViewModel>();


    private ItemViewModel _focusedItem;
    public ItemViewModel FocusedItem
    {
      get { return _focusedItem; }
      set
      {
        if (_focusedItem != value)
        {
          _focusedItem = value;
          RaisePropertyChanged();
        }
      }
    }

    public MainViewModel()
    {
      Items.Add(new ItemViewModel("Dominic", "Thiem"));
      Items.Add(new ItemViewModel("Novak", "Djokovic"));
      Items.Add(new ItemViewModel("Roger", "Federer"));
      Items.Add(new ItemViewModel("Rafael", "Nadal"));

      RegisterCommands();

      SelectedItems.CollectionChanged += SelectedItems_CollectionChanged;
    }

    private void SelectedItems_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
    {
      
    }

    #region Commands

    public ICommand CmdSelect { get; private set; }
    private void RegisterCommands()
    {
      CmdSelect = new DelegateCommand(CmdSelectExecute);
    }

    private void CmdSelectExecute()
    {
      SelectedItems.Clear();
      SelectedItems.Add(Items[2]);
      SelectedItems.Add(Items[3]);
    }
    #endregion
  }
}
