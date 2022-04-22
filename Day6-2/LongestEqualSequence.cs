using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_2
{
    public class LongestEqualSequence
    {


        public static int[] Get(int[] nums)
        {

            int n = nums.Length;
            int i = 1, maxi = 1 , count = 1;
            int identical = nums[0]; 
            

            while (i < n) { 


                
                while (i < n && nums[i] == nums[i-1])
                {   
                    
                    count += 1;
                    i += 1;
                }

                if (maxi < count)
                {
                    identical = nums[i - 1];
                }


                maxi = maxi > count ? maxi : count;
                

                i += 1;
                count = 1;

                
            }


            int[] res = new int[maxi];
            Array.Fill(res, identical);
            return res;
        }
    }
}
