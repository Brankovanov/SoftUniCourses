using System;
using System.Collections.Generic;

namespace Ex_10_Crossroads
{
    class StartUp
    {
        static void Main(string[] args)
        {
            ReceiveTrafficInformation();
        }

        private static void ReceiveTrafficInformation()
        {
            var greenLightDuration = int.Parse(Console.ReadLine());
            var clossingWindowDuration = int.Parse(Console.ReadLine());
            var traffic = Console.ReadLine();
            var trafficJam = new Queue<string>();
            var carCounter = 0;

            while (traffic != "END")
            {
                carCounter += SortTraffic(traffic,trafficJam,greenLightDuration,clossingWindowDuration);
                traffic = Console.ReadLine();
            }

            Success(carCounter);
        }

        private static void Success(int carCounter)
        {
            Console.WriteLine("Everyone is safe.");
           Console.WriteLine($"{carCounter} total cars passed the crossroads.");
        }

        private static int SortTraffic(string traffic, Queue<string> trafficJam, int greenLightDuration, int clossingWindowDuration)
        {
            var counter = 0;
            switch (traffic)
            {
                case "green":
                   counter = GreenLing(trafficJam, greenLightDuration, clossingWindowDuration);
                    return counter;
                default:
                    RedLinght(traffic, trafficJam);
                    return 0;
            }
        }

        private static int GreenLing(Queue<string> trafficJam, int greenLightDuration, int clossingWindowDuration)
        {
            var temp = greenLightDuration;
            var count = 0;

            while (temp > 0 && trafficJam.Count>0)
            {
                var carLenght = trafficJam.Peek().Length;

                if (carLenght <=temp)
                {
                    temp = temp - carLenght;
                    count++;
                    trafficJam.Dequeue();
                }
                else
                {
                    carLenght = carLenght - temp;
                    temp = 0;

                    if(carLenght>clossingWindowDuration)
                    {
                        carLenght = carLenght - clossingWindowDuration;
                        Console.WriteLine("A crash happened!");
                        Console.WriteLine($"{trafficJam.Peek()} was hit at {trafficJam.Peek()[trafficJam.Peek().Length - carLenght]}. ");
                        Environment.Exit(1);
                    }
                    else
                    {
                        count++;
                    }
                }

            }

            return count;
        }

        private static void RedLinght(string traffic, Queue<string> trafficJam)
        {
            trafficJam.Enqueue(traffic);
        }
    }
}
