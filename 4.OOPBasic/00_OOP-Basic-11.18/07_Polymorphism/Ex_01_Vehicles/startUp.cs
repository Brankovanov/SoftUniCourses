using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex_01_Vehicles
{
    public class startUp
    {
        static void Main()
        {
            ReceiveInformation();
        }

        public static void ReceiveInformation()
        {
            var listOfVehicles = new List<IVehicle>();

            for(var vehicle =0; vehicle<3; vehicle++)
            {
                var vehicleInfo=Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var type = vehicleInfo[0];
                var fuel = double.Parse(vehicleInfo[1]);
                var consumption = double.Parse(vehicleInfo[2]);
                var tankCapacity = double.Parse(vehicleInfo[3]);


                CreateVehicles(type, fuel, consumption, tankCapacity,listOfVehicles);

            }
           
            var numberOfCommands = int.Parse(Console.ReadLine());

            for (var commands = 0; commands < numberOfCommands; commands++)
            {
                var instruction = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.None);
                var action = instruction[0];
                var type = instruction[1];
                var quantity = double.Parse(instruction[2]);

                SortCommands(action, type, quantity, listOfVehicles);
            }

            PrintResults(listOfVehicles);

        }

        public static void CreateVehicles(string type, double fuel, double consumption, double tankCapacity,List<IVehicle>listOfVehicles)
        {
            switch (type)
            {
                case "Car":

                    var car = new Car(fuel, consumption, tankCapacity);
                    listOfVehicles.Add(car);
                    break;
                case "Bus":
                    var bus = new Bus(fuel, consumption, tankCapacity);
                    listOfVehicles.Add(bus);
                    break;
                case "Truck":
                    var truck = new Truck(fuel, consumption, tankCapacity);
                    listOfVehicles.Add(truck);
                    break;
            }
        }
        public static void SortCommands(string action, string type, double quantity, List<IVehicle> listOfVehicles)
        {
            switch (action)
            {
                case "Drive":

                    if (type == "Car")
                    {
                        foreach(var vehicle in listOfVehicles)
                        {
                            if(vehicle as Car!=null)
                            {
                                var car = vehicle as Car;
                                Drive(car, quantity);
                            }
                        }
                      
                    }
                    else if (type == "Truck")
                    {
                        foreach (var vehicle in listOfVehicles)
                        {
                            if (vehicle as Truck != null)
                            {
                                var truck = vehicle as Truck;
                                Drive(truck, quantity);
                            }
                        }
                       
                    }
                    else if (type == "Bus")
                    {
                        foreach (var vehicle in listOfVehicles)
                        {
                            if (vehicle as Bus != null)
                            {
                                var bus = vehicle as Bus;
                                Drive(bus, quantity);
                            }
                        }
                       
                    }
                    break;

                case "Refuel":

                    if (type == "Car")
                    {
                        foreach (var vehicle in listOfVehicles)
                        {
                            if (vehicle as Car != null)
                            {
                                var car = vehicle as Car;
                                Refuel(car, quantity);
                            }
                        }
                    }
                    else if (type == "Truck")
                    {
                        foreach (var vehicle in listOfVehicles)
                        {
                            if (vehicle as Truck != null)
                            {
                                var truck = vehicle as Truck;
                                Refuel(truck, quantity);
                            }
                        }
                    }
                    else if (type == "Bus")
                    {
                        foreach (var vehicle in listOfVehicles)
                        {
                            if (vehicle as Bus != null)
                            {
                                var bus = vehicle as Bus;
                                Refuel(bus, quantity);
                            }
                        }
                    }
                    break;
                case "DriveEmpty":

                    foreach (var vehicle in listOfVehicles)
                    {
                        if (vehicle as Bus != null)
                        {
                            var bus = vehicle as Bus;
                            DriveEmpty(bus, quantity);
                        }
                    }
                    break;
            }
        }

        public static void Drive(IVehicle vehicle, double quantity)
        {
            Console.WriteLine(vehicle.Drive(quantity));
        }

        public static void DriveEmpty(Bus bus, double quantity)
        {
            Console.WriteLine(bus.DriveEmpty(quantity));
        }

        public static void Refuel(IVehicle vehicle, double quantity)
        {
            try
            {
                vehicle.Refuel(quantity);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void PrintResults(List<IVehicle> listOfVehicles)
        {
            foreach (var vehicle in listOfVehicles)
            {
                Console.WriteLine(vehicle.ToString());
            } 
        }
    }
}

