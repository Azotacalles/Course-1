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
            //Дан  целочисленный  массив  из 20 элементов.  Элементы  массива  могут принимать  целые  значения  от –10 000 до 10 000 включительно. 
            //Заполнить случайными числами.  Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых только одно число делится на 3. 
            //В данной задаче под парой подразумевается два подряд идущих элемента массива. Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2. 

            int[] mass = new int[20];
            InitArray(mass);
            PrintArray(mass);
            Console.WriteLine($"Количество пар, в которых только одно число делится на 3: {CountСouple(mass)}");
            Console.ReadLine();
        }

        static void InitArray(int[] mass)
        {
            Random random = new Random();
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = random.Next(-10000, 10001);
            }
        }

        static void PrintArray(int[] mass)
        {
            Console.Write("Массив: ");
            foreach (var item in mass)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static byte CountСouple(int[] mass)
        {
            byte count = 0;
            for (int i = 0; i < mass.Length - 1; i++)
            {
                if (mass[i] % 3 == 0 && mass[i + 1] % 3 != 0) count++;
                if (mass[i] % 3 != 0 && mass[i + 1] % 3 == 0) count++;
            }
            return count;
        }
    }
}
