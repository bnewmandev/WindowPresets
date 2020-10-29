using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class SavedWindow
    {
        public string windowName;
        public string applicationName;
        public string applicationPath;
        public int[] coordinates = new int[2];
        public int[] size = new int[2];

        

        public SavedWindow(WorkingWindow temp)
        {
            coordinates[0] = temp.X;
            coordinates[1] = temp.Y;
            size[0] = temp.Width;
            size[1] = temp.Height;

            applicationName = temp.Application.ProcessName;
            windowName = temp.Application.MainWindowTitle;
            applicationPath = temp.FilePath;
        }
        public static void Comitt()
    }
}
