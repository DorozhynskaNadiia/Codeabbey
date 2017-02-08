using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codeabbey
{
    class CharsTask
    {
        public static void Run()
        {
            char capitalLetter;
            char smallLetter;
            string pattern = "|\t{0}{1}\t|\n";

            for (int i = 97; i <= 122; i++)
            {
                capitalLetter = Convert.ToChar(i - 32);
                smallLetter = Convert.ToChar(i);

                Console.Write(pattern, capitalLetter, smallLetter);
                
            }

            for (char letter = 'a'; letter <= 'm'; letter++)
                Console.Write(pattern, (char)(letter - 32), letter);

            Console.ReadKey();
        }
    }
}
