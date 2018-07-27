using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_07_MapDistricts
{
    public class MapDistricts
    {
        public static void Main(string[] args)
        {
            ReceiveDistrict();
        }

        //Receives districts' information.
        public static void ReceiveDistrict()
        {
            var district = Console.ReadLine().Split(' ').ToList();
            var populationBound = int.Parse(Console.ReadLine());
            SortDistrict(district, populationBound);
        }

        //Sorts districts by their population.
        public static void SortDistrict(List<string> distric, int populationBound)
        {
            var city = string.Empty;
            var population = 0;
            var cityDictionary = new Dictionary<string, List<int>>();

            foreach (var dist in distric)
            {
                var temp = dist.Split(':');
                city = temp[0];
                population = int.Parse(temp[1]);

                if (cityDictionary.ContainsKey(city))
                {
                    cityDictionary[city].Add(population);
                }
                else
                {
                    cityDictionary.Add(city, new List<int>());
                    cityDictionary[city].Add(population);
                }
            }

            PrintDistricts(cityDictionary, populationBound);
        }

        //Prints the sorted districts that are in the population bounds.
        public static void PrintDistricts(Dictionary<string, List<int>> cityDictionary, int populationBound)
        {
            foreach (var city in cityDictionary.OrderByDescending(p => p.Value.Sum()).Where(pop => pop.Value.Sum() > populationBound))
            {
                Console.WriteLine(city.Key + ": " + string.Join(" ", city.Value.OrderByDescending(x => x).Take(5)));
            }
        }
    }
}