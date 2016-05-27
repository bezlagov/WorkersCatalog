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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WorkersCatalog
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnReportClick(object sender, RoutedEventArgs e)
        {
            View.ReportView report = new View.ReportView();
            report.ShowDialog();
        }

        private void OnEditClick(object sender, RoutedEventArgs e)
        {
            View.WorkerEditing editor = new View.WorkerEditing();
            editor.ShowDialog();
        }

        private void OnDatabaseEditClick(object sender, RoutedEventArgs e)
        {
            View.DatabaseConnectionWindow databaseSettings = new View.DatabaseConnectionWindow();
            databaseSettings.ShowDialog();
        }
      
        private void OnNotesClick(object sender, RoutedEventArgs e)
        {
            Notes.NotesController note = new Notes.NotesController();
            note.SetNewNote();
        }
        private void OnExitClick(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void OnSearchClick(object sender, RoutedEventArgs e)
        {
            View.SearchWindow search = new View.SearchWindow();
            search.ShowDialog();
        }

        private void OnLoggerClick(object sender, RoutedEventArgs e)
        {
            View.LoggerSettingsWindow logger = new View.LoggerSettingsWindow();
            logger.ShowDialog();
        }
    }
}
