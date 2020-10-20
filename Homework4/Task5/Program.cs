using System;
using MyLibrary2;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Родыгин
            //*а) Реализовать библиотеку с классом для работы с двумерным массивом. +
            //Реализовать конструктор, заполняющий массив случайными числами. +
            //Создать методы, которые возвращают сумму всех элементов массива, +
            //сумму всех элементов массива больше заданного, +
            //свойство, возвращающее минимальный элемент массива, +
            //свойство, возвращающее максимальный элемент массива, +
            //метод, возвращающий номер максимального элемента массива (через параметры, используя модификатор ref или out). +
            //**б) Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл. +
            //**в) Обработать возможные исключительные ситуации при работе с файлами +

            Arra2Library array2Library = new Arra2Library(4, 4, 10, 20);
            array2Library.Print();
            Console.WriteLine($"Min Value: {array2Library.MinValue}");
            Console.WriteLine($"Max Value: {array2Library.MaxValue}");
            Console.WriteLine($"Sum: {array2Library.Sum()}");
            Console.WriteLine($"Sum (>15): {array2Library.Sum(15)}");
            int maxRow = 0, maxCol = 0;
            array2Library.IndexMax(ref maxRow, ref maxCol);
            Console.WriteLine($"MaxRow: {maxRow} MinCol: {maxCol}");

            array2Library.ArrayToFile("Array2.txt");

            Arra2Library arrayFile = new Arra2Library("Array2.txt");
            arrayFile.Print();
            Console.ReadLine();
        }
    }
}
