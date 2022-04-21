using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_1
{
    public class GuessSimulator
    {



        public static void Validation()
        {

            int target = new Random().Next(3) + 1;
            Console.WriteLine("Please enter your guess");

            try
            {
                int guessInt = int.Parse(Console.ReadLine());
                while (guessInt != target)
                {
                    if (guessInt < 1 || guessInt > 3)
                    {
                        Console.WriteLine("Guess out of range!");
                    }
                    else if (guessInt < target)
                    {
                        Console.WriteLine("Guess is lower than target!");
                    }
                    else if (guessInt > target)
                    {
                        Console.WriteLine("Guess is higher than target!");
                    }
                    else
                    {
                        Console.WriteLine("!!! Congrats!!");
                    }


                    Console.WriteLine("Please guess again!");
                    guessInt = int.Parse(Console.ReadLine());

                }
                Console.WriteLine("Bingo!!! Congrats!!");
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Please enter valid integer!");
            }






        }
    }
}
