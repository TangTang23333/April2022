using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    internal class Fibonacci
    {

        public static int GetNthNumber(int n)
        {
            List<int> fib = new List<int>();
            
            fib.Add(1);
            fib.Add(1);
            for (int i = 2; i < n; i++)
            {
                fib.Add(fib[i-1] + fib[i-2]);
            }
            
            return fib[n - 1];
        }
    }
}
