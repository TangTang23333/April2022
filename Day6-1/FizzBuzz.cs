using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_1
{
    public class FizzbuzzGame

    {

        public static string[] FizzBuzzOnN(int n)
        {
            string[] res = new string[n];

            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    res[i - 1] = "fizzbuzz";
                }
                else if (i % 3 == 0)
                {
                    res[i - 1] = "fizz";
                }
                else if (i % 5 == 0)
                {
                    res[i - 1] = "buzz";
                }
                else
                {
                    res[i - 1] = i.ToString();
                }
            }
            return res;
        }

    }
}
