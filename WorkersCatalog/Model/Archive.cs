using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkersCatalog.Model
{
    class Archive
    {
            private static Archive instance;
            public List<Item> data;

        public static Archive Instance
        {
            get
            {
                if (instance == null) instance = new Archive();
                return instance;
            }
        }
        private Archive() 
        {
            data = new List<Item>();
        }

    }
}
