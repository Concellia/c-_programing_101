using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingC_
{
    internal class PrimeNumbers
    {

        public static List<int> getPrime(int n)
        {
            List<int> primeNumbers = new List<int>();
            bool isPrime = true;

            for(int i = 2; i <= n; i++)
            {

                for(int j = 2; j <= n; j++)
                {

                    if(i%j == 0 && i != j)
                    {
                        isPrime = false;
                        break;

                    }
                    else
                    {
                        isPrime = true;
                    }
                    
                }

                if (isPrime)
                {
                    primeNumbers.Add(i);
                }

            }

            return primeNumbers;
        }
    }
}
