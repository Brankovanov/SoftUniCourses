using System;
using System.Collections.Generic;

namespace Lab_06_ParkingLot
{
    class StartUp
    {
        static void Main(string[] args)
        {
            CreateParkingLot();
        }

        private static void CreateParkingLot()
        {
            var parkingLot = new HashSet<string>();

            ManipulateParkingLot(parkingLot);
        }

        private static void ManipulateParkingLot(HashSet<string> parkingLot)
        {
            var traffic = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

            while(traffic[0]!="END")
            {
                var command = traffic[0];
                var carNumber = traffic[1];

                switch(command)
                {
                    case "IN":
                        parkingLot.Add(carNumber);
                        break;
                    case "OUT":
                        parkingLot.Remove(carNumber);
                        break;
                }

                traffic = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            }

            PrintResult(parkingLot);
        }

        private static void PrintResult(HashSet<string> parkingLot)
        {
            if(parkingLot.Count==0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach(var car in parkingLot)
                {
                    Console.WriteLine(car);
                }
            }
        }
    }
}
