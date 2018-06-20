using System;
using System.Collections.Generic;

namespace Exercise_01_ReverseNumbersWithStacks
{
    public class reverseNumbersWithStacks
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        //Receives input from the console.
        static void ReceiveInput()
        {
            var stackOfNumbers = new Stack<string>(Console.ReadLine().Split(' '));

            PrintStack(stackOfNumbers);
        }

        //Prints the stack ot numbers.
        static void PrintStack(Stack<string> stackOfNumbers)
        {
            while (stackOfNumbers.Count > 0)
            {
                Console.Write(stackOfNumbers.Pop() + " ");
            }
        }
    }
}