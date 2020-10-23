using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Родыгин
            //Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
            //а) Вывести только те слова сообщения,  которые содержат не более n букв. +
            //б) Удалить из сообщения все слова, которые заканчиваются на заданный символ. +
            //в) Найти самое длинное слово сообщения. +
            //г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения. +
            //д) ***Создать метод, который производит частотный анализ текста. +
            //В качестве параметра в него передается массив слов и текст, в качестве результата метод возвращает 
            //сколько раз каждое из слов массива входит в этот текст. Здесь требуется использовать класс Dictionary.
            Console.WriteLine("Введите текст:");
            string[] words = Console.ReadLine().Split(' ');
            Console.WriteLine("Все слова, которые содержат не более n букв:");
            Message.PrintWords(words, 4);
            Console.WriteLine("Сообщение без слов, заканчивающихся на заданный символ:");
            Message.DeleteWords(words, 'a');
            Console.WriteLine("Самое длинное слово сообщения:");
            Console.WriteLine(Message.MaxLength(words));
            Console.WriteLine("StringBuilder из самых длинных слов сообщения:");
            StringBuilder stringBuilder = Message.StringBuilderText(words);
            Console.WriteLine(stringBuilder);
            Console.WriteLine("Частотный анализ текста:");
            var frequenceWords = Message.FrequencyWords(words);
            foreach (var item in frequenceWords)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
            Console.ReadLine();
        }
    }

    static class Message
    {
        /// <summary>
        /// Вывод слов, которые содержат не более n букв
        /// </summary>
        /// <param name="words">Массив слов</param>
        /// <param name="size">Размер слов</param>
        static public void PrintWords(string[] words, byte size)
        {
            foreach (var item in words)
            {
                if (item.Length <= size) Console.Write($"{item} ");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Вывод слов, заканчивающихся на заданный символ
        /// </summary>
        /// <param name="words">Массив слов</param>
        /// <param name="symbol">Символ</param>
        static public void DeleteWords(string[] words, char symbol)
        {
            string text = "";
            foreach (var item in words)
            {
                if (item[item.Length - 1] != symbol) text += item + " ";
            }
            Console.WriteLine(text);
        }

        /// <summary>
        /// Определить самое длинное слово
        /// </summary>
        /// <param name="words">Массив слов</param>
        /// <returns>Самое длинное слово</returns>
        static public string MaxLength(string[] words)
        {
            string maxWord = words[0];
            for (int i = 1; i < words.Length; i++)
            {
                if (maxWord.Length < words[i].Length) maxWord = words[i];
            }
            return maxWord;
        }

        /// <summary>
        /// Формирование строки из самых длинных слов
        /// </summary>
        /// <param name="words">Массив слов</param>
        /// <returns>Строка из самых длинных слов</returns>
        static public StringBuilder StringBuilderText(string[] words)
        {
            StringBuilder stringBuilder = new StringBuilder();
            byte length = (byte)MaxLength(words).Length;
            foreach (var item in words)
            {
                if (item.Length == length) stringBuilder.Append(item + " ");
            }
            return stringBuilder;
        }

        /// <summary>
        /// Частотный анализ слов
        /// </summary>
        /// <param name="words">Массив слов</param>
        /// <returns>Словарь с частотным анализом</returns>
        static public Dictionary<string, int> FrequencyWords(string[] words)
        {
            Dictionary<string, int> frequency = new Dictionary<string, int>();
            foreach (var item in words)
            {
                if (frequency.ContainsKey(item)) frequency[item]++;
                else frequency.Add(item, 1);
            }
            return frequency;
        }
    }
}
