using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    public class VowelConsonent
    {
        public static void checkk()
        {
            Console.WriteLine("\n***************check Ovel or Consonent****************\n ");
            Console.WriteLine("enter single char from a to z: ");
            char inputstring = Convert.ToChar(Console.ReadLine());


            if (inputstring == 'a' || inputstring == 'e' ||
             inputstring == 'i' || inputstring == 'o' ||
             inputstring == 'u' || inputstring == 'A' ||
             inputstring == 'E' || inputstring == 'I' ||
             inputstring == 'O' || inputstring == 'U')
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("consonent");
            }
        }
    }
}
