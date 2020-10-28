using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;

namespace Task3
{
    class Program
    {
        static int MyDelegat(Student st1, Student st2)           
        {
            return String.Compare(st1.firstName, st2.firstName);
        }

        static int SortAge(Student st1, Student st2)       
        {
            return st1.Age.CompareTo(st2.Age); 
        }

        public delegate bool SearchDel(string[] studentInfo, int criterion, string find);

        static void Main(string[] args)
        {
            //Родыгин
            //Переделать программу «Пример использования коллекций» для решения следующих задач:
            //а) Подсчитать количество студентов учащихся на 5 и 6 курсах; 
            //б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся(частотный массив); 
            //в) отсортировать список по возрасту студента; 
            //г) *отсортировать список по курсу и возрасту студента; 
            //д) разработать единый метод подсчета количества студентов по различным параметрам
            //выбора с помощью делегата и методов предикатов.

            int magistr = 0;
            List<Student> list = new List<Student>(); // Создаем список студентов
            Dictionary<int, int> dictionaryStudents = new Dictionary<int, int>();
            dictionaryStudents.Add(18, 0);
            dictionaryStudents.Add(19, 0);
            dictionaryStudents.Add(20, 0);
            DateTime dt = DateTime.Now;
            StreamReader sr = new StreamReader("students.csv");
            while (!sr.EndOfStream)
            {
                try
                {
                    string[] s = sr.ReadLine().Split(';');
                    // Добавляем в список новый экземпляр класса Student
                    list.Add(new Student(s[0], s[1], s[2], s[3], s[4], int.Parse(s[5]), int.Parse(s[6]), int.Parse(s[7]), s[8]));
                    // Одновременно подсчитываем количество бакалавров и магистров
                    if (int.Parse(s[6]) == 5 || int.Parse(s[6]) == 6) magistr++;
                    if (dictionaryStudents.ContainsKey(int.Parse(s[5]))) dictionaryStudents[int.Parse(s[5])] += 1;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Ошибка!ESC - прекратить выполнение программы");
                    // Выход из Main
                    if (Console.ReadKey().Key == ConsoleKey.Escape) return;
                }
            }
            sr.Close();
            list.Sort(new Comparison<Student>(MyDelegat));
            foreach (var item in list) Console.WriteLine(item.firstName);
            Console.WriteLine("Всего студентов:" + list.Count);
            Console.WriteLine("Магистров:{0}", magistr);
            foreach (var item in dictionaryStudents) Console.WriteLine(item);
            foreach (var item in list) Console.WriteLine(item.firstName);
            list.Sort(new Comparison<Student>(SortAge));
            foreach (var item in list) Console.WriteLine($"{item.firstName} - {item.course} - {item.Age}");
            Student.SortCourseAndAge(list);
            foreach (var item in list) Console.WriteLine($"{item.firstName} - {item.course} - {item.Age}");
            Search();
            Console.WriteLine(DateTime.Now - dt);
            Console.ReadKey();

        }

        /// <summary>
        /// Поиск
        /// </summary>
        static void Search()
        {
            Console.WriteLine("Критерий поиска: 1 - имя, 2 - фамилия, 3 - университет, 4 - факультет, 5 - кафедра,\n 6 - возраст, 7 - курс, 8 - группа, 9 - город");
            int criterion = int.Parse(Console.ReadLine());
            Console.WriteLine("Что ищем?");
            string find = Console.ReadLine();
            int count = 0;
            SearchDel sd = isSearch;
            StreamReader sr = new StreamReader("students.csv");
            while (!sr.EndOfStream)
            {
                string[] s = sr.ReadLine().Split(';');
                if (sd(s, criterion, find)) count++;
            }
            Console.WriteLine($"Всего найдено: {count}");
        }

        /// <summary>
        /// Сравнение информации и поиска
        /// </summary>
        /// <param name="studentInfo">Массив информации о студенте</param>
        /// <param name="criterion">Критерий поиска</param>
        /// <param name="find">Что ищем</param>
        /// <returns>Результат поиска</returns>
        static bool isSearch(string[] studentInfo, int criterion, string find)
        {
            if (studentInfo[criterion - 1] == find) return true;
            else return false;
        }
    }

    class Student
    {
        public string lastName;
        public string firstName;
        public string university;
        public string faculty;
        public int course;
        public string department;
        public int group;
        public string city;
        private int age;
        // Создаем конструктор
        public Student(string firstName, string lastName, string university, string faculty, string department, int age, int course, int group, string city)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.university = university;
            this.faculty = faculty;
            this.department = department;
            this.course = course;
            this.age = age;
            this.group = group;
            this.city = city;
        }

        public int Age
        {
            get { return age; }
        }

        /// <summary>
        /// Сортировка по курсу и возрасту
        /// </summary>
        /// <param name="list"></param>
        static public void SortCourseAndAge(List<Student> list)
        {
            list.Sort(delegate (Student st1, Student st2) { return st1.course.CompareTo(st2.course); });
            List<Student> tempList = new List<Student>();
            list.Add(new Student("", "", "", "", "", 200, 200, 0, ""));
            for (int i = 0; i < list.Count - 1; i++)
            {
                if (list[i].course == list[i + 1].course) tempList.Add(list[i]);
                else
                {
                    tempList.Add(list[i]);
                    tempList.Sort(delegate (Student st1, Student st2) { return st1.age.CompareTo(st2.age); });
                    int p = 0;
                    for (int j = i - tempList.Count + 1; j <= i; j++)
                    {
                        list[j] = tempList[p];
                        p++;
                    }
                    tempList.Clear();
                }
            }
            list.RemoveAt(list.Count-1);
        }    
    }

}
