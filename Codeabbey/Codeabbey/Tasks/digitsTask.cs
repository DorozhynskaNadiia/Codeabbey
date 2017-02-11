using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
* 1 2 3 4 5 ... 10
* 11 12 13 ...  20
* 21 22 23 ... 30
*/

namespace Codeabbey
{
    class DigitsTask
    {
        public static void Run()
        {
            //vertical
            var n = 20;
            var m = 5;

            for (var row = 0; row < n; row++)
            {
                for (var column = 0; column < m; column++)
                {
                    Console.Write("{0}\t", column * n + row + 1);
                }
                Console.WriteLine();
            }
        }
    }
}

//horizontal
//var n = 20;
// var m = 5;

//   for (var row = 0; row < n; row++)
//  {
//     for (var column = 0; column < m; column++)
//     {
//         Console.Write("{0}\t", row * m + column + 1);
//     }
//      Console.WriteLine();