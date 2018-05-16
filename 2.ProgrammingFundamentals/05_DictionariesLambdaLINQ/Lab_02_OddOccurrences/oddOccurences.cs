using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_02_OddOccurrences
{
    public class oddOccurences
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        static void ReceiveInput()
        {
            var input = Console.ReadLine();

            CreateList(input);
        }

        static void CreateList(string input)
        {
            List<string> listOfString = new List<string>();

            listOfString = input.ToLowerInvariant().Split(' ').ToList();

            SortList(listOfString);
        }

        static void SortList(List<string> listOfString)
        {
            Dictionary<string, int> finalDictionary = new Dictionary<string, int>();

            for (var index = 0; index <= listOfString.Count - 1; index++)
            {
                var checker = listOfString[index];
                var counter = 0;

                foreach (var word in listOfString)
                {
                    if (checker.Equals(word))
                    {
                        counter++;
                    }
                }

                if (counter % 2 != 0)
                {
                    CreateDictionary(checker, counter, finalDictionary);
                }

                listOfString.RemoveAll(x => x.Equals(checker));
                checker = string.Empty;
                counter = 0;
                index -= 1;
            }

            Print(finalDictionary);
        }

        static void CreateDictionary(string checker, int counter, Dictionary<string, int> finalDictionary)
        {
            finalDictionary.Add(checker, counter);
        }

        static void Print(Dictionary<string, int> finalDictionary)
        {
            var answer = string.Empty;

            foreach (var word in finalDictionary)
            {
                answer += word.Key.ToString() + ", ";
            }

            Console.Write(answer.Remove(answer.Length - 2, 2));
        }
    }
}

