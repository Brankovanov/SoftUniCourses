using System;
using System.Linq;

namespace Exercise_17_BePositive
{
    public class bePositive
    {
        public static void Main(string[] args)
        {
            var numberOfSequences = int.Parse(Console.ReadLine());
            var incommingSequence = string.Empty;

            ReceiveSequences(numberOfSequences, incommingSequence);
        }

        static void ReceiveSequences(int numberOfSequences, string incommingSequence)
        {
            for (var input = 1; input <= numberOfSequences; input++)
            {
                incommingSequence = Console.ReadLine();

                var sequence = incommingSequence.Split(' ').Where(x => !string.IsNullOrEmpty(x)).ToArray();

                ProccessSequence(sequence);
            }
        }

        static void ProccessSequence(string[] sequence)
        {
            var counter = 0;
            var rollCounter = 0;
            var negativNumber = 0;

            foreach (var num in sequence)
            {
                int.TryParse(num, out var number);

                if (number >= 0 && counter == 0)
                {
                    Console.Write(number + " ");

                    rollCounter++;
                }
                else if (number < 0 && counter == 0)
                {
                    counter++;
                    negativNumber += number;
                }
                else if (counter == 1)
                {
                    counter++;
                    negativNumber += number;

                    if (negativNumber >= 0)
                    {
                        Console.Write(negativNumber + " ");

                        rollCounter++;
                    }

                    counter = 0;
                    negativNumber = 0;
                }
            }

            if (rollCounter == 0)
            {
                Console.WriteLine("(empty)");
            }
            else
            {
                rollCounter = 0;
            }

            Console.WriteLine();
        }
    }
}
