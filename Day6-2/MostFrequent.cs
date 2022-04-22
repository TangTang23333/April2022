using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_2
{
    public  class MostFrequent
    
    {
        public static int Get(int[] nums) { 


            Dictionary<int, int> dict = new Dictionary<int, int>();
            
            for (int i = 0; i < nums.Length; i++) {
                if (dict.ContainsKey(nums[i])) {
                    
                    dict[nums[i]] += 1;
                } else { 
                
                    dict[nums[i]] = 1;
                }
            }
            
            var ordered = dict.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            return ordered.First().Key;

        }
    }
}
