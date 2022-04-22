using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_2
{
    public class RotationSum
    {


        public static int[] Sum(int r, int[] nums)
        {
            int n = nums.Length;
            int round = (int) (n / r);
            int single = r % n;

            int[] res = new int[n]; 
            Array.Fill(res, round * res.Sum());

            for (int i = 0; i < single; i++)
            
            {
                int[] rotated = new int[n];


                for (int j = 0; j < n; j++)
                {

                    if (j == 0)
                    {
                        rotated[j] = nums[n - 1];
                    }
                    else
                    {
                        rotated[j] = nums[j - 1];
                    }

                    res[j] += rotated[j];
                }
                //Console.WriteLine(String.Join(", ", rotated));
                nums = rotated;
            }

            //Console.WriteLine(String.Join(", ", res));
            return res;
        }


        
    }
}
