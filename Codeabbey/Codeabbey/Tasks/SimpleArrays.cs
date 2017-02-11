using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codeabbey
{
    class SimpleArrays
    {
        public static void Run()
        {
            #region notes
            //Console.Write("N = ");
            //int n = Convert.ToInt32(Console.ReadLine());

            //int[] array = new int[n];

            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write("Array[{0}] = ", i);
            //    array[i] = Convert.ToInt32(Console.ReadLine());
            //}
            
            //string joinedArray = string.Join(";", array);
            //Console.WriteLine("You input: {0}", joinedArray);

            //string name = "Ivan";

            //char[] surname = new char[] { 'P', 'e', 'c', 'a', 'r', 'y', 't', 's', 'i', 'a' };

            //for (int i = 0; i < name.Length; i++)
            //{
            //    Console.WriteLine(name[i]);
            //}

            //for (int i = 0; i < surname.Length; i++)
            //{
            //    Console.WriteLine(surname[i]);
            //}

            /*
            string.Compare
            string.Concat
            string.Join
            string.Empty == ""
            string.IsNullOrEmpty
            Contains
            IndexOf
            Replace
            Split
            * 
            * 
             */

            //string name = "Ivan Pecharytsia";
            
            //string otherName = name;
            //string[] myNames = new string[] { "Ivan", "Ivanovich", "Pecharytsia" };
            //string joined = string.Join(" ", myNames);
            //Console.WriteLine(joined);
            //string text = Console.ReadLine();
            //string[] otherArray = text.Split(' ', '_');

            
            //string greetingPattern = "Hello {0}. Nice to meet you at {1}. You tickets cost: {2:C1} ";

            //string text = string.Format(greetingPattern, "Nadiya", DateTime.Now, 200);
            //string fullName = "Nadiya Dorozhynska";
            //Console.WriteLine(text);
            //Console.WriteLine(greetingPattern, "Ivan", DateTime.Now, 340.50);
            //Console.WriteLine(fullName.Replace("Nadiya", "Ivan"));
            #endregion


            Console.Write("N = ");
            string input = Console.ReadLine();
            int n = Convert.ToInt32(input);

            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Number[{0}]: ", i);
                input = Console.ReadLine();
                numbers[i] = Convert.ToInt32(input);
            }
            
            Console.WriteLine(string.Join(" ", numbers.Reverse()));


        }
    }
}
