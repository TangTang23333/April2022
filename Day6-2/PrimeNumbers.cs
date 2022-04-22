using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_2
{
    public class PrimeNumbers
    { 

        public static int[] FindPrimesInRange(int startNum, int endNum)
        {

            // 0 --> no prime, 1 --> prime
            int[] isPrime = new int[endNum + 1];
            List<int> primes = new List<int>();
            Array.Fill(isPrime, 1);


            if (startNum == 2)
            {
                primes.Add(2); 
            }

            for (int i = 2; i < endNum; i++) {
                if ( isPrime[i] == 1) {
                 
                    for (int j = 2*i; j < endNum; j += i) {   

                        isPrime[j] = 0;
                   
                    }
                  
                    if (i >= startNum)
                    {
                        primes.Add(i);
                    }
                }
            }

            return primes.ToArray();

        }
    }
}
