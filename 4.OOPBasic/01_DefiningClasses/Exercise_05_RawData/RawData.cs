using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_05_RawData
{
    public class RawData
    {
        public static void Main()
        {
            ReceiveData();
        }

        //Receives data for the cars from the console.
        public static void ReceiveData()
        {
            var carArhive = new List<Car>();
            var numberOfCars = int.Parse(Console.ReadLine());

            for (var car = 1; car <= numberOfCars; car++)
            {
                var carInformation = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var model = carInformation[0];
                var engineSpeed = int.Parse(carInformation[1]);
                var enginePower = int.Parse(carInformation[2]);

                var cargoWeight = int.Parse(carInformation[3]);
                var cargoType = carInformation[4];

                var tyreOnePressure = double.Parse(carInformation[5]);
                var tyreOneAge = int.Parse(carInformation[6]);
                var tyreTwoPressure = double.Parse(carInformation[7]);
                var tyreTwoAge = int.Parse(carInformation[8]);
                var tyreThreePressure = double.Parse(carInformation[9]);
                var tyreThreeAge = int.Parse(carInformation[10]);
                var tyreFourPressure = double.Parse(carInformation[11]);
                var tyreFourAge = int.Parse(carInformation[12]);

                var newCar = new Car(model, engineSpeed, enginePower, cargoWeight, cargoType, tyreOnePressure, tyreOneAge,
                             tyreTwoPressure, tyreTwoAge, tyreThreePressure, tyreThreeAge, tyreFourPressure, tyreFourAge);

                carArhive.Add(newCar);
            }

            Print(carArhive);
        }

        //Prints the required cars on the console.
        public static void Print(List<Car> carArchive)
        {
            var command = Console.ReadLine();

            switch (command)
            {
                case "fragile":

                    foreach (var car in carArchive.Where(c => c.CarCargo.CargoType == "fragile"))
                    {
                        if (car.CarTyre.Exists(tp => tp.Pressure < 1))
                        {
                            Console.WriteLine(car.Model);
                        }
                    }

                    break;

                case "flamable":

                    foreach (var car in carArchive.Where(c => c.CarCargo.CargoType == "flamable"))
                    {
                        if (car.CarEngine.Power > 250)
                        {
                            Console.WriteLine(car.Model);
                        }
                    }

                    break;
            }
        }
    }
}