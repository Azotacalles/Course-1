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
            //Написать программу «Анкета». 
            //Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес).
            //В результате вся информация выводится в одну строчку:
            //а) используя склеивание;
            //б) используя форматированный вывод;
            //в) используя вывод со знаком $.
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите фамилию: ");
            string surname = Console.ReadLine();
            Console.Write("Введите возраст: ");
            byte age = Convert.ToByte(Console.ReadLine());
            Console.Write("Введите рост: ");
            short height = Convert.ToInt16(Console.ReadLine());
            Console.Write("Введите вес: ");
            short weight = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine(name + " " + surname + " " + age + " " + height + " " + weight);
            Console.WriteLine("{0} {1} {2} {3} {4}", name, surname, age, height, weight);
            Console.WriteLine($"{name} {surname} {age} {height} {weight}");

            Console.ReadKey();
        }
    }
}
