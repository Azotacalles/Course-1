using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static int sum = 0;
        static void Main(string[] args)
        {
            //a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
            //б) *Разработать рекурсивный метод, который считает сумму чисел от a до b
            RecPrint(1, 10);
            RecSum(1, 10);
            Console.WriteLine(sum);
            Console.ReadLine();
        }

        static void RecPrint(int a, int b)
        {
            Console.WriteLine(a);
            if (a < b)
            {
                a++;
                RecPrint(a, b);
            }
        }

        static void RecSum(int a, int b)
        {
            sum += a;
            if (a < b)
            {
                a++;
                RecSum(a, b);
            }
        }
    }
}
