using System;
using System.Collections.Generic;
using System.IO;
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
            //Реализуйте задачу 1 в виде статического класса StaticClass;
            //а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
            //б) *Добавьте статический метод для считывания массива из текстового файла. Метод должен возвращать массив целых чисел;
            int[] mass = new int[20];
            InitArray(mass);
            PrintArray(mass);
            Console.WriteLine($"Количество пар, в которых только одно число делится на 3: {StaticClass.CountСouple(mass)}");
            Console.WriteLine();

            mass = StaticClass.InitArrayFromFile();
            PrintArray(mass);
            Console.WriteLine($"Количество пар, в которых только одно число делится на 3: {StaticClass.CountСouple(mass)}");
            Console.ReadLine();
        }

        /// <summary>
        /// Инициализация массива рандомными числами от -10_000 до 10_000
        /// </summary>
        /// <param name="mass">Массив</param>
        static void InitArray(int[] mass)
        {
            Random random = new Random();
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = random.Next(-10000, 10001);
            }
        }

        /// <summary>
        /// Вывод массива на экран
        /// </summary>
        /// <param name="mass">Массив</param>
        static void PrintArray(int[] mass)
        {
            Console.Write("Массив: ");
            foreach (var item in mass)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }

    static class StaticClass
    {
        /// <summary>
        /// Поиск пар чисел, в которых только одно кратно 3
        /// </summary>
        /// <param name="mass">Массив</param>
        /// <returns>Количество пар</returns>
        public static byte CountСouple(int[] mass)
        {
            byte count = 0;
            for (int i = 0; i < mass.Length - 1; i++)
            {
                if (mass[i] % 3 == 0 && mass[i + 1] % 3 != 0) count++;
                if (mass[i] % 3 != 0 && mass[i + 1] % 3 == 0) count++;
            }
            return count;
        }

        /// <summary>
        /// Возвращает массив чисел из файла
        /// </summary>
        /// <returns>Массив</returns>
        public static int[] InitArrayFromFile()
        {
            int[] mass = new int[20];
            string[] arrayFile = File.ReadAllLines("ArrayFile.txt");
            for (int i = 0; i < arrayFile.Length; i++)
            { 
                mass[i] = int.Parse(arrayFile[i]); 
            }
            return mass;
        }
    }
}
