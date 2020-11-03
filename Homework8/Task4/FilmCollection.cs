using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Task4
{
    // Класс для вопроса    
    [Serializable]
    public class Film
    {
        public string name;   // Название
        public string genre;  // Жанр
        public int year;      // Год
        public Film()
        {
        }
        public Film(string name, string genre, int year)
        {
            this.name = name;
            this.genre = genre;
            this.year = year;
        }
    }
    class FilmCollection
    {
        string fileName;
        List<Film> list;
        public string FileName
        {
            set { fileName = value; }
        }

        public int Count
        {
            get { return list.Count; }
        }

        public FilmCollection(string fileName)
        {
            this.fileName = fileName;
            list = new List<Film>();
        }
        public void Add(string name, string genre, int year)
        {
            list.Add(new Film(name, genre, year));
        }
        public void Remove(int index)
        {

            if (list != null && index < list.Count && index >= 0) list.RemoveAt(index);
        }
        
        public Film this[int index]
        {
            get { return list[index]; }
        }
        public void Save()
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Film>));
            Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            xmlFormat.Serialize(fStream, list);
            fStream.Close();
        }
        public void Load()
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Film>));
            Stream fStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            list = (List<Film>)xmlFormat.Deserialize(fStream);
            fStream.Close();
        }
    }
}
