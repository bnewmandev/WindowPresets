using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowClasses
{
    public class Window
    {
        public string WindowName;
        public Process ProcessName;
        public string FilePath;
        public Rectangle RectangleXY;
        
        
        public Window(Process process, string name)
        {
            ProcessName = process;
            RectangleXY = StaticFunctions.GetDimensions(process.MainWindowHandle);
            FilePath = process.MainModule.FileName;
            WindowName = process.MainWindowTitle;
        }
    }
}
