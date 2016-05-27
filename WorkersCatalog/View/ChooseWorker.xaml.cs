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

namespace WorkersCatalog.View
{
    /// <summary>
    /// Interaction logic for ChooseWorker.xaml
    /// </summary>
    public partial class ChooseWorker : Window
    {
        public int selectedIndex { get; set; }
        public ChooseWorker()
        {
            InitializeComponent();
            ListFiller();

        }
        public void ListFiller()
        {
            try
            {
                lstChoose.Items.Clear();
                WorkersCatalog.Model.Archive.Instance.data = WorkersCatalog.Database.DatabaseProvider.Instance.GetWorkers();
                foreach (var item in WorkersCatalog.Model.Archive.Instance.data)
                {
                    lstChoose.Items.Add(item.Name + " " + item.Surname);
                }
            }
            catch (Exception err)
            {
                if (MessageBox.Show(ShowText.ConnectionError(), ShowText.ConnectionErrorTitle(), MessageBoxButton.YesNo, MessageBoxImage.Error, MessageBoxResult.Yes) == MessageBoxResult.Yes)
                {
                    View.DatabaseConnectionWindow databaseSettings = new View.DatabaseConnectionWindow();
                    databaseSettings.ShowDialog();
                    ListFiller();
                }
                MessageBox.Show(err.Message);
            }
        }

        private void lstChoose_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedIndex = lstChoose.SelectedIndex;
        }

        private void OnCancelClick(object sender, RoutedEventArgs e)
        {
            selectedIndex = -1;
            this.Close();
        }

        private void OnChangeButtonClick(object sender, RoutedEventArgs e)
        {
            if (lstChoose.SelectedIndex == -1)
            {
                MessageBox.Show(ShowText.ErrorSelect(),ShowText.ErrorSelectTitle(),MessageBoxButton.OK,MessageBoxImage.Error);
                selectedIndex = -1;
            }
            else 
            {
                selectedIndex=lstChoose.SelectedIndex;
                this.Close();
            }
        }
    }
}
