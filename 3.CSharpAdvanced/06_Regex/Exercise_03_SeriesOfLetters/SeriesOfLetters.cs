using System;
using System.Text.RegularExpressions;

namespace Exercise_03_SeriesOfLetters
{
    public class SeriesOfLetters
    {

        public static void Main(string[] args)
        {
            ReceiveText();
        }

        //Receives text from the console.
        public static void ReceiveText()
        {
            var text = Console.ReadLine();
            FindAndReplaceReapeatingPatterns(text);
        }

        //Finds and replaces the repeating patterns in the text.
        public static void FindAndReplaceReapeatingPatterns(string text)
        {
            var repeatingPattern = new Regex(@"(.)\1+");
            var repetitions = repeatingPattern.Matches(text);

            foreach (Match repetition in repetitions)
            {
                text = text.Replace(repetition.ToString(), repetition.ToString()[0].ToString());
            }

            Print(text);
        }

        //Prints the final text.
        public static void Print(string text)
        {
            Console.WriteLine(text);
        }
    }
}