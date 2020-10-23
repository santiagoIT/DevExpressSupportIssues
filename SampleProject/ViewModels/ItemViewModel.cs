using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm;

namespace SampleProject.ViewModels
{
  public class ItemViewModel : ViewModelBase
  {
    public string FirstName { get; }
    public string LastName { get; }

    public ItemViewModel(string firstName, string lastName)
    {
      FirstName = firstName;
      LastName = lastName;
    }
  }
}
