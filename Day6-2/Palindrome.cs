using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_2
{
    internal class Palindrome
    {

        public static string[] Get(string s)
        {
            string[] words = s.Split(' ', '.', ',', ':', ';', '=', '(', '&', '[', ']', '"', '\'', '/', '!', '?', ')');
            List<string> res = new List<string>();

            for (int k = 0; k < words.Length; k++)
            {
                if (words[k].Length == 1)
                {
                    res.Add(words[k]);
                }
                else
                {
                    for (int i = 0, j = words[k].Length - 1; i < j; i++, j--)
                    {

                        
                        if (words[k][i] != words[k][j])
                        {
                     
                            break;
                        }

                        if (j - i == 1 || j-i == 2)
                        {
                          
                            res.Add(words[k]);
                            break;
                        }
                    }

                    

                }
            }
            
            return res.ToArray();
        }

    }
}
