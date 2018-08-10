using System;
using System.Collections.Generic;

namespace Exercise_04_SpeedRacing
{
    public class SpeedRacing
    {
        public static void Main()
        {
            ReceiveCars();
        }

        //Receives cars information from the console.
        public static void ReceiveCars()
        {
            var listOfCars = new List<Car>();
            var numberOfCars = int.Parse(Console.ReadLine());

            for (var car = 1; car <= numberOfCars; car++)
            {
                var information = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var carModel = information[0];
                var fuel = int.Parse(information[1]);
                var fuelPerKm = double.Parse(information[2]);
                var newCar = new Car(carModel, fuel, fuelPerKm);
                listOfCars.Add(newCar);
            }

            Travel(listOfCars);
        }

        //Receive destination from the console.
        public static void Travel(List<Car> listOfCars)
        {
            var journey = Console.ReadLine();

            while (journey != "End")
            {
                var temp = journey.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var car = temp[1];
                var travelDistance = int.Parse(temp[2]);
                CalculateFuel(car, travelDistance, listOfCars);
                journey = Console.ReadLine();
            }

            FinalPrint(listOfCars);
        }

        //Calculates if the car has enough fuel to make the travel.
        public static void CalculateFuel(string car, int travelDistance, List<Car> listOfCars)
        {
            listOfCars.Find(c => c.Model == car).Travel(listOfCars.Find(c => c.Model == car).FuelTank,
                listOfCars.Find(c => c.Model == car).FuelConsumption,
                listOfCars.Find(c => c.Model == car).DistanceTraveled,
                travelDistance);
        }

        //Prints all cars and their remaining fuel.
        public static void FinalPrint(List<Car> listOfCars)
        {
            foreach (var car in listOfCars)
            {
                Console.Write(string.Join(" ", car.Model, string.Format("{0:0.00}", car.FuelTank), car.DistanceTraveled));
                Console.WriteLine();
            }
        }
    }
}