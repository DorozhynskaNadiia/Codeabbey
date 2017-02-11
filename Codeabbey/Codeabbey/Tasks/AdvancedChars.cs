using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codeabbey
{
    class AdvancedChars
    {
        public static void Run()
        {
            /*
             * Aa Bb Cc Dd Ee Ff .. .. .. ..  Yy Zz
             *    Aa Bb Cc Dd Ee .. .. .. ..  Xx Yy
             *       Aa Bb Cc Dd .. .. .. ..  WW Xx
             *       ..............................
             *                                Pp Rr
             *                                Pp Rr
             *       ..............................
             *    Aa Bb Cc Dd Ee .. .. .. ..  Xx Yy
             * Aa Bb Cc Dd Ee Ff .. .. .. ..  Yy Zz
             * 
             * 
             * 52 lines 26(*2) columns
             */


            var n = 25;
            for (var row = 0; row < n; row++)
            {
                for (var column = 0; column < n; column++)
                {
                    char character;
                    if (column >= row)
                    {
                        character = 'X';
                    }
                    else
                    {
                        character = ' ';
                    }
                    Console.Write(character + " ");
                }
                Console.WriteLine();
            }

            for (var column = n; column > 0; column--)
            {
                for (var row = n; row > 0; row--)
                {
                    char character;
                    if (column <= n + 1 - row)
                    {
                        character = 'X';
                    }
                    else
                    {
                        character = ' ';
                    }
                    Console.Write(character + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
