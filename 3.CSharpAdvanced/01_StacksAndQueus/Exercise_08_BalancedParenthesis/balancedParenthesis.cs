using System;
using System.Collections.Generic;

namespace Exercise_08_BalancedParenthesis
{
    public class balancedParenthesis
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        //Receives the input from the console.
        static void ReceiveInput()
        {
            var input = Console.ReadLine();
            ProcessTheInput(input);
        }

        //Process the input.
        static void ProcessTheInput(string input)
        {
            var symbols = new Stack<char>();

            foreach (var symbol in input)
            {
                try
                {
                    if (symbol == '(' || symbol == '[' || symbol == '{')
                    {
                        symbols.Push(symbol);
                    }
                    else if (symbol == ')' && symbols.Peek() == '(')
                    {
                        symbols.Pop();
                    }
                    else if (symbol == ']' && symbols.Peek() == '[')
                    {
                        symbols.Pop();
                    }
                    else if (symbol == '}' && symbols.Peek() == '{')
                    {
                        symbols.Pop();
                    }
                }
                catch (InvalidOperationException)
                {
                    symbols.Push('z');
                }
            }

            CheckForParenthesis(symbols);
        }

        //Check for parenthesis.
        static void CheckForParenthesis(Stack<char> symbols)
        {
            var output = string.Empty;

            if (symbols.Count == 0)
            {
                output = "YES";
            }
            else
            {

                output = "NO";

            }

            PrintOutput(output);
        }

        //Prints output.
        static void PrintOutput(string output)
        {
            Console.WriteLine(output);
        }
    }
}