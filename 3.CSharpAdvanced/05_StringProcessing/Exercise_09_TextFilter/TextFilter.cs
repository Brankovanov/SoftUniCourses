using System;

namespace Exercise_09_TextFilter
{
    public class TextFilter
    {
        public static void Main(string[] args)
        {
            ReceiveText();
        }

        //Receives text and forbidden words from the console.
        public static void ReceiveText()
        {
            var forbiddenWords = Console.ReadLine().Split(',');
            var text = Console.ReadLine();
            RedactText(text, forbiddenWords);
        }

        //Censors the forbidden words from the text.
        public static void RedactText(string text, string[] forbiddenWords)
        {
            foreach (var word in forbiddenWords)
            {
                text = text.Replace(word.Trim(), new string('*', word.Trim().Length));
            }

            Print(text);
        }

        //Prints the censored text.
        public static void Print(string text)
        {
            Console.WriteLine(text);
        }
    }
}