using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_07_TruckTour
{
    public class truckTour
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        //Receive the track information on the console.
        static void ReceiveInput()
        {
            var numberOfStations = int.Parse(Console.ReadLine());
            var queueOfGasStations = new Queue<GasStation>();

            for (var stops = 0; stops <= numberOfStations - 1; stops++)
            {
                var information = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
                GasStation newGasStation = new GasStation();
                newGasStation.GasQuantity = information[0];
                newGasStation.Index = stops;
                newGasStation.DistanceToTheNextGasStation = information[1];

                queueOfGasStations.Enqueue(newGasStation);
            }

            FindTheBestTrack(queueOfGasStations);
        }

        //Find the best track;
        static void FindTheBestTrack(Queue<GasStation> queueOfGasStations)
        {
            var gasTank = 0;

            for (var index = 1; index <= queueOfGasStations.Count; index++)
            {
                gasTank += queueOfGasStations.Peek().GasQuantity;

                if (gasTank < queueOfGasStations.Peek().DistanceToTheNextGasStation)
                {
                    ModifyTrack(queueOfGasStations);
                    return;
                }
                else
                {
                    gasTank -= queueOfGasStations.Peek().DistanceToTheNextGasStation;
                    queueOfGasStations.Enqueue(queueOfGasStations.Dequeue());
                }
            }

            PrintStartingGasStation(queueOfGasStations);
        }

        //Modifies the track.
        static void ModifyTrack(Queue<GasStation> queueOfGasStations)
        {
            queueOfGasStations.Enqueue(queueOfGasStations.Dequeue());
            FindTheBestTrack(queueOfGasStations);
        }

        //Prints the index of the starting gas station.
        static void PrintStartingGasStation(Queue<GasStation> queueOfGasStations)
        {
            Console.WriteLine(queueOfGasStations.Peek().Index);
        }
    }

    //Creates new gasstations.
    public class GasStation
    {
        private int gasQuantity;
        private int distanceToTheNextGasStation;
        private int index;

        public int GasQuantity
        {
            get
            {
                return this.gasQuantity;
            }
            set
            {
                this.gasQuantity = value;
            }
        }

        public int DistanceToTheNextGasStation
        {
            get
            {
                return this.distanceToTheNextGasStation;
            }
            set
            {
                this.distanceToTheNextGasStation = value;
            }
        }

        public int Index
        {
            get
            {
                return this.index;
            }
            set
            {
                this.index = value;
            }
        }

        public GasStation()
        {
            this.gasQuantity = GasQuantity;
            this.distanceToTheNextGasStation = DistanceToTheNextGasStation;
            this.index = Index;
        }
    }
}