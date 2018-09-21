using System.Collections.Generic;

namespace Part_2_Avatar
{
    //Class that holds the main functionality of the program.
    public class NationsBuilder
    {
        //Creates and records a new bender.
        public void AssignBender(string type, string name, int power, float secondaryParameter, List<AirBender> airNation, List<WaterBender> waterNation, List<FireBender> fireNation, List<EarthBender> earthNation)
        {
            switch (type)
            {
                case "Air":
                    var airBender = new AirBender(name, power, secondaryParameter);
                    airNation.Add(airBender);
                    break;

                case "Water":
                    var waterBender = new WaterBender(name, power, secondaryParameter);
                    waterNation.Add(waterBender);
                    break;

                case "Fire":
                    var fireBender = new FireBender(name, power, secondaryParameter);
                    fireNation.Add(fireBender);
                    break;

                case "Earth":
                    var earthBender = new EarthBender(name, power, secondaryParameter);
                    earthNation.Add(earthBender);
                    break;
            }
        }

        //Creates nad records a new monument.
        public void AssignMonument(string type, string name, int affinity, List<AirMonument> airMonuments, List<WaterMonument> waterMonuments, List<FireMonument> fireMonuments, List<EarthMonument> earthMonuments)
        {
            switch (type)
            {
                case "Air":
                    var airMonument = new AirMonument(name, affinity);
                    airMonuments.Add(airMonument);
                    break;

                case "Water":
                    var waterMonument = new WaterMonument(name, affinity);
                    waterMonuments.Add(waterMonument);
                    break;

                case "Fire":
                    var fireMonument = new FireMonument(name, affinity);
                    fireMonuments.Add(fireMonument);
                    break;

                case "Earth":
                    var earthMonument = new EarthMonument(name, affinity);
                    earthMonuments.Add(earthMonument);
                    break;
            }
        }

        //Checks the status of the given nation.
        public string GetStatus(string nationsType,
            List<AirBender> airNation, List<WaterBender> waterNation, List<FireBender> fireNation, List<EarthBender> earthNation,
            List<AirMonument> airMonuments, List<WaterMonument> waterMonument, List<FireMonument> fireMonuments, List<EarthMonument> earthMonuments)
        {
            var output = $"{nationsType} Nation\nBenders:";

            switch (nationsType)
            {
                case "Air":

                    if (airNation.Count > 0)
                    {
                        foreach (var bender in airNation)
                        {
                            output += $"\n###{nationsType} Bender: {bender.Name}, Power: {bender.Power}, Aerial Integrity: {string.Format("{0:0.00}", bender.AerialIntegrity)}";
                        }
                    }
                    else
                    {
                        output += " None";
                    }

                    break;

                case "Water":

                    if (waterNation.Count > 0)
                    {
                        foreach (var bender in waterNation)
                        {
                            output += $"\n###{nationsType} Bender: {bender.Name}, Power: {bender.Power}, Water Clarity: {string.Format("{0:0.00}", bender.WaterClarity)}";
                        }
                    }
                    else
                    {
                        output += " None";
                    }

                    break;

                case "Earth":

                    if (earthNation.Count > 0)
                    {
                        foreach (var bender in earthNation)
                        {
                            output += $"\n###{nationsType} Bender: {bender.Name}, Power: {bender.Power}, Ground Saturation: {string.Format("{0:0.00}", bender.GroundSaturation)}";
                        }
                    }
                    else
                    {
                        output += " None";
                    }

                    break;

                case "Fire":

                    if (fireNation.Count > 0)
                    {
                        foreach (var bender in fireNation)
                        {
                            output += $"\n###{nationsType} Bender: {bender.Name}, Power: {bender.Power}, Heat Aggression: {string.Format("{0:0.00}", bender.HeatAggression)}";
                        }
                    }
                    else
                    {
                        output += " None";
                    }

                    break;
            }

            output += "\nMonuments:";

            switch (nationsType)
            {
                case "Air":

                    if (airMonuments.Count > 0)
                    {
                        foreach (var monument in airMonuments)
                        {
                            output += $"\n###{nationsType} Monument: {monument.Name}, {nationsType} Affinity: {monument.AirAffinity}";
                        }
                    }
                    else
                    {
                        output += " None";
                    }

                    break;

                case "Water":

                    if (waterMonument.Count > 0)
                    {
                        foreach (var monument in waterMonument)
                        {
                            output += $"\n###{nationsType} Monument: {monument.Name}, {nationsType} Affinity: {monument.WaterAffinity}";
                        }
                    }
                    else
                    {
                        output += " None";
                    }

                    break;

                case "Fire":

                    if (fireMonuments.Count > 0)
                    {
                        foreach (var monument in fireMonuments)
                        {
                            output += $"\n###{nationsType} Monument: {monument.Name}, {nationsType} Affinity: {monument.FireAffinity}";
                        }
                    }
                    else
                    {
                        output += " None";
                    }

                    break;

                case "Earth":

                    if (earthMonuments.Count > 0)
                    {
                        foreach (var monument in earthMonuments)
                        {
                            output += $"\n###{nationsType} Monument: {monument.Name}, {nationsType} Affinity: {monument.EarthAffinity}";
                        }
                    }
                    else
                    {
                        output += " None";
                    }

                    break;
            }

            return output;
        }

        //Calculates the nations' military power and resolves the war.
        public void IssueWar(List<AirBender> airNation, List<WaterBender> waterNation, List<FireBender> fireNation, List<EarthBender> earthNation,
            List<AirMonument> airMonuments, List<WaterMonument> waterMonuments, List<FireMonument> fireMonuments, List<EarthMonument> earthMonuments)
        {
            var airPower = 0.0f;
            var airAffinity = 0;

            foreach (var airBender in airNation)
            {
                airPower += (airBender.Power * airBender.AerialIntegrity);
            }

            foreach (var air in airMonuments)
            {
                airAffinity += air.AirAffinity;
            }

            airPower += (airAffinity / 100) * airPower;

            var waterPower = 0.0f;
            var waterAffinity = 0;

            foreach (var waterBender in waterNation)
            {
                waterPower += (waterBender.Power * waterBender.WaterClarity);
            }

            foreach (var water in waterMonuments)
            {
                waterAffinity += water.WaterAffinity;
            }

            waterPower += (waterAffinity / 100) * waterPower;

            var firePower = 0.0f;
            var fireAffinity = 0;

            foreach (var fireBender in fireNation)
            {
                firePower += (fireBender.Power * fireBender.HeatAggression);
            }

            foreach (var fire in fireMonuments)
            {
                fireAffinity += fire.FireAffinity;
            }

            firePower += (fireAffinity / 100) * firePower;

            var earthPower = 0.0f;
            var earthAffinity = 0;

            foreach (var earthBender in earthNation)
            {
                earthPower += (earthBender.Power * earthBender.GroundSaturation);
            }

            foreach (var earth in earthMonuments)
            {
                earthAffinity += earth.EarthAffinity;
            }

            earthPower += (earthAffinity / 100) * earthPower;

            if (airPower > waterPower && airPower > firePower && airPower > earthPower)
            {
                waterMonuments.Clear();
                earthMonuments.Clear();
                fireMonuments.Clear();
                fireNation.Clear();
                waterNation.Clear();
                earthNation.Clear();
            }
            else if (airPower < waterPower && waterPower > firePower && waterPower > earthPower)
            {
                airMonuments.Clear();
                earthMonuments.Clear();
                fireMonuments.Clear();
                fireNation.Clear();
                airNation.Clear();
                earthNation.Clear();
            }
            else if (firePower > airPower && firePower > waterPower && firePower > earthPower)
            {
                waterMonuments.Clear();
                earthMonuments.Clear();
                airMonuments.Clear();
                airNation.Clear();
                waterNation.Clear();
                earthNation.Clear();
            }
            else if (earthPower > airPower && earthPower > waterPower && firePower < earthPower)
            {
                waterMonuments.Clear();
                airMonuments.Clear();
                fireMonuments.Clear();
                fireNation.Clear();
                waterNation.Clear();
                airNation.Clear();
            }
        }
    }
}