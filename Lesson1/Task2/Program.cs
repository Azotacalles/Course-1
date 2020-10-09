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
            //Ввести вес и рост человека. Рассчитать и вывести индекс массы тела(ИМТ) 
            //по формуле I = m / (h * h); где m — масса тела в килограммах, h — рост в метрах.
            Console.Write("Введите вес (кг): ");
            short weight = Convert.ToInt16(Console.ReadLine());
            Console.Write("Введите рост (м): ");
            double height = Convert.ToDouble(Console.ReadLine());
            double bmi = weight / (height * height);
            Console.WriteLine("{0:f2}", bmi);
            Console.ReadKey();
        }
    }
}
