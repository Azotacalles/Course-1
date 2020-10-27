using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public delegate double MyFunction(double x);

    class Program
    {
        static void Main(string[] args)
        {
            //Родыгин
            //Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата. 
            //а) Сделать меню с различными функциями и представить пользователю выбор, для какой функции и на каком отрезке находить минимум.
            //Использовать массив(или список) делегатов, в котором хранятся различные функции.
            //б) *Переделать функцию Load, чтобы она возвращала массив считанных значений.
            //Пусть она возвращает минимум через параметр(с использованием модификатора out). 
            List <MyFunction> listFun = new List<MyFunction>();
            listFun.Add(F1);
            listFun.Add(F2);
            listFun.Add(F3);
            int choice = 0, start = 0, end = 0;
            Input(ref choice, ref start, ref end);
            double[] valuesFun;
            double minValue;
            SaveFunc(listFun[choice - 1], "data.bin", start, end, 0.5);
            valuesFun = Load("data.bin", out minValue);
            Console.WriteLine(minValue);
            Console.ReadKey();

        }

        /// <summary>
        /// Ввод данных
        /// </summary>
        /// <param name="choose">Выбор функции</param>
        /// <param name="start">Начало отрезка</param>
        /// <param name="end">Конец отрезка</param>
        static void Input(ref int choose, ref int start, ref int end)
        {
            do
            {
                Console.WriteLine("Выберите номер функции: 1, 2, 3");
                CheckInput(Console.ReadLine(), ref choose);
                if (choose >= 1 && choose <= 3) break;
                Console.WriteLine("Ошибка!");
            } while (true);
            bool right = false;
            do
            {
                right = false;
                Console.WriteLine("Введите начало и конец отрезка:");
                right = CheckInput(Console.ReadLine(), ref start);
                if(right) right = CheckInput(Console.ReadLine(), ref end);
            } while (!right);
        }

        /// <summary>
        /// Проверка ввода данных
        /// </summary>
        /// <param name="data">Строка данных</param>
        /// <param name="value">Данные в виде числа</param>
        /// <returns>Получилось ли сконвертировать данные</returns>
        static bool CheckInput(string data, ref int value)
        {
            try
            {
                value = int.Parse(data);
                return true;
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Функция
        /// </summary>
        /// <param name="x">Значение функции по оси x</param>
        /// <returns>Значение функции по оси y</returns>
        public static double F1(double x)
        {
            return x * x - 50 * x + 10;
        }

        public static double F2(double x)
        {
            return x * x;
        }

        public static double F3(double x)
        {
            return x * x * x;
        }

        /// <summary>
        /// Сохранение данных в файл
        /// </summary>
        /// <param name="F">Функция</param>
        /// <param name="fileName">Имя файла</param>
        /// <param name="a">Начало отрезка</param>
        /// <param name="b">Конец отрезка</param>
        /// <param name="h">Шаг</param>
        public static void SaveFunc(MyFunction F, string fileName, double a, double b, double h)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(F(x));
                x += h;
            }
            bw.Close();
            fs.Close();
        }

        /// <summary>
        /// Загрузка данных из файла
        /// </summary>
        /// <param name="fileName">Имя файла</param>
        /// <param name="minValue">Минимальное значение</param>
        /// <returns>Массив данных из файла</returns>
        public static double[] Load(string fileName, out double minValue)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);

            int lenght = (int)fs.Length / sizeof(double);
            double[] arrayValue = new double[lenght];
            double min = double.MaxValue;
            double d;
            for (int i = 0; i < lenght; i++)
            {
                d = bw.ReadDouble();
                if (d < min) min = d;
            }
            bw.Close();
            fs.Close();
            minValue = min;
            return arrayValue;
        }
    }
}
