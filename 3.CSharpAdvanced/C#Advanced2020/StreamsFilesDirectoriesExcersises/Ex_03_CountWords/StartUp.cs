using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Ex_03_CountWords
{
    class StartUp
    {
        static void Main(string[] args)
        {
            ReadFile();
        }

        private static void ReadFile()
        {
            var words = new List<string>();

            words.AddRange(File.ReadAllLines("../../../words.txt"));

            CountWordsInText(words);
        }

        private static void CountWordsInText(List<string> words)
        {
            var text = File.ReadAllText("../../../text.txt")
                .Split(new char[] { '-', ',', '.', '!', '?', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var dictionary = new Dictionary<string, int>();

            foreach(var word in text)
            {
                if(words.Contains(word.ToLower()) && dictionary.ContainsKey(word.ToLower()))
                {
                    dictionary[word.ToLower()]++;
                }
                else if (words.Contains(word.ToLower()) && !dictionary.ContainsKey(word.ToLower()))
                {
                    dictionary.Add(word.ToLower(), 1);
                }
            }
         
            PrintFile(dictionary);
        }

        private static void PrintFile(Dictionary<string, int> dictionary)
        {
            foreach(var word in dictionary)
            {
                File.AppendAllText("../../../actualResults.txt", $"{word.Key} - {word.Value}{Environment.NewLine}");
            }

            foreach (var word in dictionary.OrderByDescending(w=>w.Value))
            {
                File.AppendAllText("../../../expectedResults.txt", $"{word.Key} - {word.Value}{Environment.NewLine}");
            }
        }
    }
}
