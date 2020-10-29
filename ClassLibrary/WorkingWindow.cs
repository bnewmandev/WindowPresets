using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class WorkingWindow
    {

        public string WindowName;
        public string FilePath;
        public IntPtr MWH;
        public int X;
        public int Y;
        public int Height;
        public int Width;
        public Rectangle rectangle;
        public Process Application;

        public WorkingWindow (Dictionary<int, Process> processDict, int processId)
        {
            Application = processDict[processId];
            MWH = Application.MainWindowHandle;
        }


        public void Write()
        {
            rectangle = GetDimensions.GetWindow(MWH);
            Console.WriteLine("X Coordinate: {0}", rectangle.X);
            Console.WriteLine("Y Coordinate: {0}", rectangle.Y);
            Console.WriteLine("Width: {0}", rectangle.Width);
            Console.WriteLine("Height: {0}", rectangle.Height);
            X = rectangle.X;
            Y = rectangle.Y;
            Height = rectangle.Height;
            Width = rectangle.Width;

            FilePath = Application.MainModule.FileName;
            
        }
    }
}
