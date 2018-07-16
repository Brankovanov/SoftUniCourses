using System;

namespace Exercise_15_HarlemShake
{
    public class HarlemShake
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        //Receives the text and the pattern from the console.
        public static void ReceiveInput()
        {
            var text = Console.ReadLine();
            var pattern = Console.ReadLine();
            ShakeIt(text, pattern);
        }

        //Removes the outter two occurences of the pattern if they exist.
        public static void ShakeIt(string text, string pattern)
        {
            while (pattern.Length > 0)
            {
                if (text.Contains(pattern) && text.IndexOf(pattern) != text.LastIndexOf(pattern))
                {
                    text = text.Remove(text.IndexOf(pattern), pattern.Length);
                    text = text.Remove(text.LastIndexOf(pattern), pattern.Length);
                    Console.WriteLine("Shaked it.");
                    pattern = pattern.Remove(pattern.Length / 2, 1);
                }
                else
                {
                    Console.WriteLine("No shake.");
                    Console.WriteLine(text);
                    return;
                }
            }

            Console.WriteLine("No shake.");
            Console.WriteLine(text);
        }
    }
}