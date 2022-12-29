using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    public class EvenOdd
    {
        public static void check()
        {
            Console.WriteLine("\n***************check even or odd****************\n ");
            Console.WriteLine("enter a number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("the number is even");
            }
            else
            {
                Console.WriteLine("the number is odd");
            }
        }
    }
}
