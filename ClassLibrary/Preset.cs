using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Preset
    {
        public string ProgramName;
        public int X;
        public int Y;
        public int Height;
        public int Width;

        public Preset(string programName, int x, int y, int height, int width)
        {
            ProgramName = programName;
            X = x;
            Y = y;
            Height = height;
            Width = width;
        }

        internal Preset(){}

    }
}
