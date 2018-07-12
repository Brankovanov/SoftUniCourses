using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Exercise_03_WordCount
{
    public class WordCount
    {
        public static void Main(string[] args)
        {
            ReadWords();
            Console.WriteLine("Counting complete.");
        }

        //Reads the words that we seek from the file words.txt.
        public static void ReadWords()
        {
            var wordReader = new StreamReader("../../words.txt");
            var wordDictionary = new Dictionary<string, int>();

            using (wordReader)
            {
                var word = wordReader.ReadLine();

                while (word != null)
                {
                    CountWords(word, wordDictionary);
                    word = wordReader.ReadLine();
                }
            }
        }

        //Counts the occurences of these words in the text in text.txt.
        public static void CountWords(string word, Dictionary<string, int> wordDictionary)
        {
            var lineReader = new StreamReader("../../text.txt");

            using (lineReader)
            {
                var line = lineReader.ReadLine();

                while (line != null)
                {
                    line = line.ToLower();

                    while (line.Contains(word))
                    {
                        line = line.Replace(word, " ");

                        if (!wordDictionary.ContainsKey(word))
                        {
                            wordDictionary.Add(word, 1);
                        }
                        else
                        {
                            wordDictionary[word]++;
                        }
                    }

                    line = lineReader.ReadLine();
                }
            }

            SaveResults(wordDictionary);
        }

        //Writes the wordcount on the file result.txt.
        public static void SaveResults(Dictionary<string, int> wordDictionary)
        {
            var resultWriter = new StreamWriter("result.txt");

            using (resultWriter)
            {
                foreach (var result in wordDictionary.OrderByDescending(x => x.Value))
                {
                    var output = $"{result.Key} - {result.Value}";
                    resultWriter.WriteLine(output);
                }
            }
        }
    }
}