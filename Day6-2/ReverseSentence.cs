using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_2
{
    public class ReverseSentence
    {
        public static void Get(string s)
        {
            int n = s.Length;
            //int i = 0, j = n - 1; 
            //List<string> words = s.Split(' ', '.', ',', ':',';', '=', '(',  '&', '[', ']', '"', '\'' , '/', '!','?', ')').ToList();



            List<string> words = s.Split(' ').ToList();
            //Console.WriteLine(String.Join(", ", words.ToArray()));


            StringBuilder start = new StringBuilder ();
            StringBuilder end   = new StringBuilder ();
            int i = 0, j = n - 1;

            while (i < j)
            {
        
                StringBuilder left = new StringBuilder();
                StringBuilder right = new StringBuilder();
                StringBuilder left_s = new StringBuilder();
                StringBuilder right_s = new StringBuilder();

                
                while (i < j && (Char.IsDigit(s[i]) || Char.IsLetter(s[i])))
                {
                    left.Append(s[i]);
                    i += 1;
                }
                end.Append(left);
                Console.WriteLine($"now the end is {end.ToString()}");
                

                while (j > i && (Char.IsDigit(s[i]) || Char.IsLetter(s[i])))
                {
                    right.Append(s[j]);
                    j -= 1;
                }
                start.Append(right);

                Console.WriteLine($"now the start is {start.ToString()}");

                while (i < j && (!Char.IsDigit(s[i]) && !Char.IsLetter(s[i])))
                {
                    left_s.Append(s[i]);
                    i += 1;
                }
                start.Append(left_s);

                Console.WriteLine($"now the start is {start.ToString()}");



                while (i < j && (!Char.IsDigit(s[j]) && !Char.IsLetter(s[j])))
                {
                    right_s.Append(s[j]);
                    j -= 1;
                }
                end.Append (right_s);

                Console.WriteLine($"now the end is {end.ToString()}");


                // both side meet space , switch 
                Console.WriteLine($"i is {i} j is {j}");


            }
            Console.WriteLine(start.ToString());
        }

    } }
    

