using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Exercise_11_RageQuit
{
    public class rageQuits
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        //Receives the input from the console.
        static void ReceiveInput()
        {
            var input = Console.ReadLine();

            SplitTheInput(input);
        }

        //Splits the input string into groups of symbols and numbers.
        static void SplitTheInput(string input)
        {
            var pattern = @"(\d+)|([^\d]+)";
            var inputGroups = Regex.Matches(input, pattern);

            ProccessGroups(inputGroups);
        }

        //Proccesses the groups.
        static void ProccessGroups(MatchCollection inputGroups)
        {
            var output = new StringBuilder();

            for (var index = 1; index <= inputGroups.Count - 1; index += 2)
            {
                var term = inputGroups[index - 1].Value;
                var repetitions = int.Parse(inputGroups[index].Value);

                CreateOutput(term, repetitions, output);
            }

            var numberOfUniqueNumbers = CountUniqueSymbols(output);

            PrintOutput(output, numberOfUniqueNumbers);
        }

        //Creates the output text.
        static void CreateOutput(string term, int repetitions, StringBuilder output)
        {
            for (var rep = 1; rep <= repetitions; rep++)
            {
                output.Append(term);
            }
        }

        //Count the unique symbols in the input.
        static int CountUniqueSymbols(StringBuilder output)
        {
            return output.ToString().ToLower().Distinct().Count();
        }

        //Print the output and the unique characters in it.
        static void PrintOutput(StringBuilder output, int numberOfUniqueNumbers)
        {
            Console.WriteLine("Unique symbols used: " + numberOfUniqueNumbers);
            Console.WriteLine(output.ToString().ToUpper());
        }
    }
}
