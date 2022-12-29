using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    public class QueRem
    {
        public static void Qre()
        {
            double q,r;
            
            Console.WriteLine("***************Quotient and Remainder***************");
            Console.WriteLine("\nPlease Enter a number to Find Quotient and Remainder :  ");

            double n = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("\nEnter a number to know on which number you are operating to find your Quotient and Remainder :  ");

            double m = Convert.ToDouble(Console.ReadLine());

            r = n % m;
            q = n / m;

            Console.WriteLine("Your Quotient is  :: {0} \nYour Remainder is :: {1} ", q, r);

        }
    }
}
