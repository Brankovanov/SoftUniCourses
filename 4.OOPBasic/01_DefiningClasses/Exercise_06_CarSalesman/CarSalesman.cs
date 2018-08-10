using System;
using System.Collections.Generic;

namespace Exercise_06_CarSalesman
{
    public class CarSalesman
    {
        public static void Main()
        {
            ReceiveEngine();
        }

        //Receives information about the engines from the console.
        public static void ReceiveEngine()
        {
            var listOfEngine = new List<Engine>();
            var numberOfEngines = int.Parse(Console.ReadLine());

            for (var engine = 1; engine <= numberOfEngines; engine++)
            {
                var temp = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var model = temp[0];
                var power = int.Parse(temp[1]);
                var checker = false;

                if (temp.Length == 3)
                {
                    checker = int.TryParse(temp[2], out int displacement);
                    if (checker)
                    {
                        var typeOfEngine = new Engine(model, power, displacement);
                        listOfEngine.Add(typeOfEngine);
                    }
                    else
                    {
                        var efficiency = temp[2];
                        var typeOfEngine = new Engine(model, power, efficiency);
                        listOfEngine.Add(typeOfEngine);
                    }
                }
                else if (temp.Length == 2)
                {
                    var typeOfEngine = new Engine(model, power);
                    listOfEngine.Add(typeOfEngine);
                }
                else if (temp.Length == 4)
                {
                    var efficiency = temp[3];
                    var displacement = int.Parse(temp[2]);
                    var typeOfEngine = new Engine(model, power, displacement, efficiency);
                    listOfEngine.Add(typeOfEngine);
                }
            }

            ReceiveCar(listOfEngine);
        }

        //Receives car information from the console.
        public static void ReceiveCar(List<Engine> listOfEngine)
        {
            var carList = new List<Car>();
            var numberOfCars = int.Parse(Console.ReadLine());

            for (var automobile = 1; automobile <= numberOfCars; automobile++)
            {
                var temp = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var carModel = temp[0];
                var engineModel = temp[1];
                var engineChecker = false;

                if (temp.Length == 3)
                {
                    engineChecker = int.TryParse(temp[2], out int weight);

                    if (engineChecker)
                    {
                        var newCar = new Car(carModel, listOfEngine.Find(e => e.Model == engineModel), weight);
                        carList.Add(newCar);
                    }
                    else
                    {
                        var color = temp[2];
                        var newCar = new Car(carModel, listOfEngine.Find(e => e.Model == engineModel), color);
                        carList.Add(newCar);
                    }
                }
                else if (temp.Length == 2)
                {
                    var newCar = new Car(carModel, listOfEngine.Find(e => e.Model == engineModel));
                    carList.Add(newCar);
                }
                else if (temp.Length == 4)
                {
                    var color = temp[3];
                    var weight = int.Parse(temp[2]);
                    var newCar = new Car(carModel, listOfEngine.Find(e => e.Model == engineModel), weight, color);
                    carList.Add(newCar);
                }
            }

            PrintCars(carList);
        }

        //Prints the car statistics on the console.
        public static void PrintCars(List<Car> carList)
        {
            foreach (var c in carList)
            {
                Console.WriteLine(c.Model + ":");
                Console.WriteLine("  " + c.EngineType.Model + ":");
                Console.WriteLine("     Power: " + c.EngineType.Power);

                if (c.EngineType.Displacement == 0)
                {
                    Console.WriteLine("     Displacement: n/a");
                }
                else
                {
                    Console.WriteLine("     Displacement: " + c.EngineType.Displacement);
                }

                Console.WriteLine("     Efficiency: " + c.EngineType.Efficiency);

                if (c.Weight == 0)
                {
                    Console.WriteLine(" Weight: n/a");
                }
                else
                {
                    Console.WriteLine("  Weight: " + c.Weight);
                }

                Console.WriteLine(" Color: " + c.Color);
            }
        }
    }
}