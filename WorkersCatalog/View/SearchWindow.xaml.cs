using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WorkersCatalog.Controller;
using System.Threading;

namespace WorkersCatalog.View
{
    public partial class SearchWindow : Window
    {
        string searchingString { get; set; }
        int selectedId { get; set; }
        public SearchWindow()
        {
            InitializeComponent();
        }
        private void OnKeyUpEvent(object sender, KeyEventArgs e)
        {
            searchingString = SearchController.StringConverter(e.Key, searchingString);
            SetDataToTheList();
        }

        private void OnSelectClick(object sender, RoutedEventArgs e)
        {
            ReportView view = new ReportView(listWorkers.SelectedIndex);
            view.ShowDialog();
        }
        private void SetDataToTheList()
        {
            try
            {
                listWorkers.Items.Clear();
                WorkersCatalog.Model.Archive.Instance.data = WorkersCatalog.Database.DatabaseProvider.Instance.GetWorkers();
                string fullName;
                foreach (var item in WorkersCatalog.Model.Archive.Instance.data)
                {
                    fullName = item.Name.ToString() + " " + item.Surname.ToString();
                    fullName = fullName.ToLower();
                    if (fullName.Contains(searchingString.ToLower()))
                    listWorkers.Items.Add(item.Name + " " + item.Surname);
                }
            }
            catch (Exception err)
            {
                if (MessageBox.Show(ShowText.ConnectionError(), ShowText.ConnectionErrorTitle(), MessageBoxButton.YesNo, MessageBoxImage.Error, MessageBoxResult.Yes) == MessageBoxResult.Yes)
                {
                    View.DatabaseConnectionWindow databaseSettings = new View.DatabaseConnectionWindow();
                    databaseSettings.ShowDialog();
                    SetDataToTheList();
                }
            }
        }

        private void OnCancelClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedId = listWorkers.SelectedIndex;
        }
    }
}
