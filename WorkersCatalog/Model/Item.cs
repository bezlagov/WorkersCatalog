using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WorkersCatalog.Model
{
    class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Position { get; set; }
       // public Image Photo { get; set; }
        public BitmapImage Photo { get; set; }
        public DateTime Birthday { get; set; }
        public string ImplOrderNumber { get; set; }
        public DateTime ImplOrderDate { get; set; }
        public string FireOrderNumber { get; set; }
        public DateTime FireOrderDate { get; set; }
        public Item()
        { }
        public Item(int id, string name, string surname, string position, BitmapImage photo, DateTime birthday, string implOrderNumber, DateTime implOrderDate, string fireOrderNumber, DateTime fireOrderDate)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Position = position;
            Photo = photo;
            Birthday = birthday;
            ImplOrderNumber = implOrderNumber;
            ImplOrderDate = implOrderDate;
            FireOrderNumber = fireOrderNumber;
            FireOrderDate = fireOrderDate;
        }
    }
}
