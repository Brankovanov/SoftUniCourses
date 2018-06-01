using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Lab_03_WordCount
{
    public class wordCount
    {
        public static void Main(string[] args)
        {
            CreateListOfWordsToSeek();
        }

        //Взима търсените думи от файл и прави масив с тях.
        static void CreateListOfWordsToSeek()
        {
            string[] wordsToSeek = File.ReadAllText("./words.txt").ToLowerInvariant().Split(' ');
            CreateListOfTextToSort(wordsToSeek);
        }

        //Взима текстовете, в коите ще се търсят думите и създава масив от тях.
        static void CreateListOfTextToSort(string[] wordsToSeek)
        {
            string[] textToSort = File.ReadAllLines("./inputText.txt").Select(x => x.ToLowerInvariant()).ToArray();
            CountRepeatingWords(wordsToSeek, textToSort);
        }

        //Минава през дадените текстове и търси думите. Записва ги в речник.
        static void CountRepeatingWords(string[] wordsToSeek, string[] textToSort)
        {
            var counter = 0;
            Dictionary<string, int> countedWords = new Dictionary<string, int>();

            foreach (var word in wordsToSeek)
            {
                foreach (var text in textToSort)
                {
                    var temp = text.Split('-', ',', '.', ' ').ToList();

                    while (temp.Contains(word))
                    {
                        counter++;
                        temp.Remove(word);
                    }                   
                }
                countedWords.Add(word, counter);
                counter = 0;
            }

            CreateAnswer(countedWords);
        }

        //Прехвърля данните от речника в текстов файл.
        static void CreateAnswer(Dictionary<string, int> countedWords)
        {
            File.Delete("./answer");           

            foreach (var word in countedWords.OrderByDescending(x => x.Value))
            {
                File.AppendAllText("./answer", word.Key + " - " + word.Value.ToString() + "\r\n");
            }

            Print();
        }

        //Отпечатва данните от текстовия файл.
        static void Print()
        {
            Console.WriteLine(File.ReadAllText("./answer"));
        }
    }
}
