using System;
using System.Collections.Generic;

namespace Part_2_Avatar
{
    public class StartUp
    {
        public static void Main()
        {
            ReceiveCommands();
        }

        //Receives commands from the console.
        public static void ReceiveCommands()
        {
            var airNation = new List<AirBender>();
            var waterNation = new List<WaterBender>();
            var earthNation = new List<EarthBender>();
            var fireNation = new List<FireBender>();
            var airMonuments = new List<AirMonument>();
            var waterMonuments = new List<WaterMonument>();
            var fireMonuments = new List<FireMonument>();
            var earthMonuments = new List<EarthMonument>();
            var newNation = new NationsBuilder();
            var warRecords = new List<string>();

            var command = string.Empty;
            var type = string.Empty;
            var name = string.Empty;
            var power = 0;
            var secondaryParameter = 0.0f;
            var affinity = 0;
            var nation = string.Empty;
            var warCounter = 1;
            var input = Console.ReadLine();

            while (input != "Quit")
            {
                var temp = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                command = temp[0];

                switch (command)
                {
                    case "Bender":

                        type = temp[1];
                        name = temp[2];
                        power = int.Parse(temp[3]);
                        secondaryParameter = float.Parse(temp[4]);
                        newNation.AssignBender(type, name, power, secondaryParameter, airNation, waterNation, fireNation, earthNation);
                        break;

                    case "Monument":

                        type = temp[1];
                        name = temp[2];
                        affinity = int.Parse(temp[3]);
                        newNation.AssignMonument(type, name, affinity, airMonuments, waterMonuments, fireMonuments, earthMonuments);
                        break;

                    case "Status":

                        nation = temp[1];
                        Console.WriteLine(newNation.GetStatus(nation,
                              airNation, waterNation, fireNation, earthNation,
                              airMonuments, waterMonuments, fireMonuments, earthMonuments));
                        break;

                    case "War":
                        nation = temp[1];
                        newNation.IssueWar(airNation, waterNation, fireNation, earthNation,
                            airMonuments, waterMonuments, fireMonuments, earthMonuments);
                        warRecords.Add($"War {warCounter} issued by {nation}");
                        warCounter++;
                        break;
                }

                input = Console.ReadLine();
            }

            foreach (var war in warRecords)
            {
                Console.WriteLine(war);
            }
        }
    }
}