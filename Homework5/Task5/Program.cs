using System;
using System.IO;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Написать игру «Верю. Не верю». В файле хранятся вопрос и ответ, правда это или нет. 
            //Например: «Шариковую ручку изобрели в древнем Египте», «Да». Компьютер загружает эти данные, 
            //случайным образом выбирает 5 вопросов и задаёт их игроку. Игрок отвечает Да или Нет на каждый 
            //вопрос и набирает баллы за каждый правильный ответ. Список вопросов ищите во вложении или воспользуйтесь интернетом.

            string[] questions = File.ReadAllLines("questions.txt");
            int[] questionsUse = new int[questions.Length];
            byte quest = 1;
            byte rightAnswer = 0;
            do
            {
                string[] splitQuestions = FindQuestion(questions, questionsUse);
                Console.WriteLine($"Вопрос {quest}: {splitQuestions[0]}");
                Console.Write("Ваш ответ (да/нет): ");
                CheckAnswer(splitQuestions, ref rightAnswer);
                quest++;
            } while (quest < 6);
            Console.WriteLine(PrintResult(rightAnswer));
            Console.ReadLine();
        }

        /// <summary>
        /// Проверка ответа
        /// </summary>
        /// <param name="splitQuestions">Массив с вопросом и ответом</param>
        /// <param name="rightAnswer">Кол-во правильных ответов</param>
        static void CheckAnswer(string[] splitQuestions, ref byte rightAnswer)
        {
            string answer = Console.ReadLine();
            if (answer.ToLower() == splitQuestions[1])
            {
                Console.WriteLine("Правильно");
                rightAnswer++;
            }
            else
            {
                Console.WriteLine("Не правильно");
            }
        }

        /// <summary>
        /// Поиск вопроса (без повторения)
        /// </summary>
        /// <param name="questions">Массив вопросов</param>
        /// <param name="questionsUse">Массив, определяющий какой вопрос уже был</param>
        /// <returns></returns>
        static string[] FindQuestion(string[] questions, int[] questionsUse)
        {
            Random random = new Random();
            int index = 0;
            do
            {
                index = random.Next(questions.Length);
            } while (questionsUse[index] != 0);
            string[] splitQuestions = questions[index].Split('|');
            questionsUse[index] = 1;
            return splitQuestions;
        }

        /// <summary>
        /// Вывод результата с учётом склонения
        /// </summary>
        /// <param name="answer">Кол-во ответов</param>
        /// <returns></returns>
        static string PrintResult(byte answer)
        {
            string s;
            s = $"Вы набрали {answer} ";
            switch (answer)
            {
                case 1:
                    s += "балл";
                    break;
                case 2:
                case 3:
                case 4:
                    s += "балла";
                    break;
                case 0:
                case 5:
                    s += "баллов";
                    break;
            }
            return s;
        }
    }
}
