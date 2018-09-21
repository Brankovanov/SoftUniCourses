using System;

namespace Exercise_01__Vehicles
{
    public class StartUp
    {
        public static void Main()
        {
            ReceiveInput();
        }

        //Receives vehicles information from the console and creates them.
        public static void ReceiveInput()
        {
            var carInfo = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var carFuel = double.Parse(carInfo[1]);
            var carConsumption = double.Parse(carInfo[2]);
            var carTankCapacity = double.Parse(carInfo[3]);

            var newCar = new Car(carFuel, carConsumption, carTankCapacity, false);

            var truckInfo = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var truckFuel = double.Parse(truckInfo[1]);
            var truckConsumption = double.Parse(truckInfo[2]);
            var truckTankCapacity = double.Parse(truckInfo[3]);

            var newTruck = new Truck(truckFuel, truckConsumption, truckTankCapacity, false);

            var busInfo = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var busFuel = double.Parse(busInfo[1]);
            var busConsumption = double.Parse(busInfo[2]);
            var busTankCapacity = double.Parse(busInfo[3]);

            var newBus = new Bus(busFuel, busConsumption, busTankCapacity, true);

            Travel(newTruck, newCar, newBus);
        }

        //Receives travelling commands for the vehicles.
        public static void Travel(Truck newTruck, Car newCar, Bus newBus)
        {
            var numberOfCommands = int.Parse(Console.ReadLine());

            for (var comm = 1; comm <= numberOfCommands; comm++)
            {
                var command = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var action = command[0];
                var type = command[1];
                var quantity = double.Parse(command[2]);

                CheckVehicles(newTruck, newCar, newBus, type, action, quantity);
            }

            PrintRemainingFuel(newTruck, newCar, newBus);
        }

        //Check the type of vehicles.
        public static void CheckVehicles(Truck newTruck, Car newCar, Bus newBus, string type, string action, double quantity)
        {
            switch (type)
            {
                case "Car":
                    CheckCommands(newCar, action, quantity);
                    break;
                case "Truck":
                    CheckCommands(newTruck, action, quantity);
                    break;
                case "Bus":
                    CheckCommands(newBus, action, quantity);
                    break;
            }
        }

        //Check the type of command.
        public static void CheckCommands(Vehicles newVehicle, string action, double quantity)
        {
            switch (action)
            {
                case "Drive":
                    Drive(newVehicle, quantity);
                    break;
                case "DriveEmpty":
                    newVehicle.Passanger = false;
                    Drive(newVehicle, quantity);       
                    break;
                case "Refuel":
                    Refuel(newVehicle, quantity);
                    break;
            }
        }

        //Perform a driving action if possible.
        public static void Drive(Vehicles newVehicle, double quantity)
        {
            try
            {
                Console.WriteLine(newVehicle.Drive(quantity));
            }
            catch (ArgumentException x)
            {
                Console.WriteLine(x.Message);
            }
        }

        //Perform a refueling action if possible.
        public static void Refuel(Vehicles newVehicle, double quantity)
        {
            try
            {
                newVehicle.Refuel(quantity);
            }
            catch (ArgumentException x)
            {
                Console.WriteLine(x.Message);
            }
        }

        //Prints the remaining fuel after the end of the journey.
        public static void PrintRemainingFuel(Truck newTruck, Car newCar, Bus newBus)
        {
            Console.WriteLine(newCar.Remaining());
            Console.WriteLine(newTruck.Remaining());
            Console.WriteLine(newBus.Remaining());
        }
    }
}