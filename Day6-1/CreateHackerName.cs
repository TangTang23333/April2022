using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_1
{
    public static class CreateHackerName
    {

        public static void CreateName()
        {

            Console.WriteLine("please enter your favorite color");
            string color = Console.ReadLine();
            Console.WriteLine("please enter your favorite animal");
            string animal = Console.ReadLine();
            Console.WriteLine("please enter your favorite number");
            string number = Console.ReadLine();

            Console.WriteLine($"your username will be : {color + animal + number}");

        }
    }
}