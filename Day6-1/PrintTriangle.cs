using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_1
{
    public class Triangle
    {
        
        
        public static void PrintTriangleStars(int layer)
        {

            StringBuilder star = new StringBuilder("*");
            StringBuilder spaces = new StringBuilder(" ");

            for (int i = 0; i < layer-1; i++)
            {
                spaces.Append(" ");
            }

            int start = 1, space = layer - 1;

            while (start <= layer)
            {
                Console.WriteLine(String.Format("{0}{1}{0}", spaces, star));
                star.Append("**");
                if (spaces.Length > 0)
                {
                    spaces.Remove(0, 1);
                }
            
                start += 1;

            }

        }
    }
}
