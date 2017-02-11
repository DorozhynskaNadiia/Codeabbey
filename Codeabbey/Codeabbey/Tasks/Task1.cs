using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Codeabbey
{
    static class Task1
    {
        public static void Run()
        {

            /*
             * http://www.codeabbey.com/index/task_view/sum-of-two 
             */

            string input = Console.ReadLine();          //declare string variable and read input from console

            string[] inputArray = input.Split(' ');     //declare string array and initialize by splited values from input

            string aStr = inputArray[0];                //get first element of array
            string bStr = inputArray[1];

            int a = int.Parse(aStr);                    //parse first element to int vriable
            int b = int.Parse(bStr);


            Console.WriteLine(a + b);                   //write sum of two integers

        }
    }
}
