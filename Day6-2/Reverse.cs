using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_2
{
    internal class Reverse
    { 

        public static void Get1(string s)
        {
            
            StringBuilder res = new StringBuilder();

            for (int i = s.Length-1; i > -1;  i--)

            {
                Console.Write(s[i]);
            }
             
            Console.WriteLine();
        }


        public static void Get2(string s)
        {
            char[] res = new char[s.Length];
            res = s.Reverse().ToArray();
            Console.WriteLine(String.Join("", res));
        }
    }
}
