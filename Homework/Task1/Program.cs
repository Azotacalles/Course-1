using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Родыгин
            //Написать метод, возвращающий минимальное из трёх чисел.
            Console.Write("Введите 1 число: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите 2 число: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите 3 число: ");
            int number3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Min: {Min(number1, number2, number3)}");
            Console.ReadLine();
        }

        static int Min(int number1, int number2, int number3)
        {
            if (number1 < number2 && number1 < number3) { return number1; }
            else 
            {
                if(number2 < number3) { return number2; }
                else { return number3; }
            }
        }
    }
}
