using System;

namespace Exercise_15_DebuggingSubstring
{
    public class debuggingSubstring
    {
        public static void Main(string[] args)
        {
            var text = InputString();
            var subStringRange = int.Parse(Console.ReadLine());

            Checker(text, subStringRange);

        }

        static string InputString()
        {
            return Console.ReadLine();
        }

        static void Checker(string text, int subStringRange)
        {
            var counter = 0;

            for (var ch = 0; ch < text.Length; ch++)
            {

                if (text[ch] == 'p')
                {
                    PrintOutput(text, subStringRange, ch);
                    ch += subStringRange;
                    counter++;
                }
            }

            if (counter == 0)
            {
                Console.WriteLine("no");
            }
        }

        static void PrintOutput(string text, int subStringRange, int ch)
        {
            if (text.Length-ch>subStringRange)
            {
                subStringRange += 1;
                Console.WriteLine(text.Substring(ch, subStringRange));
            }
            else
            {
                Console.WriteLine(text.Substring(ch, text.Length - ch));
            }
        }
    }
}
