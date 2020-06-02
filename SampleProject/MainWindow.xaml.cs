using System.Windows;
using SampleProject;

namespace DXGrid_AttributesBasedValidation
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();

      DataContext = new MainViewModel();
    }
  }
}
