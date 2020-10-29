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
            MonitorInit.Initialize();
            var dict = ListWindows.New();
            Console.WriteLine("Select a window: ");
            int ProcessId = Convert.ToInt32(Console.ReadLine());
            var testWindow = new WorkingWindow(dict, ProcessId);
            testWindow.Write();
            MonitorInit.ExportToXml();
            Console.ReadLine();
        }
    }
}
