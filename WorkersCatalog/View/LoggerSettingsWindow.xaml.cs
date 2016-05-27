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
    /// Interaction logic for LoggerSettingsWindow.xaml
    /// </summary>
    public partial class LoggerSettingsWindow : Window
    {
        public LoggerSettingsWindow()
        {
            InitializeComponent();
        }

        private void OnStartLogging(object sender, RoutedEventArgs e)
        {
            btnStart.IsEnabled = false;
            btnStop.IsEnabled = true;
        }

        private void OnStopLiggingClick(object sender, RoutedEventArgs e)
        {
            btnStart.IsEnabled = true;
            btnStop.IsEnabled = false;
        }

        private void OnCancelClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void OnAllChackedClick(object sender, RoutedEventArgs e)
        {
            chkTrace.IsChecked = true;
            chkDebug.IsChecked = true;
            chkWarning.IsChecked = true;
            chkError.IsChecked = true;
            chkFatal.IsChecked = true;
        }

        private void OnAllUncheckedClick(object sender, RoutedEventArgs e)
        {
            chkTrace.IsChecked = false;
            chkDebug.IsChecked = false;
            chkWarning.IsChecked = false;
            chkError.IsChecked = false;
            chkFatal.IsChecked = false;
        }

        private void OnLoggingToAllClick(object sender, RoutedEventArgs e)
        {
            chkToBinary.IsChecked = true;
            chkToDatabase.IsChecked = true;
            chkToText.IsChecked = true;
        }

        private void OnUnloggingToAllClick(object sender, RoutedEventArgs e)
        {
            chkToBinary.IsChecked = false;
            chkToDatabase.IsChecked = false;
            chkToText.IsChecked = false;
        }

        private void OnUncheckTypeOfLogging(object sender, RoutedEventArgs e)
        {
            chkAll.IsChecked = false;
        }

        private void OnUncheckMethodOfLogging(object sender, RoutedEventArgs e)
        {
            chkToAll.IsChecked = false;
        }
    }
}
