using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_10_PopulationCounter
{
    public class populationCounter
    {
        public static void Main(string[] args)
        {
            ReceivePopulationInfo();
        }

        //Receives information about the population from the console.
        static void ReceivePopulationInfo()
        {
            var populationRecord = new Dictionary<string, Country>();
            var input = Console.ReadLine();

            while (input != "report")
            {
                ProcessTheInput(input, populationRecord);
                input = Console.ReadLine();
            }

            Print(populationRecord);
        }

        //Processes the input.
        static void ProcessTheInput(string input, Dictionary<string, Country> populationRecord)
        {
            var temp = input.Split('|');
            var city = temp[0];
            var country = temp[1];
            var population = int.Parse(temp[2]);

            RecordPopulationInfo(city, country, population, populationRecord);
        }

        //Records the new population information.
        static void RecordPopulationInfo(string city, string country, int population, Dictionary<string, Country> populationRecord)
        {
            if (!populationRecord.ContainsKey(country))
            {
                Country newCountry = new Country();
                newCountry.City = new Dictionary<string, long>();
                newCountry.City.Add(city, population);
                newCountry.TotalPopulation += population;
                populationRecord.Add(country, newCountry);
            }
            else if (populationRecord.ContainsKey(country) && populationRecord[country].City.ContainsKey(city))
            {
                populationRecord[country].City[city] += population;
                populationRecord[country].TotalPopulation += population;
            }
            else if (populationRecord.ContainsKey(country) && !populationRecord[country].City.ContainsKey(city))
            {
                populationRecord[country].City.Add(city, population);
                populationRecord[country].TotalPopulation += population;
            }
        }

        //Prints the information gathered.
        static void Print(Dictionary<string, Country> populationRecord)
        {
            foreach (var country in populationRecord.OrderByDescending(c => c.Value.TotalPopulation))
            {
                Console.WriteLine($"{country.Key} (total population: {country.Value.TotalPopulation})");

                foreach (var city in country.Value.City.OrderByDescending(p => p.Value))
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }
        }
    }

    //Creates object newCountry that holds population information.
    public class Country
    {
        private Dictionary<string, long> city;
        private long totalPopulation;

        public Dictionary<string, long> City
        {
            get
            {
                return this.city;
            }
            set
            {
                this.city = value;
            }
        }

        public long TotalPopulation
        {
            get
            {
                return this.totalPopulation;
            }
            set
            {
                this.totalPopulation = value;
            }
        }

        public Country()
        {
            this.city = City;
            this.totalPopulation += totalPopulation;
        }
    }
}