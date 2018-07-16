using System;

namespace Lab_05_ConcatenateString
{
    public class ConcatenateString
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        //Receives the input from the console.
        public static void ReceiveInput()
        {
            var numberOfElements = int.Parse(Console.ReadLine());
            var text = string.Empty;

            for (var index = 1; index <= numberOfElements; index++)
            {
                var word = Console.ReadLine();
                text += word + " ";
            }

            PrintText(text);
        }

        //Prints the text.
        public static void PrintText(string text)
        {
            Console.WriteLine(text);
        }
    }
}