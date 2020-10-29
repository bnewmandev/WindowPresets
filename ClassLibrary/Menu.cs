using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary
{
    public static class Menu
    {
        static void Run()
        {

        }
        static void Zero()
        {
            Console.WriteLine("Please select a menu option...\n");
            Console.WriteLine("[0]: Open a preset");
            Console.WriteLine("[1]: Create a preset");
            Console.WriteLine("[2]: Manage presets");
            Console.WriteLine("[3]: Settings");
            Console.WriteLine("[4]: See project on Github");
            Console.WriteLine("[5]: Exit");
            int sel = Convert.ToInt32(Console.ReadLine());
            switch (sel)
            {
                case 0:
                    zeroZero();
                    break;
            }
        }
        static int zeroZero()
        {
            Console.Clear();
            Console.WriteLine("Please Select a preset or press enter to return to main menu");
            string sel = Console.ReadLine();
            if (sel == null || sel == "")
            {
                return 0;
            }
            //zeroZeroFunction();
            return 3;
        }
    }
}
