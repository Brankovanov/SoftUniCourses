using System;
using System.Collections;

namespace Lab_01_ReverseStrings
{
    class StartUp
    {
        static void Main()
        {
            ReceiveInput();
        }

        public static void ReceiveInput()
        {
            var input = Console.ReadLine();

            ReverseString(input);
            
        }

        public static void ReverseString(string input)
        {
            var stringStack = new Stack();

            foreach(var ch in input)
            {
                stringStack.Push(ch);
            }

            var output = string.Empty;

            foreach(var ch in stringStack)
            {
                output += ch;
            }

            Printer(output);
        }

        public static void Printer(string output)
        {
            Console.WriteLine(output);
        }
    }
}