using System;
using System.Text.RegularExpressions;

namespace Lab_01_MatchCount
{
    public class MatchCount
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        //Receives input text and search pattern from the console.
        public static void ReceiveInput()
        {
            var pattern = Console.ReadLine();
            var text = Console.ReadLine();
            CountMatches(pattern, text);
        }

        //Finds and count how many times the pattern appears in the text.
        public static void CountMatches(string pattern, string text)
        {
            var regexPattern = new Regex(pattern);
            var numberOfMatches = regexPattern.Matches(text);
            PrintCount(numberOfMatches);
        }

        //Prints the count of appearences of the pattern.
        public static void PrintCount(MatchCollection numberOfMatches)
        {
            Console.WriteLine(numberOfMatches.Count);
        }
    }
}