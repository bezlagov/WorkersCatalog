using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace WorkersCatalog.Notes
{
    class NotesController
    {

        public void SetNewNote()
        {
            ProcessStartInfo p = new ProcessStartInfo("notepad", "CatalogNotes");
            Process currentProcess = new Process();
            currentProcess.StartInfo = p;
            currentProcess.Start();
        }
    }
}
