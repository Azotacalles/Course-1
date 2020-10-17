using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Родыгин
            //а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
            //б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
            //в) Добавить диалог с использованием switch демонстрирующий работу класса.
            Complex number1 = new Complex(5, 2);
            Complex result = number1.Sub(new Complex(5, 2));
            Console.WriteLine($"Struct result: {result}");

            ComplexClass number2 = new ComplexClass(5, 2);
            ComplexClass resultClass = number2.Sub(new ComplexClass(5, 1));
            Console.WriteLine($"Class Sub result: {resultClass}");
            resultClass = number2.Multi(new ComplexClass(4, 0));
            Console.WriteLine($"Class Multi result: {resultClass}");

            ComplexClass num1 = new ComplexClass();
            InputNum(num1);
            ComplexClass num2 = new ComplexClass();
            InputNum(num2);
            SwitchChoice(num1, num2);
            Console.ReadKey();
        }

        private static void InputNum(ComplexClass num)
        {
            Console.WriteLine("Введите действительную и мнимую части числа: ");
            num.Re = Convert.ToDouble(Console.ReadLine());
            num.Im = Convert.ToDouble(Console.ReadLine());
        }

        static void SwitchChoice(ComplexClass num1, ComplexClass num2)
        {
            Console.WriteLine("Выберите действие:\n1 - Сложение\n2 - Вычитание\n3 - Умножение");
            string choice = Console.ReadLine();
            switch (choice.ToLower())
            {
                case "1":
                case "сумма":
                    Console.WriteLine($"({num1.ToString()}) + ({num2.ToString()}) = {num1.Plus(num2).ToString()}");
                    break;
                case "2":
                case "вычитание":
                    Console.WriteLine($"({num1.ToString()}) - ({num2.ToString()}) = {num1.Sub(num2).ToString()}");
                    break;
                case "3":
                case "умножение":
                    Console.WriteLine($"({num1.ToString()}) * ({num2.ToString()}) = {num1.Multi(num2).ToString()}");
                    break;
                default:
                    Console.WriteLine("Ошибка выбора");
                    break;
            }
        }
    }

    struct Complex
    {
        public double re; //действительная
        public double im; //мнимая

        public Complex(double re, double im)
        {
            this.re = re;
            this.im = im;
        }

        public Complex Sub(Complex x)   //Задание А
        {
            Complex y;
            y.re = re - x.re;
            y.im = im - x.im;
            return y;
        }

        public Complex Plus(Complex x)
        {
            Complex y;
            y.re = re + x.re;
            y.im = im + x.im;
            return y;
        }

        public Complex Multi(Complex x)
        {
            Complex y;
            y.re = re * x.re - im * x.im;
            y.im = re * x.im + im * x.re;
            return y;
        }

        public override string ToString()
        {
            if (re == 0)
            {
                if (im == 0) return "0";
                else return im + "i";
            }
            if (im < 0) return re + " - " + (-im) + "i";
            else if (im == 0) return re.ToString();
            else return re + " + " + im + "i";
        }
    }

    class ComplexClass
    {
        private double re;
        private double im;
        
        public ComplexClass()
        {
            re = 0;
            im = 0;
        }

        public ComplexClass(double re, double im)
        {
            this.re = re;
            this.im = im;
        }
        
        public ComplexClass Sub(ComplexClass x) //Задание Б
        {
            ComplexClass y = new ComplexClass();
            y.re = re - x.re;
            y.im = im - x.im;
            return y;
        }

        public ComplexClass Multi(ComplexClass x)  //Задание Б
        {
            ComplexClass y = new ComplexClass();
            y.re = re * x.re - im * x.im;
            y.im = re * x.im + im * x.re;
            return y;
        }

        public ComplexClass Plus(ComplexClass x)
        {
            ComplexClass y = new ComplexClass();
            y.re = re + x.re;
            y.im = im + x.im;
            return y;
        }
        public double Im
        {
            get { return im; }
            set { im = value; }
        }

        public double Re
        {
            get { return re; }
            set { re = value; }
        }
        public override string ToString()
        {
            if (re == 0)
            {
                if (im == 0) return "0";
                else return im + "i";
            }
            if (im < 0) return re + " - " + (-im) + "i";
            else if (im == 0) return re.ToString();
            else return re + " + " + im + "i";
        }
    }


}
