using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7.q7
{
    internal class Color
    {

        public int R { set; get; }
        public int G { set; get; }
        public int B { set; get; }

        public int O { set; get; } = 255;
        public Color(int r, int g, int b, int o)
        {
            R = r;
            G = g;  
            B = b;  
            O = o;

        }

        public int GetB()
        {
            return B;
        }

        public int GetG()
        {
            return G;
        }

        public int GetR()
        {
            return R;
        }

        public double GetGrayScale()
        {
            return (R + B + G) / 3;
        }
    }
}
