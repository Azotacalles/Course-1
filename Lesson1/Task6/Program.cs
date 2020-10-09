using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создать класс с методами, которые могут пригодиться в вашей учебе (Print, Pause).
            ShortCom.Print("Hello, world!");
            ShortCom.Print(15);
            ShortCom.Pause();
        }
    }

    class ShortCom
    {
        public static void Print(string text)
        {
            Console.WriteLine(text);
        }

        public static void Print(int number)
        {
            Console.WriteLine(number);
        }

        public static void Pause()
        {
            Console.ReadKey();
        }
    }
}
