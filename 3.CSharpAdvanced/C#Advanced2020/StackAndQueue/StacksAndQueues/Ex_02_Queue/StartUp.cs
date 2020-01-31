using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex_02_Queue
{
    class StartUp
    {
        static void Main(string[] args)
        {
            ReceiveInput();
        }

        private static void ReceiveInput()
        {
            var commands = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.None).Select(n => int.Parse(n)).ToArray();
            var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.None).Select(n => int.Parse(n)).ToArray();

            ManipulateQueue(input, commands);
        }

        private static void ManipulateQueue(int[] input, int[] commands)
        {
            var numberQueue = new Queue<int>();

            EnqueueElements(commands[0], input, numberQueue);
            PopElements(commands[1], numberQueue);
            PrintResult(commands[2], numberQueue);
        }

        private static void PrintResult(int result, Queue<int> numberQueue)
        {

            if (numberQueue.Count == 0)
            {
                Console.WriteLine(0);
            }
            else if (numberQueue.Contains(result))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(numberQueue.Min());
            }
        }

        private static void PopElements(int dequeue, Queue<int> numberQueue)
        {
            for (var index = 0; index < dequeue; index++)
            {
                if (numberQueue.Count > 0)
                {
                    numberQueue.Dequeue();
                }
            }
        }

        private static void EnqueueElements(int add, int[] input, Queue<int> numberQueue)
        {
            for (var index = 0; index < add; index++)
            {
                numberQueue.Enqueue(input[index]);
            }
        }
    }
}
