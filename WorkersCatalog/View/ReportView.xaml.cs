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

namespace WorkersCatalog.View
{
    public partial class ReportView : Window
    {
        public ReportView()
        {
            InitializeComponent();
            SetDataToTheList();
        }
        public ReportView(int id)
        {
            InitializeComponent();
            SetDataToTheList();
            listWorkers.SelectedIndex = id;
            MessageBox.Show(id.ToString());
        }

        private void OnEditClick(object sender, RoutedEventArgs e)
        {
            WorkerEditing editor = new WorkerEditing(listWorkers.SelectedIndex);
            editor.ShowDialog();
        }
        private void OnDeleteClick(object sender, RoutedEventArgs e)
        {
            if (listWorkers.SelectedIndex == -1)
            {
                MessageBox.Show(ShowText.Deletechoose(), ShowText.DeletechooseTitle(), MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            if (MessageBox.Show(ShowText.DeleteMessage(), ShowText.DeleteSimple(), MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.Yes) == MessageBoxResult.Yes)
            {
                try
                {
                    DatabaseController.DeleteValueFromDatabase(listWorkers.SelectedIndex);
                    listWorkers.SelectedIndex = -1;
                    SetDataToTheList();
                }
                catch (Exception err)
                {
                    listWorkers.SelectedIndex = -1;
                    SetDataToTheList();
                }
            }
        }
        private void OnBackClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void SetDataToTheList()
        {

            try
            {
                listWorkers.Items.Clear();
                WorkersCatalog.Model.Archive.Instance.data = WorkersCatalog.Database.DatabaseProvider.Instance.GetWorkers();
                foreach (var item in WorkersCatalog.Model.Archive.Instance.data)
                {
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

        private void OnListSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SetValue(listWorkers.SelectedIndex);
        }

        private void SetValue(int index)
        {
            lblFullName.Content = ArchiveDataController.GetArchiveItem(index).Name + " " + ArchiveDataController.GetArchiveItem(index).Surname;
            lblAge.Content = DateTime.Today.Year - ArchiveDataController.GetArchiveItem(index).Birthday.Year;
            lblDate.Content = ArchiveDataController.GetArchiveItem(index).Birthday;
            lblPosition.Content = ArchiveDataController.GetArchiveItem(index).Position;
            lblNOrder.Content = ArchiveDataController.GetArchiveItem(index).ImplOrderNumber;
            lblTakeWorkDate.Content = ArchiveDataController.GetArchiveItem(index).ImplOrderDate;
            lblNFiring.Content = ArchiveDataController.GetArchiveItem(index).FireOrderNumber;
            lblfiringDate.Content = ArchiveDataController.GetArchiveItem(index).FireOrderDate;
            imgPhoto.Source = ArchiveDataController.GetArchiveItem(index).Photo;
        }
    }
}
