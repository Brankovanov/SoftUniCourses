using System;
using System.Text.RegularExpressions;

namespace Lab_02_VowelCount
{
    public class VowelCount
    {
        public static void Main(string[] args)
        {
            ReceiveText();
        }

        //Receives the text from the console.
        public static void ReceiveText()
        {
            var text = Console.ReadLine();
            CountVowel(text);
        }

        //Count the vowels in the text. 
        public static void CountVowel(string text)
        {
            var pattern = new Regex("[aeiouyAEIOUY]");
            var vowels = pattern.Matches(text);
            Print(vowels);
        }

        //Prints the number of vowels fount in the text on the console.
        public static void Print(MatchCollection vowels)
        {
            Console.WriteLine("Vowels: " + vowels.Count);
        }
    }
}