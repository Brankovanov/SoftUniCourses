using System;
using System.Collections.Generic;

namespace Lab_04_MatchingBrackets
{
    public class matchingBrackets
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        //Receive input from the console.
        static void ReceiveInput()
        {
            var input = Console.ReadLine();

            FindBrackets(input);
        }

        //Finds the bracketed expressions.
        static void FindBrackets(string input)
        {
            var bracketStack = new Stack<int>();

            for (var index = 0; index <= input.Length - 1; index++)
            {
                if (input[index].Equals('('))
                {
                    bracketStack.Push(index);
                }
                else if (input[index].Equals(')'))
                {
                    var startingIndex = bracketStack.Pop();

                    var output = input.Substring(startingIndex, index - startingIndex + 1);
                    PrintBrackets(output);
                }
            }
        }

        //Prints the bracketed Expressions.
        static void PrintBrackets(string output)
        {
            Console.WriteLine(output);
        }
    }
}