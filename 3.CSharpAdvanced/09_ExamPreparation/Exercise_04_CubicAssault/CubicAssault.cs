using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Exercise_04_CubicAssault
{
    public class CubicAssault
    {
        public static void Main(string[] args)
        {
            ReceiveBattleReport();
        }

        //Receives battlereports from the console.
        public static void ReceiveBattleReport()
        {
            var report = Console.ReadLine();
            var battleArchive = new Dictionary<string, Dictionary<string, BigInteger>>();

            while (report != "Count em all")
            {
                var temp = report.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                var region = temp[0];
                var typeMeteor = temp[1];
                var count = BigInteger.Parse(temp[2]);

                RecordInformation(battleArchive, region, typeMeteor, count);
                Recalculate(battleArchive);
                report = Console.ReadLine();
            }

            Print(battleArchive);
        }

        //Records the received information in the battleArchive.
        public static void RecordInformation(Dictionary<string, Dictionary<string, BigInteger>> battleArchive, string region, string typeMeteor, BigInteger count)
        {
            if (!battleArchive.ContainsKey(region))
            {
                battleArchive.Add(region, new Dictionary<string, BigInteger>());
            }

            if (!battleArchive[region].ContainsKey(typeMeteor))
            {
                battleArchive[region].Add(typeMeteor, count);
            }
            else
            {
                battleArchive[region][typeMeteor] += count;
            }
        }

        //Recalculates the numbers of meteors.
        public static void Recalculate(Dictionary<string, Dictionary<string, BigInteger>> battleArchive)
        {
            foreach (var region in battleArchive)
            {
                if (region.Value.ContainsKey("Green") && region.Value["Green"] >= 1000000)
                {
                    var add = region.Value["Green"] / 1000000;

                    if (region.Value.ContainsKey("Red"))
                    {
                        region.Value["Red"] += add;
                    }
                    else
                    {
                        region.Value.Add("Red", add);
                    }

                    region.Value["Green"] -= 1000000 * add;
                }

                if (region.Value.ContainsKey("Red") && region.Value["Red"] >= 1000000)
                {
                    var add = region.Value["Red"] / 1000000;

                    if (region.Value.ContainsKey("Black"))
                    {
                        region.Value["Black"] += add;
                    }
                    else
                    {
                        region.Value.Add("Black", add);
                    }

                    region.Value["Red"] -= 1000000 * add;
                }

                if (!region.Value.ContainsKey("Green"))
                {
                    region.Value.Add("Green", 0);
                }

                if (!region.Value.ContainsKey("Red"))
                {
                    region.Value.Add("Red", 0);
                }

                if (!region.Value.ContainsKey("Black"))
                {
                    region.Value.Add("Black", 0);
                }
            }
        }

        //Prints the results of the battle.
        public static void Print(Dictionary<string, Dictionary<string, BigInteger>> battleArchive)
        {
            foreach (var region in battleArchive.OrderByDescending(b => b.Value["Black"]).ThenBy(n => n.Key.Length).ThenBy(x => x.Key))
            {
                Console.WriteLine(region.Key);

                foreach (var meteor in region.Value.OrderByDescending(a => a.Value).ThenBy(n => n.Key))
                {
                    Console.WriteLine("-> " + meteor.Key + " : " + meteor.Value);
                }
            }
        }
    }
}