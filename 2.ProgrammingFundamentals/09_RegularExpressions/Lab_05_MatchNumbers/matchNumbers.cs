using System;
using System.Text.RegularExpressions;

namespace Lab_05_MatchNumbers
{
    public class matchNumbers
    {
        public static void Main(string[] args)
        {
            ReceiveNumbers();
        }

        //Получава поредица от символи от конзолата.
        static void ReceiveNumbers()
        {
            var input = Console.ReadLine();
            SortInput(input);
        }

        //Отсява числата от редицата символи.
        static void SortInput(string input)
        {
            var number = @"(^|(?<=\s))[-]?\d+(\.\d+)?($|\s)";
            var output = string.Empty;
            var matches = Regex.Matches(input, number);

            foreach (Match n in matches)
            {
                output += n.Value;
            }

            PrintOutput(output);
        }

        //Отпечатва сортираните числа.
        static void PrintOutput(string output)
        {
            Console.Write(output);
        }
    }
}