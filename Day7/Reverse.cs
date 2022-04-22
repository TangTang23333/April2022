using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    internal class ReverseArray

    {
        //[] numbers = GenerateNumbers();
        //    Reverse(numbers);
        //    PrintNumbers(numbers);

        public static int[] GenerateNumbers(int n)
        {
            int[] res = new int[n];
            Random r = new Random();

            for (int i = 0; i < n; i++)
            {
                res[i] = r.Next(500);
            }

            return res;
        }

        public static void Reverse(int[] nums)
        {
            for (int i = 0, j = nums.Length-1; i < j; i++, j--)
            {
                int temp = nums[i];
                nums[i] = nums[j];
                nums[j] = temp;

            }
        }

        public static void PrintNumbers(int[] nums)
        {
            foreach (int n in nums)
            {
                Console.Write(n);
                Console.Write(",  ");
            }

            Console.WriteLine();
        }

    }
}
