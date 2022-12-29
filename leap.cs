using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    public class leap
    {
       
            public static void display()
            {
            Console.WriteLine("**************leap year or not****************");
            Console.WriteLine("Enter a Year to check whether it is leap year or not");
                int year = Convert.ToInt32(Console.ReadLine());
                if ((year > 999) && (year < 10000))
                {
                    if (year % 400 == 0)
                    {
                        Console.WriteLine("Yeah, your year is leap year");
                    }
                    else if ((year % 4 == 0) && (year % 100 != 0))
                    {
                        Console.WriteLine("Yeah, your year is leap year");
                    }
                    else
                    {
                        Console.WriteLine("Oops, your year is not leap year");
                    }
                }
                else
                {
                    Console.WriteLine("enter a valid year");
                }
            }
        }
    }

