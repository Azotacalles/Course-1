using System;
using System.Collections.Generic;
using MyLibrary;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            //а) Дописать класс для работы с одномерным массивом. Реализовать конструктор, создающий массив определенного размера 
            //и заполняющий массив числами от начального значения с заданным шагом. +
            //Создать свойство Sum, которое возвращает сумму элементов массива, +
            //метод Inverse, возвращающий новый массив с измененными знаками у всех элементов массива (старый массив, остается без изменений), +
            //метод Multi, умножающий каждый элемент массива на определённое число, +
            //свойство MaxCount, возвращающее количество максимальных элементов. +
            //б)**Создать библиотеку содержащую класс для работы с массивом.Продемонстрировать работу библиотеки +
            //в) ***Подсчитать частоту вхождения каждого элемента в массив(коллекция Dictionary< int,int>) +

            MyArray myArray = new MyArray(10, 10, 2);
            myArray.Print("Массив: ");
            Console.WriteLine($"Сумма элементов: {myArray.Sum}");
            int[] inverseArray = myArray.Inverse();
            Console.Write("Инверсия: ");
            for (int i = 0; i < inverseArray.Length; i++)
            {
                Console.Write($"{inverseArray[i]} ");
            }
            Console.WriteLine();
            myArray.Print("Оригинальный массив: ");
            myArray.Milti(2);
            myArray.Print("Умножаем на число: ");
            Console.WriteLine($"Количество максимальных элементов: {myArray.MaxCount}");

            LibraryArray libraryArray = new LibraryArray(7,5,3);
            libraryArray.Print("Массив из библиотеки: ");

            myArray.FrequencyOfOccurrence();
            Console.ReadKey();
        }
    }

    class MyArray
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
                if(max < array[i]) max = array[i];
            }
            return max;
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="size">Размер массива</param>
        /// <param name="firstValue">Начальное значение</param>
        /// <param name="step">Шаг, с которым будут изменяться значения</param>
        public MyArray(int size, int firstValue, int step)
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

        /// <summary>
        /// Подсчёт и вывод частоты вхождения каждого элемента в массиве
        /// </summary>
        public void FrequencyOfOccurrence()
        {
            Dictionary<int, int> frequency = new Dictionary<int, int>();
            for (int i = 0; i < array.Length; i++)
            {
                if (frequency.ContainsKey(array[i])) frequency[array[i]] = frequency[array[i]] + 1;
                else frequency.Add(array[i], 1);
            }
            Console.WriteLine("Частота вхождения каждого элемента в массив");
            foreach (var item in frequency)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}
