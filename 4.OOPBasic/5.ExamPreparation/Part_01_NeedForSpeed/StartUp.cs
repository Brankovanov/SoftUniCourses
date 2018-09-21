using System;
using System.Collections.Generic;

namespace Part_01_NeedForSpeed
{
    public class StartUp
    {
        public static void Main()
        {
            ReceiveCommands();
        }

        //Receives commands from the command.
        public static void ReceiveCommands()
        {
            var commInput = Console.ReadLine();
            List<Car> reg = new List<Car>();
            List<Race> listRace = new List<Race>();
            List<Car> parkingLot = new List<Car>();

            while (commInput != "Cops Are Here")
            {
                SortCommands(commInput, reg, listRace, parkingLot);
                commInput = Console.ReadLine();
            }
        }

        //Sorts the commands.
        public static void SortCommands(string commInput, List<Car> reg, List<Race> listRace, List<Car> parkingLot)
        {
            var manager = new CarManager();
            var parking = new Garage();

            var temp = commInput.Split(new char[] { ' ' }, StringSplitOptions.None);
            var command = temp[0];
            var carId = 0;
            var raceId = 0;
            var type = string.Empty;
            var brand = string.Empty;
            var model = string.Empty;
            var year = 0;
            var horsePowers = 0;
            var acceleration = 0;
            var suspention = 0;
            var durability = 0;
            var length = 0;
            var route = string.Empty;
            var prizePool = 0;
            var tuneIndex = 0;
            var addOns = string.Empty;
            var additive = 0;

            switch (command)
            {
                case "register":

                    carId = int.Parse(temp[1]);
                    type = temp[2];
                    brand = temp[3];
                    model = temp[4];
                    year = int.Parse(temp[5]);
                    horsePowers = int.Parse(temp[6]);
                    acceleration = int.Parse(temp[7]);
                    suspention = int.Parse(temp[8]);
                    durability = int.Parse(temp[9]);
                    reg.Add(manager.Register(carId, type, brand, model, year, horsePowers, acceleration, suspention, durability, reg, listRace));
                    break;

                case "check":

                    carId = int.Parse(temp[1]);

                    try
                    {
                        Console.WriteLine(manager.Check(carId, reg));
                    }
                    catch (ArgumentException x)
                    {
                        Console.WriteLine(x.Message);
                    }

                    break;

                case "open":

                    raceId = int.Parse(temp[1]);
                    type = temp[2];
                    length = int.Parse(temp[3]);
                    route = temp[4];
                    prizePool = int.Parse(temp[5]);

                    if (temp.Length == 7)
                    {
                        additive = int.Parse(temp[6]);
                    }

                    listRace.Add(manager.Open(raceId, type, length, route, prizePool, additive));

                    break;

                case "participate":

                    carId = int.Parse(temp[1]);
                    raceId = int.Parse(temp[2]);

                    try
                    {
                        manager.Participate(carId, raceId, parking, listRace, reg, parkingLot);
                    }
                    catch (ArgumentException x)
                    {
                        Console.WriteLine(x.Message);
                    }

                    break;

                case "start":

                    raceId = int.Parse(temp[1]);

                    try
                    {
                        Console.WriteLine(manager.Start(raceId, listRace, reg));
                    }
                    catch (ArgumentException x)
                    {
                        Console.WriteLine(x.Message);
                    }

                    break;

                case "park":

                    carId = int.Parse(temp[1]);
                    manager.Park(carId, parking, listRace, reg, parkingLot);

                    break;

                case "unpark":

                    carId = int.Parse(temp[1]);
                    manager.Unpark(carId, parking, reg, parkingLot);

                    break;

                case "tune":

                    tuneIndex = int.Parse(temp[1]);
                    addOns = temp[2];
                    manager.Tune(tuneIndex, addOns, parking, parkingLot);

                    break;
            }
        }
    }
}