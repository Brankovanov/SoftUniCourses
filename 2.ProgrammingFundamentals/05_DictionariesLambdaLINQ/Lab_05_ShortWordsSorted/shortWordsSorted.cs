using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_05_ShortWordsSorted
{
    public class shortWordsSorted
    {
        public static void Main(string[] args)
        {
            Input();
        }

        static void Input()
        {
            var input = Console.ReadLine();
            CreateList(input);
        }

        static void CreateList(string input)
        {
            List<string> listOfWords = new List<string>();

            listOfWords = input.Split(' ', ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']').ToList();
            SortWords(listOfWords);
        }

        static void SortWords(List<string> listOfWords)
        {
            List<string> shortWordsList = new List<string>();

            foreach (var word in listOfWords)
            {
                if (word.Length < 5 && word != "")
                {
                    shortWordsList.Add(word.ToLowerInvariant());
                }
            }

            shortWordsList.Sort();
            Print(shortWordsList);
        }

        static void Print(List<string> shortWordsList)
        {
            var answer = string.Empty;        

            foreach (var shortWord in shortWordsList.Distinct())
            {           
                    answer += shortWord + ", ";              
            }

            Console.Write(answer.Remove(answer.Length - 2, 2));
        }
    }
}
