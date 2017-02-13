using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codeabbey.Tasks
{
    class StudyingArray
    {
        public static void Run()
        {

            string[] names = new string[3] {
                "Tom", "Jerry", "Lewis"
            };

            int[] array = new int[5];

            //array[0] = 24;
            //array[1] = 3;
            //array[2] = 57;
            //array[3] = 73;
            //array[4] = 2;

            for (int i = 0; i < names.Length; i++)

                Console.WriteLine(names[i]);

        }
    }
}
