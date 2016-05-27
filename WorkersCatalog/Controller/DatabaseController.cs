using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WorkersCatalog.Model;
using System.Threading.Tasks;
using WorkersCatalog.Database;
using System.Windows.Controls;

namespace WorkersCatalog.Controller
{
    static class DatabaseController
    {
        public static void DeleteValueFromDatabase(int index)
        {
            DatabaseProvider.Instance.DeleteData(Archive.Instance.data[index].Id);
        }
        public static void AddNewWorkerToDatabase(string name, string surname, DateTime birthday, string position, string implOrderNumber, DateTime implOrderDate, string fireOrderNumber, DateTime fireOrderDate, string photo)
        {
            DatabaseProvider.Instance.CreateNewData(name, surname, birthday, position, implOrderNumber, implOrderDate, fireOrderNumber, fireOrderDate, photo);
        }
        public static void EditWorkerInDatabase(int id, string name, string surname, DateTime birthday, string position, string implOrderNumber, DateTime implOrderDate, string fireOrderNumber, DateTime fireOrderDate, string photo)
        {
            DatabaseProvider.Instance.EditData(id, name, surname, birthday, position, implOrderNumber, implOrderDate, fireOrderNumber, fireOrderDate, photo);
        }
    }
}
