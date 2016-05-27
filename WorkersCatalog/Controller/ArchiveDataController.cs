using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkersCatalog.Model;

namespace WorkersCatalog.Controller
{
    static class ArchiveDataController
    {
        public static Item GetArchiveItem(int index)
        {
            return Archive.Instance.data[index];
        }
    }
}
