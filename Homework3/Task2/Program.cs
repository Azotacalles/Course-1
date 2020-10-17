using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static List<int> numbersList = new List<int>();
        static void Main(string[] args)
        {
            //Родыгин
            //а)  С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке). 
            //Требуется подсчитать сумму всех нечётных положительных чисел. 
            //Сами числа и сумму вывести на экран, используя tryParse.
            //б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные. 
            //При возникновении ошибки вывести сообщение. Напишите соответствующую функцию;

            int number = 0;
            int sum = 0;
            do
            {
                sum += InputAndCheck(out number);
                //sum += InputAndCheckTryParse(out number);
            } while (number != 0);
            Console.Write("Все нечётные положительные числа: ");
            foreach (var item in numbersList)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            Console.WriteLine($"Сумма всех нечётных положительных чисел: {sum}");

            Console.ReadKey();
        }

        static int InputAndCheck(out int number)
        {
            Console.Write("Введите число: ");
            try
            {
                number = int.Parse(Console.ReadLine());
                if (number % 2 == 1 && number > 0) 
                {
                    numbersList.Add(number);
                    return number; 
                }
                else return 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                number = -1;
                return 0;
            }
        }

        static int InputAndCheckTryParse(out int number)
        {
            Console.Write("Введите число: ");
            if (int.TryParse(Console.ReadLine(), out number))
            {
                if (number % 2 == 1 && number > 0) 
                {
                    numbersList.Add(number);
                    return number; 
                }
                else return 0;
            }
            else
            {
                Console.WriteLine("Введено не число");
                number = -1;
                return 0;
            }
        }
    }
}
