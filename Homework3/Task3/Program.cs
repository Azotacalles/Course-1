using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            //*Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел. Предусмотреть методы сложения, вычитания, умножения и деления дробей. 
            //Написать программу, демонстрирующую все разработанные элементы класса. +
            //*Добавить свойства типа int для доступа к числителю и знаменателю; +
            //*Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа; +
            //**Добавить проверку, чтобы знаменатель не равнялся 0.Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0"); +
            //***Добавить упрощение дробей. +
            Fraction fraction1 = new Fraction(1, 2);
            Fraction fraction2 = new Fraction(1, 3);
            Fraction res = new Fraction(1, 1);
            res = res.Sum(fraction1, fraction2);
            Console.WriteLine($"Sum: {fraction1.ToString()} + {fraction2.ToString()} = {res.ToString()}");

            fraction1 = new Fraction(1, 2);
            fraction2 = new Fraction(1, 4);
            res = res.Sub(fraction1, fraction2);
            Console.WriteLine($"Sub: {fraction1.ToString()} - {fraction2.ToString()} = {res.ToString()}");

            fraction1 = new Fraction(2, 3);
            fraction2 = new Fraction(3, 5);
            res = res.Multi(fraction1, fraction2);
            Console.WriteLine($"Multi: {fraction1.ToString()} * {fraction2.ToString()} = {res.ToString()}");

            fraction1 = new Fraction(1, 2);
            fraction2 = new Fraction(1, 3);
            res = res.Div(fraction1, fraction2);
            Console.WriteLine($"Div: {fraction1.ToString()} / {fraction2.ToString()} = {res.ToString()}");

            fraction1.Numerator = 2;
            fraction1.Denominator = 5;
            Console.WriteLine($"{fraction1.ToString()} -> {fraction1.DecFraction}");

            try
            {
                Fraction fraction3 = new Fraction(5, 0);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Fraction fraction4 = new Fraction(3, 8);
            res = res.Reduction(fraction4);
            Console.WriteLine($"{fraction4.ToString()} = {res.ToString()}");
            Console.ReadLine();
        }
    }

    class Fraction
    {
        /// <summary>
        /// Числитель
        /// </summary>
        private int numerator;
        /// <summary>
        /// Знаменатель
        /// </summary>
        private int denominator; 

        public int Numerator 
        {
            get { return numerator; }
            set { numerator = value; }
        }
        public int Denominator 
        {
            get { return denominator; }
            set { denominator = value; }
        }

        public double DecFraction
        {
            get { return (double)numerator / (double)denominator; }
        }

        private Fraction()
        {
            numerator = 0;
            denominator = 0;
        }

        public Fraction(int numerator, int denominator)
        {
            this.numerator = numerator;
            if (denominator != 0) { this.denominator = denominator; }
            else { throw new ArgumentException("Знаменатель не может быть равен 0"); }
        }

        public Fraction Sum(Fraction frac1, Fraction frac2)
        {
            Fraction res;
            int numerator1, numerator2, varLCM;
            CountNumeratorAndDenominator(frac1, frac2, out numerator1, out numerator2, out varLCM);
            res = new Fraction(numerator1 + numerator2, varLCM);
            return res;
        }

        public Fraction Sub(Fraction frac1, Fraction frac2)
        {
            Fraction res;
            int numerator1, numerator2, varLCM;
            CountNumeratorAndDenominator(frac1, frac2, out numerator1, out numerator2, out varLCM);
            res = new Fraction(numerator1 - numerator2, varLCM);
            return res;
        }

        public Fraction Multi(Fraction frac1, Fraction frac2)
        {
            Fraction res = new Fraction(); ;
            res.numerator = frac1.numerator * frac2.numerator;
            res.denominator = frac1.denominator * frac2.denominator;
            return res;
        }

        public Fraction Div(Fraction frac1, Fraction frac2)
        {
            Fraction res = new Fraction(); ;
            res.numerator = frac1.numerator * frac2.denominator;
            res.denominator = frac1.denominator * frac2.numerator;
            return res;
        }

        public Fraction Reduction(Fraction frac)
        {
            Fraction res = new Fraction();
            int varGCD = GCD(frac.numerator, frac.denominator);
            res.numerator = frac.numerator / varGCD;
            res.denominator = frac.denominator / varGCD;
            return res;
        }

        private void CountNumeratorAndDenominator(Fraction frac1, Fraction frac2, out int numerator1, out int numerator2, out int varLCM)
        {
            varLCM = LCM(frac1.denominator, frac2.denominator);
            numerator1 = varLCM / frac1.denominator * frac1.numerator;
            numerator2 = varLCM / frac2.denominator * frac2.numerator;
        }

        /// <summary>
        /// Поиск НОК по Евклиду
        /// </summary>
        /// <param name="num1">Число 1</param>
        /// <param name="num2">Число 2</param>
        /// <returns>Наименьшее общее кратное</returns>
        private int LCM(int num1, int num2)
        {
            return num1 * num2 / GCD(num1, num2);
        }

        /// <summary>
        /// Поиск НОД по Евклиду
        /// </summary>
        /// <param name="num1">Число 1</param>
        /// <param name="num2">Число 2</param>
        /// <returns>Наибольший общий делитель</returns>
        private int GCD(int num1, int num2)
        {
            if(num1 < num2)
            {
                int t = num1;
                num1 = num2;
                num2 = t;
            }
            if (num2 != 0)
            {
                return GCD(num2, num1 % num2);
            }
            else return num1;
        }

        public override string ToString()
        {
            return $"{numerator}/{denominator}"; 
        }
    }
}
