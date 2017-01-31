using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codeabbey
{
    static class Task2
    {
        public static void Run()
        {
            int n = Convert.ToInt32(Console.ReadLine());                    // declare integer n and write converted value from console to n

            string[] numbersArray = Console.ReadLine().Split(' ');          // write splited numbers from console to string array

            int sum = 0;                                                    // declare integer sum with zero initial value

            for (int i = 0; i < n; i = i + 1)                               // make n iteration til counter(i) < n
            {
                sum = sum + Convert.ToInt32(numbersArray[i]);               // on each iteration convert numbersArray[i] value to int and add to sum
            }

            Console.WriteLine(sum);
        }
    }
}
