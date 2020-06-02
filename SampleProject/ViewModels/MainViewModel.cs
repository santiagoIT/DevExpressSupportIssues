using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleProject.ViewModels;

namespace SampleProject
{
  public class MainViewModel
  {
    public bool IsEditing { get; set; }

    public ObservableCollection<ItemViewModel> Items { get; } = new ObservableCollection<ItemViewModel>();

    public MainViewModel()
    {
      Items.Add(new ItemViewModel("Roger", "Federer"));
      Items.Add(new ItemViewModel("Rafael", "Nadal"));
    }
  }
}
