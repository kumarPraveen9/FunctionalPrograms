using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    public class Swap
    {

        public static void swaping()
        {
            int temp = 0;
            int b = 5;
            Console.WriteLine("***************swaping the values****************\n ");
            Console.WriteLine("enter the 'a' value: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("the a value is : " + a);
            Console.WriteLine("the b value is : " + b);

           
            if (a > 0)
            {
                temp = a;
                a = b;
                b = temp;
            }
            Console.WriteLine("the a value is : " + a);
            Console.WriteLine("the b value : " + b);
        }
    }
}