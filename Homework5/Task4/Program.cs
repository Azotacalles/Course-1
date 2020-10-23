using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Родыгин
            /*На вход программе подаются сведения о сдаче экзаменов учениками 9 - х классов некоторой средней школы. 
             *В первой строке сообщается количество учеников N, которое не меньше 10, но не превосходит 100, каждая из следующих N строк имеет следующий формат:
            < Фамилия > < Имя > < оценки >,
            где < Фамилия > — строка, состоящая не более чем из 20 символов, < Имя > — строка, состоящая не более чем из 15 символов, 
            < оценки > — через пробел три целых числа, соответствующие оценкам по пятибалльной системе. < Фамилия > и<Имя>, а также<Имя> и<оценки>
            разделены одним пробелом. Пример входной строки:
            Иванов Петр 4 5 3
            Требуется написать как можно более эффективную программу, которая будет выводить на экран фамилии и имена трёх худших по среднему баллу учеников. 
            Если среди остальных есть ученики, набравшие тот же средний балл, что и один из трёх худших, следует вывести и их фамилии и имена. */


            StreamReader sr = new StreamReader("students.txt");
            int N = int.Parse(sr.ReadLine());
            Student[] students = new Student[N];
            for (int i = 0; i < N; i++)
            {
                string[] info = sr.ReadLine().Split(' ');
                students[i] = new Student();
                students[i].fullName = info[0] + " " + info[1];
                students[i].averageScore = (double.Parse(info[2]) + double.Parse(info[3]) + double.Parse(info[4])) / 3;
            }
            Array.Sort(students);
            BadStudents(students);
            Console.ReadLine();
        }

        /// <summary>
        /// Определение студентов, которые набрали один из трёх худших средних баллов
        /// </summary>
        /// <param name="students">Массив студентов</param>
        static void BadStudents(Student[] students)
        {
            byte change = 0;
            int index = 0;
            do
            {
                Console.WriteLine(students[index].fullName);
                if (index + 1 == students.Length) break;
                if (students[index].averageScore < students[index + 1].averageScore) change++;
                index++;
            } while (change < 3);
        }
    }

    /// <summary>
    /// Класс студента
    /// </summary>
    class Student : IComparable
    {
        public string fullName;
        public double averageScore;

        public int CompareTo(object obj)
        {
            return this.averageScore.CompareTo((obj as Student).averageScore);
        }
    }
}
