using System;
using System.Collections.Generic;

namespace Exercise_05_SequenceWithQueue
{
    public class sequenceWithQueue
    {
        public static void Main(string[] args)
        {
            ReceiveStartingNumber();
        }

        //Receives the starting number of a sequence from the console.
        static void ReceiveStartingNumber()
        {
            var startingNumber = long.Parse(Console.ReadLine());
            CreateSequence(startingNumber);
        }

        //Creates sequence.
        static void CreateSequence(long startingNumber)
        {
            var sequence = new Queue<long>();
            var startSequence = new Queue<long>();
            sequence.Enqueue(startingNumber);
            startSequence.Enqueue(startingNumber);

            while (sequence.Count < 52)
            {
                sequence.Enqueue(startSequence.Peek() + 1);
                startSequence.Enqueue(startSequence.Peek() + 1);
                sequence.Enqueue(2 * startSequence.Peek() + 1);
                startSequence.Enqueue(2 * startSequence.Peek() + 1);
                sequence.Enqueue(startSequence.Peek() + 2);
                startSequence.Enqueue(startSequence.Peek() + 2);
                startSequence.Dequeue();
            }

            PrintSequence(sequence);
        }

        //Prints the first fifty members of the sequence.
        static void PrintSequence(Queue<long> sequence)
        {
            while (sequence.Count > 2)
            {
                Console.Write(sequence.Dequeue() + " ");
            }
        }
    }
}