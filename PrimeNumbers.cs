using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingTechniques
{
    public class PrimeNumbers
    {
        public void Display()
        {
            bool isPrime = true;
            Console.WriteLine("Prime Number : ");
            for (int i = 2; i < 1000; i++)
            {
                for(int j=2;j<=1000;j++)
                {
                    if (i!=j && i%j==0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if(isPrime)
                {
                    Console.WriteLine("\n" + i);
                }
                isPrime = true;
            }
            Console.ReadKey();
        }
    }
}
