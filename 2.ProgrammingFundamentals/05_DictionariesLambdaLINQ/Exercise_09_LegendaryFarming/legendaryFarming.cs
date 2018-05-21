using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_09_LegendaryFarming
{
    public class legendaryFarming
    {
        public static void Main(string[] args)
        {
            ReceiveLoot();
        }

        static void ReceiveLoot()
        {
            List<string> bagOfLoot = new List<string>();
            SortedDictionary<string, int> cashOfLoot = new SortedDictionary<string, int>();
            var quantity = 0;

            while (quantity == 0)
            {
                var loot = Console.ReadLine().ToLower();
                bagOfLoot = loot.Split(' ').ToList();
                var material = string.Empty;

                for (var item = 1; item <= bagOfLoot.Count - 1; item += 2)
                {
                    if (cashOfLoot.ContainsKey(bagOfLoot[item]))
                    {
                        cashOfLoot[bagOfLoot[item]] += int.Parse(bagOfLoot[item - 1]);                     

                        try
                        {
                            if (cashOfLoot["shards"] >= 250 || cashOfLoot["fragments"] >= 250 || cashOfLoot["motes"] >= 250)
                            {
                                quantity++;
                                break;
                            }
                        }
                        catch (KeyNotFoundException)
                        {
                        }
                    }
                    else
                    {
                        cashOfLoot.Add(bagOfLoot[item], int.Parse(bagOfLoot[item - 1]));

                        try
                        {
                            if (cashOfLoot["shards"] >= 250 || cashOfLoot["fragments"] >= 250 || cashOfLoot["motes"] >= 250)
                            {
                                quantity++;
                                break;
                            }
                        }
                        catch (KeyNotFoundException)
                        {
                        }
                    }
                }
            }

            ReceiveLegendary(cashOfLoot);
        }

        static void ReceiveLegendary(SortedDictionary<string, int> cashOfLoot)
        {
            SortedDictionary<string, int> remainingLegendary = new SortedDictionary<string, int>();

            if (cashOfLoot["shards"] >= 250)
            {
                Console.WriteLine("Shadowmourne obtained!");
                cashOfLoot["shards"] -= 250;

                CreateRemainingLoot(remainingLegendary, cashOfLoot);

            }
            else if (cashOfLoot["fragments"] >= 250)
            {
                Console.WriteLine("Valanyr obtained!");
                cashOfLoot["fragments"] -= 250;
                CreateRemainingLoot(remainingLegendary, cashOfLoot);
            }
            else if (cashOfLoot["motes"] >= 250)
            {
                Console.WriteLine("Dragonwrath obtained!");
                cashOfLoot["motes"] -= 250;
                CreateRemainingLoot(remainingLegendary, cashOfLoot);
            }

            PrintRemainingLoot(cashOfLoot, remainingLegendary);
            PrintTrash(cashOfLoot);
        }

        static void CreateRemainingLoot(SortedDictionary<string, int> remainingLegendary, SortedDictionary<string, int> cashOfLoot)
        {
            try
            {
                remainingLegendary.Add("shards", cashOfLoot["shards"]);
                cashOfLoot.Remove("shards");
            }
            catch (KeyNotFoundException)
            {
                remainingLegendary.Add("shards", 0);
            }

            try
            {
                remainingLegendary.Add("fragments", cashOfLoot["fragments"]);
                cashOfLoot.Remove("fragments");
            }
            catch (KeyNotFoundException)
            {
                remainingLegendary.Add("fragments", 0);
            }

            try
            {
                remainingLegendary.Add("motes", cashOfLoot["motes"]);
                cashOfLoot.Remove("motes");
            }
            catch (KeyNotFoundException)
            {
                remainingLegendary.Add("motes", 0);
            }
        }

        static void PrintRemainingLoot(SortedDictionary<string, int> cashOfLoot, SortedDictionary<string, int> remainingLegendary)
        {
            foreach (var legendary in remainingLegendary.OrderByDescending(k => k.Value))
            {
                Console.WriteLine(legendary.Key + ": " + legendary.Value);
            }
        }

        static void PrintTrash(SortedDictionary<string, int> cashOfLoot)
        {
            foreach (var trash in cashOfLoot)
            {
                Console.WriteLine(trash.Key + ": " + trash.Value);
            }
        }
    }
}
