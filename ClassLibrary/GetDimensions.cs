using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public static class GetDimensions
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int GetWindowRect(IntPtr hwnd, out Rectangle rect);
        

        public static Rectangle GetWindow(IntPtr intPtr)
        {
            Console.WriteLine(intPtr);
            Rectangle rect;
            GetWindowRect(intPtr, out rect);
            return rect;
        }
    }
}
