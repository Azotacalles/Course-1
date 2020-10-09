using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {   
            //а) Написать программу, которая подсчитывает расстояние между 
            //точками с координатами x1, y1 и x2,y2 по формуле 
            //r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). 
            //Вывести результат, используя спецификатор формата .2f 
            //(с двумя знаками после запятой);
            //б) *Выполнить предыдущее задание, оформив вычисления расстояния 
            //между точками в виде метода.
            Console.Write("Введите x1: ");
            double x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите y1: ");
            double y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите x2: ");
            double x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите y2: ");
            double y2 = Convert.ToInt32(Console.ReadLine());
            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine($"{r:f2}");

            Distance(x1, y1, x2, y2);

            Console.ReadKey();
        }

        static void Distance(double x1, double y1, double x2, double y2)
        {
            Console.WriteLine($"{ Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)):f2}");
        }
    }
}
