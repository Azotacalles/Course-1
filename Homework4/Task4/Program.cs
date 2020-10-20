using System;
using System.IO;
using System.Runtime.Remoting.Messaging;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Родыгин
            //Решить задачу с логинами из урока 2, только логины и пароли считать из файла в массив. 
            //    Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль.
            //    На выходе истина, если прошел авторизацию, и ложь, если не прошел(Логин: root, Password: GeekBrains). 
            //    Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, 
            //    программа пропускает его дальше или не пропускает.С помощью цикла do while ограничить ввод пароля тремя попытками.
            //Создайте структуру Account, содержащую Login и Password.
            Account acc = new Account();
            string[] arrayLogAndPass = File.ReadAllLines("LoginAndPass.txt");
            short index = -2;
            byte attempt = 0;
            do
            {
                attempt++;
                index += 2;
                acc.login = arrayLogAndPass[index];
                acc.password = arrayLogAndPass[index + 1];
                acc.Print();
                if (Success(acc.login, acc.password))
                {
                    Console.WriteLine("Доступ разрешен");
                    break; 
                }
                else
                {
                    Console.WriteLine("Доступ запрещён. Нажмите Enter, чтобы продолжить...");
                    Console.ReadLine();
                }
            } while (attempt < 3);
            Console.ReadLine();
        }

        static bool Success(string login, string password)
        {
            if (login == "root" && password == "GeekBrains") return true;
            else return false;
        }
    }

    struct Account
    {
        public string login;
        public string password;

        public void Print()
        {
            Console.WriteLine($"Login: {login} Pasword: {password}");
        }
    }
}
