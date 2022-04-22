using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_2
{
    internal class Parse
    {
        public static void Get(string s)
        {

            string[] words = s.Split("://");

            // protocol: words[0] if exist 
            if (words.Length == 2)
            {
                Console.WriteLine($"Protocol is {words[0]}") ;

                string[] serverAndResource = words[1].Split("/");

                if (serverAndResource.Length == 2)
                {
                    Console.WriteLine($"Server is {serverAndResource[0]}");
                    Console.WriteLine($"Resource is {serverAndResource[1]}");
                } else
                {
                    Console.WriteLine($"Server is {serverAndResource[0]}");
                    Console.WriteLine($"Resource is {""}");
                }
            } else
            {
                string[] serverAndResource = words[0].Split("/");
                Console.WriteLine($"Protocol is {""}");
                if (serverAndResource.Length == 2)
                {
                    Console.WriteLine($"Server is {serverAndResource[0]}");
                    Console.WriteLine($"Resource is {serverAndResource[1]}");
                }
                else
                {
                    Console.WriteLine($"Server is {serverAndResource[0]}");
                    Console.WriteLine($"Resource is {""}");
                }
            }

            
        }
    }
}
