using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Task5
{
    [Serializable]
    public class Student
    {
        public string firstName;
        public string lastName;
        public string university;
        public string faculty;
        public string department;
        public int age;
        public int course;
        public int group;
        public string city;
        
        public Student() { }

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
    }

    class StudentCollection
    {
        public string path;
        public List<Student> list;

        public StudentCollection()
        {
            this.list = new List<Student>();
        }

        public void Add(string firstName, string lastName, string university, string faculty, string department, int age, int course, int group, string city)
        {
            list.Add(new Student(firstName, lastName, university, faculty, department, age, course, group, city));
        }

        public void Save(string fileName)
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Student>));
            Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            xmlFormat.Serialize(fStream, list);
            fStream.Close();
        }
    }

}
