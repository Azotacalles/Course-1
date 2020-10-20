using System;
using System.IO;

namespace MyLibrary2
{
    public class Arra2Library
    {
        int[,] array;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="sizeRow">Количество строк</param>
        /// <param name="sizeCol">Количество столбцов</param>
        /// <param name="min">Минимальное значение</param>
        /// <param name="max">Максимальное значение</param>
        public Arra2Library(int sizeRow, int sizeCol, int min, int max)
        {
            Random random = new Random();
            array = new int[sizeRow, sizeCol];
            for (int i = 0; i < sizeRow; i++)
            {
                for (int j = 0; j < sizeCol; j++)
                {
                    array[i,j] = random.Next(min, max + 1);
                }  
            }
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="path">Путь к файлу</param>
        public Arra2Library(string path)
        {
            array = ArrayFromFile(path);
        }

        /// <summary>
        /// Считать данные из файла в массив
        /// </summary>
        /// <param name="path">Путь к файлу</param>
        /// <returns>Массив данных</returns>
        private int[,] ArrayFromFile(string path)
        {
            try
            {
                string[] arrayString = File.ReadAllLines(path);
                string[] temp;
                int[,] array = new int[arrayString.Length, arrayString[0].Trim().Split(' ').Length];
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    temp = arrayString[i].Trim().Split(' ');
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        try
                        {
                            array[i, j] = int.Parse(temp[j]);
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Недопустимое значение!");
                            return new int[1, 1];
                        }
                        
                    }
                }
                return array;
            }
            catch(FileNotFoundException)
            {
                Console.WriteLine("Файл не найден!");
                return new int[1,1];
            }
        }

        /// <summary>
        /// Запись массива в файл
        /// </summary>
        /// <param name="path">Путь к файлу</param>
        public void ArrayToFile(string path)
        {
            StreamWriter sw = new StreamWriter(path);
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sw.Write($"{array[i, j]} ");
                }
                sw.WriteLine();
            }
            sw.Close();
        }

        /// <summary>
        /// Поиск минимального значения
        /// </summary>
        public int MinValue
        {
            get
            {
                int min = array[0,0];
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        if (min > array[i,j]) min = array[i,j];
                    }  
                }
                return min;
            }
        }

        /// <summary>
        /// Поиск максимального значения
        /// </summary>
        public int MaxValue
        {
            get
            {
                int max = array[0,0];
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        if (max < array[i,j]) max = array[i,j];
                    } 
                }
                return max;
            }
        }

        /// <summary>
        /// Сумма всех элементов
        /// </summary>
        /// <returns>Сумма всех элементов</returns>
        public int Sum()
        {
            int sum = 0;
            foreach (var item in array)
            {
                sum += item;
            }
            return sum;
        }

        /// <summary>
        /// Сумма всех элементов больших заданного значения
        /// </summary>
        /// <param name="value">Значение</param>
        /// <returns>Сумма всех элементов больших заданного значения</returns>
        public int Sum(int value)
        {
            int sum = 0;
            foreach (var item in array)
            {
                if (item > value) sum += item;
            }
            return sum;
        }

        /// <summary>
        /// Определение индексов максимального значения
        /// </summary>
        /// <param name="indexRow">Индекс строки</param>
        /// <param name="indexCol">Индекс столбца</param>
        public void IndexMax(ref int indexRow, ref int indexCol)
        {
            int max = array[0,0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (max < array[i,j])
                    {
                        max = array[i,j];
                        indexRow = i;
                        indexCol = j;
                    }
                } 
            }
        }

        /// <summary>
        /// Вывод массива
        /// </summary>
        public void Print()
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i,j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
