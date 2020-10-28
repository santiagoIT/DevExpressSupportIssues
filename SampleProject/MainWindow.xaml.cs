using System.Windows;
using DevExpress.Xpf.Grid;
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

    private void Grid_OnSelectedItemChanged(object sender, SelectedItemChangedEventArgs e)
    {
      
    }

    private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
    {
      tableView1.ShowCheckBoxSelectorColumn = !tableView1.ShowCheckBoxSelectorColumn;
    }
  }
}
