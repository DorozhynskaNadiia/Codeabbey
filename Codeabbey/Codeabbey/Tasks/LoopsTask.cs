using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codeabbey
{
    class LoopsTask
    {
        public static void Run()
        {

            for (int i = 0; i <= 50; i = i + 2)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();


            int j = 50;

            while (j > -1)
            {
                Console.Write(j + " ");
                j = j - 2;
            }


            //iNT J = 0;

            //while (j < 3)
            //{
            //    Console.WriteLine("Hello, Universe! from while");
            //    j++;
            //}

            //int k = 0;

            //do
            //{
            //    Console.WriteLine("Hello, Ivan! from do while");
            //    k++;
            //}
            //while (k < 4);

            Console.ReadKey();
        }
    }
}
