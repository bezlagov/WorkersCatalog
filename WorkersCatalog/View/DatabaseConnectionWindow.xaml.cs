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
using WorkersCatalog.Database;


namespace WorkersCatalog.View
{
    /// <summary>
    /// Interaction logic for DatabaseConnectionWindow.xaml
    /// </summary>
    public partial class DatabaseConnectionWindow : Window
    {
        public DatabaseConnectionWindow()
        {
            InitializeComponent();
        }

        private void OnOkClick(object sender, RoutedEventArgs e)
        {
            SetAuthorizationData.SetData(txtLogin.Text,txtPassword.Password,txtDatabase.Text);
            DatabaseProvider.Instance.Initialize(SetAuthorizationData.GetLogin(),SetAuthorizationData.GetPassword(),SetAuthorizationData.GetdatabaseName());
            this.Close();
        }

        private void OnCancelClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
