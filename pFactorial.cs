using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    public class pFactorial
    {
        public static void display1()
        {
            int isPrime = 0;
            Console.WriteLine("***************Find Factors***************");
            Console.WriteLine("\n Please Enter a number to Find Factors :  ");

            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= n; i++)
            {
                if (n % i == 0)
                {
                    isPrime = 1;
                    for (int j = 2; j <= i / 2; j++)
                    {
                        if (i % j == 0)
                        {
                            isPrime = 0;
                            break;
                        }
                    }
                    if (isPrime == 1)
                    {
                        Console.WriteLine("\n " + n + " Prime Factor is " + i);
                    }
                }
            }
        }
    }
}
