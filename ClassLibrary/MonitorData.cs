using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary
{
    public class MonitorData
    {
        public int X;
        public int Y;
        public int Height;
        public int Width;

        internal MonitorData()
        {

        }

        public MonitorData(int monitorID, bool debug=false)
        {
            if (debug == true)
            {
                Console.WriteLine(Screen.AllScreens[monitorID].Bounds);
            }
            X = Screen.AllScreens[monitorID].Bounds.X;
            Y = Screen.AllScreens[monitorID].Bounds.Y;
            Height = Screen.AllScreens[monitorID].Bounds.Height;
            Width = Screen.AllScreens[monitorID].Bounds.Width;
        }
    }
}
