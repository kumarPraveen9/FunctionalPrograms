using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    public class LargestNumber
    {
        public static void large()
        {

            Console.WriteLine("**************largest of three numbers****************");
            Console.WriteLine("Enter a first number : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a second number : ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a third number : ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            if ((a > b) && (a > c))
                Console.WriteLine("{0} is large number",a);
            else if ((b>a) && (b> c))
                Console.WriteLine("{0} is large number",b);
            else
                Console.WriteLine("{0} is large number",c);
        }
    }
}
