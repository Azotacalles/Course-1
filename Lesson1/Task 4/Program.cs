using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Написать программу обмена значениями двух переменных:
            //а) с использованием третьей переменной;
            //б) *без использования третьей переменной.
            int number1 = 5;
            int number2 = 60;
            int temp;
            Console.WriteLine($"1: {number1} | 2: {number2} ");
            temp = number1;
            number1 = number2;
            number2 = temp;
            Console.WriteLine($"1: {number1} | 2: {number2} ");
            number1 = number1 + number2;
            number2 = number1 - number2;
            number1 = number1 - number2;
            Console.WriteLine($"1: {number1} | 2: {number2} ");
            Console.ReadKey();
        }
    }
}
