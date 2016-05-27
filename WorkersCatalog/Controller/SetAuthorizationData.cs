using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WorkersCatalog.Model;

namespace WorkersCatalog.Controller
{
    static class SetAuthorizationData
    {
        static public void SetData(string login, string password, string databaseName)
        {
            AccessData.Instance.Login = login;
            AccessData.Instance.Password = password;
            AccessData.Instance.Database = databaseName;
        }
        static public string GetLogin()
        {
            return AccessData.Instance.Login;
        }
        static public string GetPassword()
        {
            return AccessData.Instance.Password;
        }
        static public string GetdatabaseName()
        {
            return AccessData.Instance.Database;
        }
    }
}
