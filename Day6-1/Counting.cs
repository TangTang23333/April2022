using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_1
{
    public class Counting
    {

        public static int[] CoutingByN(int gap, int n)
        {
            int[] result = new int[(int)n / gap + 1];
            int j = 0;

            for (int i = 0; i <= n; i += gap)
            {
                result[j] = i;
                j++;
            }

            return result;
        }
    }


}
