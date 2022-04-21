using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_1
{
    public class Greeting
    {
        public static void SayGreeting(DateTime t)
        {
            int hour = t.Hour;
            Console.WriteLine($"hour is {hour}");
            if (hour > 3 && hour < 12)
            {
                Console.WriteLine("Good Morning!");
            }
            if (hour >= 12 && hour < 17)
            {
                Console.WriteLine("Good Afternoon!");
            }
            if (hour >= 17 && hour < 22)
            {
                Console.WriteLine("Good Evening!");
            }
            if (hour >= 22 || hour < 4)
            {
                Console.WriteLine("Good Night!");
            }
        }

    }

}
