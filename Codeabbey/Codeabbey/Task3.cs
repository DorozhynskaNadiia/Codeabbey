using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codeabbey
{
    static class Task3
    {
        public static void Run()
        {
            /*
             * http://www.codeabbey.com/index/task_view/sum-in-loop
             */

            int rowsCount = Convert.ToInt32(Console.ReadLine());

            int[] sum = new int[rowsCount];

            for (int rowIndex = 0; rowIndex < rowsCount; rowIndex++)
            {
                string row = Console.ReadLine();

                string[] rowAsArray = row.Split(' ');

                int rowLength = rowAsArray.Length;

                for (int indexInRow = 0; indexInRow < rowLength; indexInRow = indexInRow + 1)
                {
                    sum[rowIndex] = sum[rowIndex] + Convert.ToInt32(rowAsArray[indexInRow]);
                }
            }

            for (int rowIndex = 0; rowIndex < rowsCount; rowIndex++)
            {
                Console.Write(sum[rowIndex]);
                if (rowIndex != rowsCount - 1)
                {
                    Console.Write(sum[rowIndex]);
                }
            }

            Console.ReadKey();     
            
















            //    int n = Convert.ToInt32(Console.ReadLine());

            //    string[] numbersArray = Console.ReadLine().Split(' ');
            //}

            //    int sum(params int[] numberArray)
            //            {
            //                 int sum = 0;

            //                 for(int i = 0; i < numberArray.length; i++)
            //                 {
            //                         sum += Convert.ToInt32(numberArray[i]);
            //                  }

            //                 return sum;
            //                Console.WriteLine(sum);

            //    }



            
            //int n = Convert.ToInt32(Console.ReadLine());

            //string[] numberArray = Console.ReadLine().Split(' ');

            //string[] digits1 = Console.ReadLine().Split(' ');
            //string[] digits2 = Console.ReadLine().Split(' ');

            ////int sum = 0;

            //for (int i = 0; i < n && i < digits1.Length && i < digits2.Length; i++)
            //{
            //    sum += Convert.ToInt32(digits1) * Convert.ToInt32(digits2);
            //}

            //Console.WriteLine(sum);

        }
    }

}