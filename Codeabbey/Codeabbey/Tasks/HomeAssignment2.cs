using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codeabbey.Tasks
{
    class HomeAssignment2
    {
        public static void Run()
        {

            //1
            //Console.Write("Enter value in kg: ");
            //string input = Console.ReadLine();

            //Console.Write("Enter precision: ");
            //string value = Console.ReadLine();

            //Console.WriteLine("Result:");

            //int Precision = Convert.ToInt32(value);

            //var lb = Convert.ToInt32(input) * 2.2046226;
            //Console.WriteLine("{0} kg = {1} lb", input, Math.Round(lb,Precision));

            //var oz = Convert.ToDouble(input) / 0.02834952;
            //Console.WriteLine("{0} kg = {1} oz", input, Math.Round(oz,Precision));

            //Console.ReadKey();


            //2
            //Console.WriteLine("Please enter a, b, c ");

            //string inputOne = Console.ReadLine();
            //var a = Convert.ToDouble(inputOne);

            //string inputTwo = Console.ReadLine();
            //var b = Convert.ToDouble(inputTwo);

            //string inputThree = Console.ReadLine();
            //var c = Convert.ToDouble(inputThree);

            //var doesNotExist = (a + b <= c) || (a + c <= b) || (b + c <= a);
            //if (doesNotExist)
            //{
            //    Console.WriteLine("Doesn't exist");
            //}
            //else
            //{
            //    double p = (a + b + c) / 2;
            //    double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            //    Console.WriteLine("S = {0}", Math.Round(s, 2));
            //}
            //Console.ReadKey();


            //3
            //Console.Write("Please enter number: ");
            //string input = Console.ReadLine();

            //int number = Convert.ToInt32(input) % 2;
            //if (number == 1)
            //{
            //    Console.WriteLine("Odd");
            //}
            //else {
            //    Console.WriteLine("Even");
            //}
            
            //Console.ReadKey();



            //4
            //Console.WriteLine("Please enter numbers A and B, where A < B ");

            //string inputOne = Console.ReadLine();
            //int a = Convert.ToInt32(inputOne);

            //string inputTwo = Console.ReadLine();
            //int b = Convert.ToInt32(inputTwo);

            //Console.WriteLine("Please enter number C ");

            //string inputThree = Console.ReadLine();
            //double c = Convert.ToDouble(inputThree);

            //if (c <= a)
            //{
            //    Console.WriteLine("Right");
            //}
            //else if (c >= b)
            //{
            //    Console.WriteLine("Left");
            //}
            //else if ((a < c) && (c < b))
            //{
            //    Console.WriteLine("Middle");
            //}
            //Console.ReadKey();


            //5
            Console.Write("Your number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            bool isEven = ((a % 2) == 0);

            Console.WriteLine(isEven);

            Console.ReadKey();


        }
    }
}
