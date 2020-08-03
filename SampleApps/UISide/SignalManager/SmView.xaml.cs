using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace UISide.SignalManager
{
    /// <summary>
    /// Interaction logic for SmView.xaml
    /// </summary>
    public partial class SmView : UserControl
    {
        private SmViewModel _viewModel;

        public SmView()
        {
            InitializeComponent();
            _viewModel = (SmViewModel) this.DataContext;
            PopulateComboBox();
        }

        private async void PopulateComboBox()
        {
            //var projectNames= await _viewModel.ProjectService.GetProjectNames();
            //ProjectComboBox.ItemsSource = projectNames.Select(x => x.Name);
        }

        private async void ButtonClickView(object sender, RoutedEventArgs e)
        {
            await _viewModel.FetchSmData();
        }

        private async void RibbonButtonFetchData(object sender, RoutedEventArgs e)
        {
            await _viewModel.FetchSmData();
        }

        private void RibbonButton_DeleteSignal(object sender, RoutedEventArgs e)
        {
            var selectedItems = SignalData.SelectedItems;
            var count = 0;
            foreach (var selectedItem in selectedItems)
            {
                var index = selectedItems.IndexOf(selectedItem);
            }
        }
    }
}
