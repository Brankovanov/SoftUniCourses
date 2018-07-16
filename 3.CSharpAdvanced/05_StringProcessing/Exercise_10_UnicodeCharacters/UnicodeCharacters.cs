using System;

namespace Exercise_10_UnicodeCharacters
{
    public class UnicodeCharacters
    {
        public static void Main(string[] args)
        {
            ReceiveString();
        }

        //Receives string from the console.
        public static void ReceiveString()
        {
            var text = Console.ReadLine();
            Convert(text);
        }

        //Converts the text to unicode character literals.
        public static void Convert(string text)
        {
            foreach (var ch in text)
            {
                var output = "\\u" + ((int)ch).ToString("x4");
                Print(output);
            }
        }

        //Prints the unicode character literal.
        public static void Print(string output)
        {
            Console.Write(output);
        }
    }
}