using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    public class HarmonicNumber
    {
        public static void nval()
        {
            Console.WriteLine("***************nth harmonic value***************");
            Console.WriteLine("Hi, Please give the nth harmonic value");
            int h = Convert.ToInt32(Console.ReadLine());
            double result = 0.0;
            if (h != 0)
            {
                for (int i = 1; i <= h; i++)
                {

                    result += 1 / (float)i;


                }
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("enter a valid number");
            }
        }
    }
}
