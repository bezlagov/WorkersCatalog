using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkersCatalog.View
{
    public static class ShowText
    {
        public static string DeleteMessage()
        {
            return "Are you sure you want to delete data?";
        }
        public static string DeleteSimple()
        {
            return "Deleting";
        }
        public static string ConnectionErrorTitle()
        {
            return "Connection Error";
        }
        public static string ConnectionError()
        {
            return "Connection Error, reconnect?";
        }
        public static string DeletechooseTitle()
        {
            return "Selection Error";
        }
        public static string Deletechoose()
        {
            return "Item to delete is not selected!";
        }
        public static string AddNewWorkerTitle()
        {
            return "Add worker";
        }
        public static string AddNewWorker()
        {
            return "Worker was Added";
        }
        public static string ErrorAddWorker()
        {
            return "Not corrected value";
        }
        public static string ErrorSelectTitle()
        {
            return "Error";
        }
        public static string ErrorSelect()
        {
            return "Worker didn't selected. Select the worker please!";
        }
    }
}
