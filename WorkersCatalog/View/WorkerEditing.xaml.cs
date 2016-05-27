using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Microsoft.Win32;
using WorkersCatalog.Controller;

namespace WorkersCatalog.View
{
    /// <summary>
    /// Interaction logic for WorkerEditing.xaml
    /// </summary>
    public partial class WorkerEditing : Window
    {
        public int idHelper { get; set; }
        public WorkerEditing()
        {
            idHelper = -1;
            InitializeComponent();
        }
        public WorkerEditing(int index)
        {
            idHelper = index;
            InitializeComponent();
            SetDataToFields(idHelper);
        }

        private void OnChooseWorkerClick(object sender, RoutedEventArgs e)
        {
            ChooseWorker choose = new ChooseWorker();
            choose.ShowDialog();
            idHelper = choose.selectedIndex;
            if (choose.selectedIndex != -1)
            {
                SetDataToFields(choose.selectedIndex);
            }
        }

        private void OnFindClick(object sender, RoutedEventArgs e)
        {
            OpenPicture();
        }

        private void OnUploadClick(object sender, RoutedEventArgs e)
        {
            try
            {
                ImgBox.Source = new BitmapImage(new Uri(txtPhoto.Text, UriKind.Absolute));
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void OnAddNewClick(object sender, RoutedEventArgs e)
        {
            try
            {
                DatabaseController.AddNewWorkerToDatabase(txtName.Text, txtSurname.Text, calendar.SelectedDate.ToString() == "" ? new DateTime(1900, 1, 1) : DateTime.Parse(calendar.SelectedDate.ToString()), txtPosition.Text, txtImpl.Text, DateTime.Parse(calendarImpl.SelectedDate.ToString()), txtfire.Text, DateTime.Parse(calendarFire.SelectedDate.ToString()), txtPhoto.Text);
                MessageBox.Show(ShowText.AddNewWorker(), ShowText.AddNewWorkerTitle(), MessageBoxButton.OK, MessageBoxImage.Information);
                OnClearClick(sender, e);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void OnEditWorkerClick(object sender, RoutedEventArgs e)
        {
            try
            {
                if (idHelper <= -1)
                {
                    ChooseWorker choose = new ChooseWorker();
                    choose.ShowDialog();
                    idHelper = choose.selectedIndex;
                    OnEditWorkerClick(sender, e);
                }
                else
                {
                    DatabaseController.EditWorkerInDatabase(idHelper, txtName.Text, txtSurname.Text, calendar.SelectedDate.ToString() == "" ? new DateTime(1900, 1, 1) : DateTime.Parse(calendar.SelectedDate.ToString()), txtPosition.Text, txtImpl.Text, DateTime.Parse(calendarImpl.SelectedDate.ToString()), txtfire.Text, DateTime.Parse(calendarFire.SelectedDate.ToString()), txtPhoto.Text);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void OnClearClick(object sender, RoutedEventArgs e)
        {
            ClearAll();
        }

        private void OnCancelClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void ClearAll()
        {
            try
            {
                txtName.Clear();
                txtSurname.Clear();
                txtPhoto.Clear();
                txtPosition.Clear();
                txtImpl.Clear();
                txtfire.Clear();
                calendar.Text = "";
                calendarImpl.Text = "";
                calendarFire.Text = "";
                ImgBox.Source = new BitmapImage(new Uri("no-thumb.png", UriKind.Relative));
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        
        private void OpenPicture()
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Picture (*.png)|*.png";
            if (openFile.ShowDialog() == true)
            {
                txtPhoto.Text = openFile.FileName;
            }
        }
        private void SetDataToFields(int index)
        {
            txtName.Text = ArchiveDataController.GetArchiveItem(index).Name;
            txtSurname.Text = ArchiveDataController.GetArchiveItem(index).Surname;
            txtPosition.Text = ArchiveDataController.GetArchiveItem(index).Position;
            txtImpl.Text = ArchiveDataController.GetArchiveItem(index).ImplOrderNumber;
            txtfire.Text = ArchiveDataController.GetArchiveItem(index).FireOrderNumber;
            ImgBox.Source = ArchiveDataController.GetArchiveItem(index).Photo;
            calendar.SelectedDate = ArchiveDataController.GetArchiveItem(index).Birthday;
            calendarImpl.SelectedDate = ArchiveDataController.GetArchiveItem(index).ImplOrderDate;
            calendarFire.SelectedDate = ArchiveDataController.GetArchiveItem(index).FireOrderDate;
        }
    }
}
