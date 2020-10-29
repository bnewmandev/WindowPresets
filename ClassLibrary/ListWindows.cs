using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ClassLibrary
{
    public static class ListWindows
    {
        public static Dictionary<int, Process> New()
        {
            var outputDictionary = new Dictionary<int, Process>();
            Process[] processList = Process.GetProcesses();
            foreach (Process process in processList)
            {
                if (!String.IsNullOrEmpty(process.MainWindowTitle))
                {
                    Console.WriteLine("Process:   {0}", process.ProcessName);
                    Console.WriteLine("ID:        {0}", process.Id);
                    Console.WriteLine("Title:     {0}", process.MainWindowTitle);
                    Console.WriteLine("MWH:       {0}", process.MainWindowHandle);
                    outputDictionary.Add(process.Id, process);
                }
            }
            return outputDictionary;
        }
    }
}
