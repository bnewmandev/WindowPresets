using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowClasses
{
    public static class StaticFunctions
    {
        public static Dictionary<int, Process> GetWindowList()
        {
            var outputDictionary = new Dictionary<int, Process>();
            Process[] processList = Process.GetProcesses();
            foreach (Process process in processList)
            {
                if (!String.IsNullOrEmpty(process.MainWindowTitle))
                {
                    // Console.WriteLine("Process:   {0}", process.ProcessName);
                    // Console.WriteLine("ID:        {0}", process.Id);
                    // Console.WriteLine("Title:     {0}", process.MainWindowTitle);
                    // Console.WriteLine("MWH:       {0}", process.MainWindowHandle);
                    outputDictionary.Add(process.Id, process);
                }
            }
            return outputDictionary;
        }

        public static Process SelectProcess(Dictionary<int, Process> processes, int processId)
        {
            Process output = processes[processId];
            return output;
        }



        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int GetWindowRect(IntPtr hwnd, out Rectangle rect);


        public static Rectangle GetDimensions(IntPtr intPtr)
        {
            Console.WriteLine(intPtr);
            Rectangle rect;
            GetWindowRect(intPtr, out rect);
            return rect;
        }
    }
}
