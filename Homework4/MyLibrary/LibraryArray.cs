using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class LibraryArray
    {
        int[] array;

        /// <summary>
        /// Сумма всех элементов в массиве
        /// </summary>
        public int Sum
        {
            get
            {
                int sum = 0;
                foreach (var item in array)
                {
                    sum += item;
                }
                return sum;
            }
        }

        /// <summary>
        /// Количество максимальных значений в массиве
        /// </summary>
        public int MaxCount
        {
            get
            {
                int max = Max();
                int count = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (max == array[i]) count++;
                }
                return count;
            }
        }

        /// <summary>
        /// Поиск максимума в массиве
        /// </summary>
        /// <returns>Максимальное значение в массиве</returns>
        private int Max()
        {
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (max < array[i]) max = array[i];
            }
            return max;
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="size">Размер массива</param>
        /// <param name="firstValue">Начальное значение</param>
        /// <param name="step">Шаг, с которым будут изменяться значения</param>
        public LibraryArray(int size, int firstValue, int step)
        {
            array = new int[size];
            int value = firstValue;
            for (int i = 0; i < size; i++)
            {
                array[i] = value;
                value += step;
            }
        }

        /// <summary>
        /// Изменение знака всех элементов массива
        /// </summary>
        /// <returns>Изменёный массив</returns>
        public int[] Inverse()
        {
            int[] tempArray = new int[array.Length];
            for (int i = 0; i < tempArray.Length; i++)
            {
                tempArray[i] = array[i] * (-1);
            }
            return tempArray;
        }

        /// <summary>
        /// Умножение всех элементов массива на число
        /// </summary>
        /// <param name="value">Число, на которое умножаются элементы</param>
        public void Milti(int value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array[i] * value;
            }
        }

        /// <summary>
        /// Вывод массива на экран
        /// </summary>
        public void Print(string message)
        {
            Console.Write(message);
            foreach (var item in array)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
    }
}
