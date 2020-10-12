using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Родыгин
            //Написать метод подсчета количества цифр числа.
            Console.Write("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"В {number} {CountDigits(number)} цифр");
            Console.ReadLine();
        }

        static byte CountDigits(int number)
        {
            byte count = 0;
            do
            {
                count++;
                number /= 10;
            } while (number > 0);
            return count;
        }
    }
}
