using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_2
{
    public class ToDo
    {


        public static void Start() {

            List<string> list = new List<string>();

            while (true)
            {
                Console.WriteLine("Enter command (+ item, - item, or -- to clear)):");
                string item = Console.ReadLine();

                if (item.Substring(0, 1) == "+")
                {
                    list.Add(item.Substring(2));
                    
                }
                else if (item.Substring(0, 2) == "--")
                {
                    list.Clear();
                } else if (item.Substring(0, 1) == "-")
                {
                    int index = list.IndexOf(item.Substring(2));
                    list.RemoveAt(index);
                    
                } else
                {
                    Console.WriteLine("Invalid entry!");
                }


                var allItems = String.Join(", ", list.ToArray());
                Console.WriteLine(allItems);


            }

        }
    }
                

           
    }
    
