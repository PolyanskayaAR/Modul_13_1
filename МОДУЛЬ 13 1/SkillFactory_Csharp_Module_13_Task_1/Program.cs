using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;


namespace SkillFactory_Csharp_Module_13_Task_1
{
    internal class Program
    {
        public static List <string> usualList = new List <string> ();
        public static LinkedList <string> linkedList = new LinkedList <string> ();

        static void Main(string[] args)
        {
            
            // читаем весь файл с рабочего стола в строку текста
            string text = File.ReadAllText("C:\\Users\\schek\\Desktop\\Text1.txt");

            // Сохраняем символы-разделители в массив
            char[] delimiters = new char[] { ' ', '\r', '\n', '.', ',', ';', ':', '!', '?', '"' };

            // разбиваем нашу строку текста, используя ранее перечисленные символы-разделители
            var words = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            Stopwatch stopWatch1 = new Stopwatch();

            stopWatch1.Start();                    // Измеряем время добавления в связанный список LinkedList

            for (int i = 0; i < words.Length; i++)
            {
                linkedList.AddLast(words[i]);
            }

            stopWatch1.Stop();

            Console.WriteLine($"Время добавления текста в связанный список: {stopWatch1.Elapsed.TotalMilliseconds} мс");


            Stopwatch stopWatch2 = new Stopwatch();
            stopWatch2.Start();                    // Измеряем время добавления в список List

            for (int i = 0; i < words.Length; i++)
            {
                usualList.Add (words[i]);
            }

            stopWatch2.Stop();

            Console.WriteLine($"Время добавления текста в список: {stopWatch2.Elapsed.TotalMilliseconds} мс");
            
            
        }
    }
}
