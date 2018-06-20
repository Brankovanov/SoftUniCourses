using System;
using System.Collections.Generic;

namespace Lab_01_ReverseString
{
    public class reverseString
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        //Receives input from the console.
        static void ReceiveInput()
        {
            var input = Console.ReadLine();

            CreateStack(input);
        }

        //Converts the input in to a Stack.
        static void CreateStack(string input)
        {
            var reversedStack = new Stack<char>();

            foreach (var letter in input)
            {
                reversedStack.Push(letter);
            }

            CreateOutput(reversedStack);
        }

        //Creates the output from the stack.
        static void CreateOutput(Stack<char> reversedStack)
        {
            var output = string.Empty;

            while (reversedStack.Count > 0)
            {
                output += reversedStack.Pop();
            }

            Print(output);
        }

        //Prints the output.
        static void Print(string output)
        {
            Console.WriteLine(output);
        }
    }
}