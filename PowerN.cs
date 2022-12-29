using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    public class PowerN
    {
        
        
            public static void pow()
            {
                Console.WriteLine("***************nth Power***************");
                Console.WriteLine("Hey Buddy, please enter a value: ");
                int n = Convert.ToInt32(Console.ReadLine());
                if ((n >= 0) && (n < 31))
                {
                    for (int i = 0; i <= n; i++)
                    {
                        double result = Math.Pow(2, i);
                        Console.WriteLine(result);
                    }
                }
                else
                {
                    Console.WriteLine("enter valid n value");
                }

            }
        
    }

}

