using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codeabbey.Tasks
{
    class HomeAssignment1
    {
        public static void Run()
        {

            //1
            byte byteType;
            short shortType;
            int intType;
            long longType;
            float floatType;
            double doubleType;
            char charType;
            string[] stringArray = new string[3];
            int[] integerArray = new int[3];

            //2
            var byteValue = 4;
            var shortValue = 30255;
            var intValue = 259672947;
            var longValue = 36962956385620574;
            var floatValue = 0.01;
            var doubleValue = 859.9876;
            var charValue = '&';
            var stringList = new[] { "Tom", "Jerry", "Lewis" };
            var intList = new[] { 1, 2, 3, };

            //3
            const double PI = 3.14159;
            const double Avogadro = 6.02214199e23;
            const byte DaysOfJanuary = 31;


            //4
            double squareValue = 50.24;
            byte growthValue = 167;
            short caloriesValue = 1600;
            string studentGroup = "PF";
            string homeAddress = "Ukraine, Lviv, Linkolna street, 45";

            //5
            string[] favoriteDishes = new string[4] { "Salmon steak", "Pizza", "Cheese Lasagna", "Chocolate cake" };

            //6
            int[] digitList = new int[10];
            digitList[0] = 0;
            digitList[1] = 1;
            digitList[2] = 2;
            digitList[3] = 3;
            digitList[4] = 4;
            digitList[5] = 5;
            digitList[6] = 6;
            digitList[7] = 7;
            digitList[8] = 8;
            digitList[9] = 9;

            int[] digitsList = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //7
            char[] digitsAndLetterList = new char[16] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };


            /*
               Оголошення змінних, ініціалізація та іменування, константи.
               Оголосити:
                  1. змінні: цілого типу, с плаваючою крапкою, символьного типу, масив стрічок, масив цілих чисел(тип змінних вказувати явно при оголошенні, без ініціалізації);
                  2. оголосити ті самі змінні, але використовуючи var(для цього одразу необхідно виконати їх ініціалізацію)
                  3. оголосити константу для числа пі(точність до десятитисячних), числа авогадро  6.022140857×10^23 та кількості днів у січні місяці
                  4. оголосити змінні для збереження наступних значень(самостійно дати імена, обрати тип та записати значення)
                      - площа круга з радіусом 4 см 
                      - свій зріст в сантиметрах
                      - свою щоденну норму ккал 
                      - назву своєї студентської групи
                      - свою адресу проживання
                  5. перерахувати свої улюблені страви в масиві(не менше 4)
                  6. оголосити масив в який записати всі цифри від 0 до 9
                  7. оголосити масив в який записати всі шінадцяткові цифри від 0 до F (0-9 та A - F)

               * Tips
               * Для іменування змінних використовують camleCase, констант - UpperCamelCase
               * При оголошенні змінної за допомогою ключового слова var ініціалізація обов'язкова, інакше компілятор не зможе зрозуміти тип змінної.
               * Якщо гарантовано відомо, що ціле значення не буде більше 255(як кількість днів у місяці), 
               * то немає сенсу використовувати int чи long, можна зекономити пам'ять і використати тип byte
               * Для збереження цілих значень ліпше икористовувати цілі типи данни byte, Int16, Int32, Int64 
            */

        }

    }
}
