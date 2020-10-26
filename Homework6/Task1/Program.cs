using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public delegate double Fun(double a, double x);
    class Program
    {
        static void Main(string[] args)
        {
            //Родыгин
            //Изменить программу вывода таблицы функции так, чтобы можно было передавать функции типа double (double, double). 
            //Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x).
            Table(MyFunc, 2, -2, 2);
            Table(MySin, 2, -2, 2);
            Console.ReadLine();
        }

        static void Table(Fun F, double a, double x1, double x2)
        {
            Console.WriteLine("----- A ------- X -------- Y -----");
            while (x1 <= x2)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} | {2,8:0.000} |",a , x1, F(a, x1));
                x1 += 1;
            }
            Console.WriteLine("----------------------------------");

        }

        static double MySin(double a, double x)
        {
            return a * Math.Sin(x);
        }

        static double MyFunc(double a, double x)
        {
            return a * x * x;
        }
    }
}
