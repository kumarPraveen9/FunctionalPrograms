using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    public class flipCoin
    {
        public static void flips()
        {
            int i = 1;
            int head = 0;
            int tail = 0;
            int headPercent = 0;
            int tailPercent = 0;
            Console.WriteLine("***************Flip Coin Percentage***************");
            Console.WriteLine("Enter a number of flips");
            int r=Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
           
            for (i = 1; i <= r; i++)
            {
                int p = random.Next(2);
               
                if (p < 0.5) tail++;
                else head++;
            Console.WriteLine("current{0} flip is : {1}", i, p);
            }

            headPercent = (head * 100) / r;
            tailPercent= (tail * 100) / r;
            Console.WriteLine("head percentage is : {0}", headPercent);
            Console.WriteLine("tail percentage is : {0}", tailPercent);
        }
    }
}
