using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WorkersCatalog.Model;

namespace WorkersCatalog.Controller
{
    class SearchController
    {
        public  static string StringConverter(Key key, string searchingString)
        {
            switch (key)
            {
                case Key.Back:
                    {
                        try
                        {
                            searchingString = searchingString.Substring(0, searchingString.Length - 1);
                        }
                        catch (Exception err)
                        {
                            searchingString = "";
                        }
                        break;
                    }
                case Key.Space:
                    {
                        searchingString += " ";
                        break;
                    }
                case Key.LeftShift:
                case Key.RightShift:
                    {
                        searchingString += "";
                        break;
                    }
                case Key.D0:
                case Key.D1:
                case Key.D2:
                case Key.D3:
                case Key.D4:
                case Key.D5:
                case Key.D6:
                case Key.D7:
                case Key.D8:
                case Key.D9:
                    {
                        searchingString += key.ToString()[1];
                        break;
                    }
                default:
                    {
                        searchingString += key;
                        break;
                    }
            }
            return searchingString;
        }
    }
}
