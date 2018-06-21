using System;
using System.Collections.Generic;

namespace Lab_01_ParkingLot
{
    public class parking
    {
        public static void Main(string[] args)
        {
            ReceiveCars();
        }

        //Receive traffic information from the console.
        static void ReceiveCars()
        {
            var parking = new SortedSet<string>();
            var cars = Console.ReadLine();

            while (cars != "END")
            {
                var temp = cars.Split(',');
                var direction = temp[0].Trim();
                var carNumber = temp[1].Trim();

                ManageParking(direction, carNumber, parking);

                cars = Console.ReadLine();
            }

            Print(parking);
        }


        //Manages the traffic in and out of the parking.
        static void ManageParking(string direction, string carNumber, SortedSet<string> parking)
        {
            if (direction.Equals("IN"))
            {
                parking.Add(carNumber);
            }
            else if (direction.Equals("OUT"))
            {
                parking.Remove(carNumber);
            }
        }

        //Prints the cars remaining in the parking.
        static void Print(SortedSet<string> parking)
        {
            if (parking.Count > 0)
            {
                foreach (var car in parking)
                {
                    Console.WriteLine(car);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}