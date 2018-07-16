using System;

namespace Exercise_02_StringLenght
{
    public class StringLenght
    {
        public static void Main(string[] args)
        {
            ReceiveText();
        }

        //Receives text from the console.
        public static void ReceiveText()
        {
            var text = Console.ReadLine();
            GetLenght(text);
        }

        //Get the text's lengh and process it according to it.
        public static void GetLenght(string text)
        {
            if (text.Length < 20)
            {
                text = text.PadRight(text.Length + (20 - text.Length), '*');
            }
            else if (text.Length > 20)
            {
                text = text.Substring(0, 20);
            }

            Print(text);
        }

        //Prints the text.
        public static void Print(string text)
        {
            Console.WriteLine(text);
        }
    }
}