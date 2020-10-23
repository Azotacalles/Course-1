using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Родыгин
            //Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.
            //Например:
            //    badc являются перестановкой abcd.
            Console.Write("Введите 1 строчку: ");
            string s1 = Console.ReadLine();
            Console.Write("Введите 2 строчку: ");
            string s2 = Console.ReadLine();
            if (CheckStrings(s1, s2)) Console.WriteLine($"{s1} перестановка {s2}");
            else Console.WriteLine($"{s1} не перестановка {s2}");
            Console.ReadLine();
        }

        /// <summary>
        /// Определение является ли одна строка перестановкой другой
        /// </summary>
        /// <param name="s1">Первая строка</param>
        /// <param name="s2">Вторая строка</param>
        /// <returns>Результат определения является ли одна строка перестановкой другой</returns>
        static bool CheckStrings(string s1, string s2)
        {
            bool check = false;
            for (int i = 0; i < s1.Length; i++)
            {
                check = false;
                for (int j = 0; j < s2.Length; j++)
                {
                    if (s1[i] == s2[j])
                    {
                        check = true;
                        s2 = s2.Remove(j, 1);
                        break;
                    }
                }
                if (!check) return false;
            }
            if (s2.Length > 0) return false;
            else return true;
        }
    }
}
