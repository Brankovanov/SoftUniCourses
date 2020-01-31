using System;
using System.Collections.Generic;

namespace Lab_08_TrafficJam
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var trafficJam = new Queue<string>();

            ReceiveCommands(trafficJam);
        }

        public static void ReceiveCommands(Queue<string>trafficJam)
        {
            var numberOfCarsThatPass = int.Parse(Console.ReadLine());
            var command = Console.ReadLine();
            var passedCarsCounter = 0;

            while(command!="end")
            {
                if(command=="green")
                {
                    for(var index = 1; index<=numberOfCarsThatPass; index++)
                    {
                        if(trafficJam.Count>0)
                        {
                            Console.WriteLine($"{trafficJam.Dequeue()} passed!");
                            passedCarsCounter++;
                        }
                    }
                }
                else
                {
                    trafficJam.Enqueue(command);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"{passedCarsCounter} cars passed the crossroads.");
        }
    }
}