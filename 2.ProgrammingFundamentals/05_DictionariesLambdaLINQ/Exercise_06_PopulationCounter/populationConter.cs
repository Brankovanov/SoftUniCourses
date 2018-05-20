using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_06_PopulationCounter
{
    public class populationConter
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        static void ReceiveInput()
        {
            List<string> initialReport = new List<string>();

            var input = Console.ReadLine();
            initialReport.Add(input);

            while (input != "report")
            {
                input = Console.ReadLine();
                initialReport.Add(input);
            }

            initialReport.Remove("report");

            ProccessInput(initialReport);
        }

        static void ProccessInput(List<string> initialReport)
        {
            List<string> temp = new List<string>();
            var country = string.Empty;
            var city = string.Empty;
            var cityPopulation = 0L;

            Dictionary<string, SortedDictionary<string, long>> countryDictionary = new Dictionary<string, SortedDictionary<string, long>>();

            foreach (var entry in initialReport)
            {
                temp = entry.Split('|').ToList();
                country = temp[1].ToString();
                city = temp[0].ToString();
                cityPopulation = long.Parse(temp[2].ToString());

                if (!countryDictionary.ContainsKey(country))
                {
                    countryDictionary[country] = new SortedDictionary<string, long>();
                }

                if (!countryDictionary[country].ContainsKey(city))
                {
                    countryDictionary[country][city] = cityPopulation;
                }
            }

            CalculateTotalPopulation(countryDictionary);
        }

        static void CalculateTotalPopulation(Dictionary<string, SortedDictionary<string, long>> countryDictionary)
        {
            Dictionary<string, long> totalPopulations = new Dictionary<string, long>();

            foreach (var state in countryDictionary)
            {
                totalPopulations.Add(state.Key, 0);

                foreach (var city in state.Value)
                {
                    totalPopulations[state.Key] += city.Value;
                }
            }

            Print(countryDictionary, totalPopulations);
        }

        static void Print(Dictionary<string, SortedDictionary<string, long>> countryDictionary, Dictionary<string, long> totalPopulations)
        {
            foreach (KeyValuePair<string, long> country in totalPopulations.OrderByDescending(k => k.Value))
            {
                Console.WriteLine(country.Key + " (total population: " + country.Value + ")");

                foreach (KeyValuePair<string, long> city in countryDictionary[country.Key].OrderByDescending(x => x.Value))
                {
                    Console.WriteLine("=>" + city.Key + ": " + city.Value);
                }
            }
        }
    }
}
