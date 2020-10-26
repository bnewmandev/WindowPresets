using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ClassLibrary
{
    public static class CreatePreset
    {
        public static Preset New(bool debug=false)
        {
            if (debug)
            {
                Process[] processList = Process.GetProcesses();
                foreach (Process process in processList)
                {
                    if (!String.IsNullOrEmpty(process.MainWindowTitle))
                    {
                        Console.WriteLine("Process:   {0}", process.ProcessName);
                        Console.WriteLine("    ID   : {0}", process.Id);
                        Console.WriteLine("    Title: {0} \n", process.MainWindowTitle);
                    }
                }
            }
            var output = new Preset();
            return output;
        }
    }
}
