using System;
using System.Collections.Generic;

namespace Exercise_03_MaximumElements
{
    public class maximumElements
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        //Receive commands from the console.
        static void ReceiveInput()
        {
            var stackOfNumbers = new Stack<int>();
            var max = new Stack<int>();
            var numberOfCommands = int.Parse(Console.ReadLine());

            for (var counter = 1; counter <= numberOfCommands; counter++)
            {
                var command = Console.ReadLine();
                ProcessCommand(command, stackOfNumbers, max);
            }
        }

        //Process the received commands.
        static void ProcessCommand(string command, Stack<int> stackOfNumbers, Stack<int> max)
        {
            var temp = command.Split(' ');
            var type = int.Parse(temp[0].ToString());

            if (type == 1)
            {
                var n = int.Parse(temp[1]);
                stackOfNumbers.Push(n);

                if (max.Count == 0)
                {
                    max.Push(n);
                }
                else if (max.Count != 0 && max.Peek() < n)
                {
                    max.Push(n);
                }
            }
            else if (type == 2 && stackOfNumbers.Count != 0)
            {
                if (stackOfNumbers.Peek() == max.Peek() && max.Count != 0)
                {
                    max.Pop();
                }

                stackOfNumbers.Pop();
            }
            else if (type == 3 && stackOfNumbers.Count != 0)
            {
                Console.WriteLine(max.Peek());
            }
        }
    }
}