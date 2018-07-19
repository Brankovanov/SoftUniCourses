using System;
using System.Text.RegularExpressions;

namespace Exercise_06_SentenceExtractor
{
    public class SentenceExtractor
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        //Receives text and keyword from the console.
        public static void ReceiveInput()
        {
            var keyWords = Console.ReadLine();
            var text = Console.ReadLine();
            FindSentences(keyWords, text);
        }

        //Finds sentences that hold the keyword.
        public static void FindSentences(string keyWords, string text)
        {
            var keyWordsPattern = new Regex("\\b(is)\\b");
            var sentences = text.Split(new char[] { '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var sentence in sentences)
            {
                var sent = keyWordsPattern.IsMatch(sentence);

                if (sent == true)
                {
                    Console.WriteLine(sentence);
                }
            }
        }
    }
}