using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            //a) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, 
            //нужно ли человеку похудеть, набрать вес или всё в норме.
            //б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
            Console.Write("Введите вес (кг): ");
            double weight = Convert.ToInt16(Console.ReadLine());
            Console.Write("Введите рост (м): ");
            double height = Convert.ToDouble(Console.ReadLine());
            double bmi = weight / (height * height);
            Console.WriteLine("{0:f2}", bmi);
            if (bmi < 18.5) 
            { 
                Console.WriteLine("Низкий индекс массы тела");
                Console.WriteLine($"Наберите {ChangeWeight(weight, height, 18.5)} кг");
            }
            else
            {
                if (bmi <= 25) { Console.WriteLine("Нормальный индекс массы тела"); }
                else 
                { 
                    Console.WriteLine("Высокий индекс массы тела");
                    Console.WriteLine($"Сбросьте {ChangeWeight(weight, height, 25) * (-1)} кг");
                }
            }

            Console.ReadLine();
        }

        static double ChangeWeight(double weight, double height, double normBmi)
        {
            double normWeight = normBmi * height * height;
            return Math.Round(normWeight - weight, 0);
        }
    }
}
