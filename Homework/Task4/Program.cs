using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль.
            //На выходе истина, если прошел авторизацию, и ложь, если не прошел(Логин: root, Password: GeekBrains). 
            //Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
            //С помощью цикла do while ограничить ввод пароля тремя попытками.
            byte attempt = 3;
            bool success = false;
            do
            {
                attempt--;
                Console.WriteLine("Введите логин и пароль: ");
                string login = Console.ReadLine();
                string password = Console.ReadLine();
                if (success = Authorization(login, password)) { break; };
            } while (attempt > 0);
            if (success) { Console.WriteLine("Допуск открыт"); }
            else { Console.WriteLine("Доступ закрыт"); }
            Console.ReadLine();
        }

        static bool Authorization(string login, string password)
        {
            if (login == "root" && password == "GeekBrains") { return true; }
            else { return false; }
        }
    }
}
