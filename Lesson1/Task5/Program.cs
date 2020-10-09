using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            //а) Написать программу, которая выводит на экран 
            //   ваше имя, фамилию и город проживания.
            //б) *Сделать задание, только вывод организовать в центре экрана.
            //в) **Сделать задание б с использованием собственных 
            //   методов(например, Print(string ms, int x, int y).
            string text = "Павел Родыгин, Москва";
            Console.WriteLine(text); //верхний левый

            int centerY = Console.WindowHeight / 2 - 1;
            int centerX = (Console.WindowWidth / 2) - (text.Length / 2);
            Console.SetCursorPosition(centerX, centerY);
            Console.WriteLine(text);

            Print(text, Console.WindowWidth - text.Length, 0); //верхний правый
            Print(text, 0, Console.WindowHeight - 1); //нижний левый
            Print(text, Console.WindowWidth - text.Length, Console.WindowHeight - 1); //нижний правый
            Console.ReadKey();
        }

        static void Print(string text, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(text);
        }
    }
}
