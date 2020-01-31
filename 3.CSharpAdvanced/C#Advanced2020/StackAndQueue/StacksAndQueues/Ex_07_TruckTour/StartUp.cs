using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex_07_TruckTour
{
    class StartUp
    {
        static void Main(string[] args)
        {
            ReceiveInformation();
        }

        private static void ReceiveInformation()
        {
            var numberOfPetrolStations = int.Parse(Console.ReadLine());
            var petrolStations = new Queue<int[]>();

            for(var index=0; index<numberOfPetrolStations;index++)
            {
                var input = Console.ReadLine() + " " +index;
                var petrolStation =input.Split(' ').Select(n => int.Parse(n)).ToArray();
                petrolStations.Enqueue(petrolStation);
            }

            Drive(petrolStations);
        }

        private static void Drive(Queue<int[]> petrolStations)
        {
            var counter = 0;
            var fuelTank = 0;

            while(counter<petrolStations.Count)
            {
                if(fuelTank+petrolStations.Peek()[0]>=petrolStations.Peek()[1])
                {
                    fuelTank += petrolStations.Peek()[0] - petrolStations.Peek()[1];
                    petrolStations.Enqueue(petrolStations.Dequeue());
                    counter++;
                }
                else
                {
                    fuelTank = 0;
                    counter = 0;
                    petrolStations.Enqueue(petrolStations.Dequeue());
                }
            }

            Console.WriteLine(petrolStations.Peek()[2]);
        }
    }
}
