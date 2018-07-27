using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_03_Names
{
    public class Names
    {
        public static void Main(string[] args)
        {
            ReceiveText();
        }

        //Receives collection of strings from the console.
        public static void ReceiveText()
        {
            var names = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var letters = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(l => l.ToUpper()).ToList();
            FindNames(names, letters);
        }

        //Finds the first name that start with one of those letters.
        public static void FindNames(List<string> names, List<string> letters)
        {
            var output = "No match";

            foreach (var symbol in letters.OrderBy(l => l))
            {
                if (names.Any(n => n.StartsWith(symbol)))
                {
                    output = names.Where(n => n.StartsWith(symbol)).First();
                    break;
                }
            }

            Print(output);
        }

        //Prints the first name that starts with a letter from the letter collection.
        public static void Print(string output)
        {
            Console.WriteLine(output);
        }
    }
}