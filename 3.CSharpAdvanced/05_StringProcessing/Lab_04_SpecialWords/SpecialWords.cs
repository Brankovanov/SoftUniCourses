using System;
using System.Collections.Generic;

namespace Lab_04_SpecialWords
{
    public class SpecialWords
    {
        public static void Main(string[] args)
        {
            ReceiveText();
        }

        //Receives text from the console.
        public static void ReceiveText()
        {
            var specialWords = Console.ReadLine().Split(' ');
            var text = Console.ReadLine();
            CountSpecialWords(specialWords, text);
        }

        //Counts the special words.
        public static void CountSpecialWords(string[] specialWords, string text)
        {
            var temp = text.Split(' ', '(', ')', '[', ']', '<', '>', ',', '-', '!', '?');
            var wordFrequency = new Dictionary<string, int>();

            foreach (var word in specialWords)
            {
                wordFrequency.Add(word, 0);

                foreach (var part in temp)
                {
                    if (word.Equals(part))
                    {
                        wordFrequency[word]++;
                    }
                }
            }

            PrintCount(wordFrequency);
        }

        //Prints the special words and their count on the console.
        public static void PrintCount(Dictionary<string, int> wordFrequancy)
        {
            foreach (var word in wordFrequancy)
            {
                Console.WriteLine(word.Key + " - " + word.Value);
            }
        }
    }
}