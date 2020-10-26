using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary
{
    class Program
    {
        static void Main()
        {
            // var monitor1 = new MonitorData(1, true);
            CreatePreset.New(true);
            MonitorInit.ExportToXml();
            Console.ReadLine();
        }
    }
}
