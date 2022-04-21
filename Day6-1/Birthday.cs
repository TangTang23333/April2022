using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_1
{
    public class Birthday
    {
        
        public static void GetDays()
        {
            Console.WriteLine("Enter your birthday please yyyy/mm/dd");
            DateTime parsedDate;
            DateTime bd = DateTime.ParseExact(Console.ReadLine(), "yyyymmdd", System.Globalization.CultureInfo.InvariantCulture);


            DateTime today = DateTime.Today;
            int daysSinceBorn = (today - bd).Days;
            Console.WriteLine( $"Your are {daysSinceBorn} days old! Congrats!");

            DateTime anniversay = today.AddDays(10000 - daysSinceBorn);
            Console.WriteLine($"Your next 10000 days anniversary is {anniversay.ToShortDateString()}!");
        }

       

    }
}
