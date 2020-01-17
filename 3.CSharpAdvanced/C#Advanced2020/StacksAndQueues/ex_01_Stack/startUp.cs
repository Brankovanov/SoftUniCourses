using System;
using System.Collections.Generic;
using System.Linq;

namespace ex_01_Stack
{
    class startUp
    {
        static void Main(string[] args)
        {
            ReceiveInput();
        }

        private static void ReceiveInput()
        {
            var commands = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.None).Select(n => int.Parse(n)).ToArray();
            var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.None).Select(n => int.Parse(n)).ToArray();

            ManipulateStack(input, commands);
        }

        private static void ManipulateStack(int[] input, int[] commands)
        {
            var numberStack = new Stack<int>();

            PushElements(commands[0], input, numberStack);
            PopElements(commands[1], numberStack);
            PrintResult(commands[2], numberStack);
        }

        private static void PrintResult(int result, Stack<int> numberStack)
        {

            if (numberStack.Count == 0)
            {
                Console.WriteLine(0);
            }
            else if (numberStack.Contains(result))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(numberStack.Min());
            }
        }

        private static void PopElements(int pop, Stack<int> numberStack)
        {
            for (var index = 0; index < pop; index++)
            {
                if (numberStack.Count > 0)
                {
                    numberStack.Pop();
                }
            }
        }

        private static void PushElements(int add, int[] input, Stack<int> numberStack)
        {
            for (var index = 0; index < add; index++)
            {
                numberStack.Push(input[index]);
            }
        }
    }
}
