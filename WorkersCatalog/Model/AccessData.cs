using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkersCatalog.Model
{
    class AccessData
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string Database { get; set; }

        private static AccessData instance;
        public static AccessData Instance
        {
            get
            {
                if (instance == null) instance = new AccessData();
                return instance;
            }
        }
    }
}
