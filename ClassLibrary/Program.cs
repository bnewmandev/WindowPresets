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
            /*
             * Create profile
             * Set name of profile
             * Set description of profile
             * LOOP~
             * add window to profile
             * ask to add window
             * LOOPEND~
             * Save to xml file
             * 
             */ 
        }

        static void StartUp()
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("****** Window Presets ******");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("\n");
            Console.WriteLine("Author: Benjamin Newman");
            Console.WriteLine("Github: https://github.com/jam1nb3n/WindowPresets");
            Console.WriteLine("Version: PRE-ALPHA");
            Console.WriteLine("Licence: Creative Commons Attribution-ShareAlike 4.0 International");
            Console.WriteLine("\nPlease press Enter to continue...");
            Console.ReadLine();
            Console.Clear();
        }

        static void Menu()
        {
            Console.WriteLine("Please select a menu option...\n");
            Console.WriteLine("[0]: Open a preset");
            Console.WriteLine("[1]: Create a preset");
            Console.WriteLine("[2]: Manage presets");
            Console.WriteLine("[3]: ");
            Console.WriteLine("[]");
        }

        
    }
}
