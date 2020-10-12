using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000. 
            //«Хорошим» называется число, которое делится на сумму своих цифр. 
            //Реализовать подсчёт времени выполнения программы, используя структуру DateTime.
            DateTime start = DateTime.Now;
            int count = 0;
            for (int i = 1; i < 100; i++)
            {
                if (i % SumDigits(i) == 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
            Console.WriteLine(DateTime.Now - start);
            Console.ReadLine();
        }

        static int SumDigits(int i)
        {
            int sum = 0;
            do
            {
                sum += i % 10;
                i /= 10;
            } while (i > 0);
            return sum;
        }
    }
}
