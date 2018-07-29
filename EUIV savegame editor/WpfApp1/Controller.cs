using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Controller
    {
        public void FileRead()
        {
            ReadFile beef = new ReadFile();
            beef.FileRead(@"C:\Users\alexj\Documents\Paradox Interactive\Europa Universalis IV\save games\testgame.eu4");
        }
    }
}
