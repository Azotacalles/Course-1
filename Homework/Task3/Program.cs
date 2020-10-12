using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Родыгин
            //С клавиатуры вводятся числа, пока не будет введен 0. 
            //Подсчитать сумму всех нечетных положительных чисел.
            int number;
            int sum = 0;
            do
            {
                Console.Write("Введите число: ");
                number = Convert.ToInt32(Console.ReadLine());
                if(number >= 0 && number % 2 == 1) { sum += number; }
            } while (number != 0);
            Console.WriteLine($"Сумма чисел: {sum}");
            Console.ReadLine();
        }
    }
}
