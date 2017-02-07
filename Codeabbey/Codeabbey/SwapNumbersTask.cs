using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codeabbey
{
    class SwapNumbersTask
    {
        public static void Run()
        {
            Console.Write("A = ");

            string input;
            input = Console.ReadLine();

            var a = Convert.ToChar(input);

            Console.Write("B = ");
            
            input = Console.ReadLine();
            var b = Convert.ToChar(input);

            char c = b;
            b = a;
            a = c;

            Console.WriteLine("Swaped values: A = {0}, B = {1}", a, b);
            Console.ReadKey();

        }
    }
}
