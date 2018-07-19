using System;
using System.Text.RegularExpressions;

namespace Lab_03_NonDigitCount
{
    public class NonDigitCount
    {
        public static void Main(string[] args)
        {
            ReceiveText();
        }

        //Receuves the text from the console.
        public static void ReceiveText()
        {
            var text = Console.ReadLine();
            CountNonDigits(text);
        }

        //Count non digit characters.
        public static void CountNonDigits(string text)
        {
            var pattern = new Regex(@"\D");
            var nonDigitCharacters = pattern.Matches(text);
            PrintCount(nonDigitCharacters);
        }

        //Prints the count of all non digit characters.
        public static void PrintCount(MatchCollection nonDigitCollection)
        {
            Console.WriteLine("Non-digits: " + nonDigitCollection.Count);
        }
    }
}