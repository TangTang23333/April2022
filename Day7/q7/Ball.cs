using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7.q7
{
    internal class Ball
    {
        public int Size;
        public string Color;
        private int Thrown;
        public Ball(int size, string color, int thrown)
        {
            Size = size;    
            Color = color;  
            Thrown = thrown;

        }

        public void Pop()
        {
            Size = 0;
        }

        public void Throw()
        {
            Thrown = Size > 0 ? Thrown + 1 : Thrown;
        }

        public int TimesOfThrown()
        {
            return Thrown;
        }







    }
}
