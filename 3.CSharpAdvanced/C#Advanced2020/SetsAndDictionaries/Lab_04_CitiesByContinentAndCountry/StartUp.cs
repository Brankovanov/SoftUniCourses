using System;
using System.Collections.Generic;

namespace Lab_04_CitiesByContinentAndCountry
{
    class StartUp
    {
        static void Main(string[] args)
        {
            ReceiveInformations();
        }

        private static void ReceiveInformations()
        {
            var numberOfEntries = int.Parse(Console.ReadLine());
            var geographyMap = new Dictionary<string, Dictionary<string, List<string>>>();

            for (var entry = 0; entry < numberOfEntries; entry++)
            {
                var information = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var continent = information[0];
                var country = information[1];
                var city = information[2];

                if (geographyMap.ContainsKey(continent))
                {
                    if (geographyMap[continent].ContainsKey(country))
                    {
                        geographyMap[continent][country].Add(city);
                    }
                    else
                    {
                        geographyMap[continent].Add(country, new List<string>());
                        geographyMap[continent][country].Add(city);
                    }
                }
                else
                {
                    geographyMap.Add(continent, new Dictionary<string, List<string>>());
                    geographyMap[continent].Add(country, new List<string>());
                    geographyMap[continent][country].Add(city);
                }

               
            }

            Print(geographyMap);
        }

        private static void Print(Dictionary<string, Dictionary<string, List<string>>> geographyMap)
        {
            foreach (var continent in geographyMap)
            {
                Console.WriteLine($"{continent.Key.ToString()}:");

                foreach (var country in continent.Value)
                {
                    Console.WriteLine($"   {country.Key} -> {string.Join(", ", country.Value)}");
                }
            }
        }
    }
}
