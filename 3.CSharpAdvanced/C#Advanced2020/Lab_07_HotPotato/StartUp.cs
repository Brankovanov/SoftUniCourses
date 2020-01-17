using System;
using System.Collections.Generic;

namespace Lab_07_HotPotato
{
    class StartUp
    {
        static void Main(string[] args)
        {
            ReceiveKids();
        }

        public static void ReceiveKids()
        {
            var kids = Console.ReadLine().Split(' ');
            var step = int.Parse(Console.ReadLine());

            CreateQueue(kids, step);
        }

        public static void CreateQueue(string[] kids, int step)
        {
            var kidsQueue = new Queue<string>();

            foreach (var kid in kids)
            {
                kidsQueue.Enqueue(kid);
            }

            var stepCount = 0;

            PlayTheGame(kidsQueue, step, stepCount);
        }

        public static void PlayTheGame(Queue<string> kidsQueue, int step, int stepCount)
        {
            if (kidsQueue.Count > 1)
            {
                var temp = 0;
                temp = step;
                var tempKids = new Queue<string>();

                do
                {
                    stepCount++;

                    if (stepCount == temp && kidsQueue.Count > 1)
                    {
                        Console.WriteLine($"Removed {kidsQueue.Dequeue()}");
                        stepCount = 0;
                    }
                    else if (stepCount == temp && kidsQueue.Count == 1 && kidsQueue.Count + tempKids.Count > 1)
                    {
                        Console.WriteLine($"Removed {kidsQueue.Dequeue()}");
                        stepCount = 0;
                    }
                    else if (stepCount == temp && kidsQueue.Count == 1 && kidsQueue.Count + tempKids.Count == 1)
                    {
                        Console.WriteLine($"Last is {kidsQueue.Dequeue()}");
                        Environment.Exit(1);
                    }
                    else
                    {
                        tempKids.Enqueue(kidsQueue.Dequeue());
                    }
                }
                while (kidsQueue.Count > 0);

                PlayTheGame(tempKids, step, stepCount);
            }
            else
            {
                Console.WriteLine($"Last is {kidsQueue.Dequeue()}");
            }
        }
    }
}