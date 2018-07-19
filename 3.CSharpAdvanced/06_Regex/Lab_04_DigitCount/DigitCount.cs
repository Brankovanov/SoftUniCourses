using System;
using System.Text.RegularExpressions;

namespace Lab_04_DigitCount
{
    public class DigitCount
    {
        public static void Main(string[] args)
        {
            ReceiveText();
        }

        //Receives the text from the console.
        public static void ReceiveText()
        {
            var text = Console.ReadLine();
            CountDigits(text);
        }

        //Count non digit characters.
        public static void CountDigits(string text)
        {
            var pattern = new Regex(@"\d+");
            var digitCharacters = pattern.Matches(text);
            PrintCount(digitCharacters);
        }

        //Prints the count of all non digit characters.
        public static void PrintCount(MatchCollection digitCollection)
        {
            foreach (var digit in digitCollection)
            {
                Console.WriteLine(digit);
            }
        }
    }
}