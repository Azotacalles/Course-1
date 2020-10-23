using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создать программу, которая будет проверять корректность ввода логина. 
            //Корректным логином будет строка от 2 до 10 символов, содержащая только буквы 
            //латинского алфавита или цифры, при этом цифра не может быть первой:
            //а) без использования регулярных выражений;
            //б) **с использованием регулярных выражений.

            Console.Write("Введите логин: ");
            string login = Console.ReadLine();
            if (CheckLogin(login)) Console.WriteLine("Логин подходит");
            else Console.WriteLine("Логин не подходит");

            Regex regex = new Regex(@"^[a-zA-Z][a-zA-Z0-9]{1,9}");
            Console.Write("Введите логин: ");
            login = Console.ReadLine();
            if (regex.IsMatch(login) && regex.Replace(login, "").Length == 0) Console.WriteLine("Логин подходит");
            else Console.WriteLine("Логин не подходит");
            Console.ReadLine();
        }

        static bool CheckLogin(string login)
        {
            bool check = true;
            if(login.Length >= 2 && login.Length <= 10)
            {
                if((login[0] >= 'a' && login[0] <= 'z') || (login[0] >= 'A' && login[0] <= 'Z'))
                {
                    for (int i = 1; i < login.Length;)
                    {
                        if ((login[i] >= '0' && login[i] <= '9') || (login[i] >= 'a' && login[i] <= 'z') || (login[i] >= 'A' && login[i] <= 'Z')) i++;
                        else return false;
                    }
                }
                else return false;
            }
            else return false;
            return check;
        }
    }
}
