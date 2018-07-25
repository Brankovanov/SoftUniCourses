using System;
using System.Linq;

namespace Lab_03_CountUpperCaseWords
{
    public class CountUpperCase
    {
        public static void Main(string[] args)
        {
            ReceiveText();
        }

        //Receives text from the console.
        public static void ReceiveText()
        {
            var text = Console.ReadLine().Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries).ToArray();
            SortUpperCase(text);
        }

        //Finds the uppercase words.
        public static void SortUpperCase(string [] text)
        {
            foreach(var word in text.Where(w=>w.StartsWith(w[0].ToString().ToUpper())))
            {
                Console.WriteLine(word);
            }
        }
    }
}