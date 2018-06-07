using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Exercise_04_WeatherReport
{
    public class weatherReport
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        //Получава вход от конзолата.
        static void ReceiveInput()
        {
            List<string> weatherReport = new List<string>();
            var input = Console.ReadLine();
            weatherReport.Add(input);

            while (input != "end")
            {
                input = Console.ReadLine();
                weatherReport.Add(input);
            }

            weatherReport.Remove("end");
            SortInput(weatherReport);
        }

        //Проверява дали входните данни отговарят на изискванията.
        static void SortInput(List<string> weatherReport)
        {
            var pattern = @"([A-Z]{2})([0-9]+\.[0-9]+)([a-zA-Z]+)\|?";
            Dictionary<string, WeatherReport> finalWeather = new Dictionary<string, WeatherReport>();

            foreach (var report in weatherReport)
            {
                if (Regex.IsMatch(report, pattern) && report.Contains("|"))
                {
                    var match = Regex.Match(report, pattern);

                    RecordMatches(match, pattern, finalWeather);
                }
            }

            PrintRecords(finalWeather);
        }

        //Записва данните, които отговарят на условието в речника.
        static void RecordMatches(Match match, string pattern, Dictionary<string, WeatherReport> finalWeather)
        {
            var city = match.Groups[1].ToString();
            var temperature = double.Parse(match.Groups[2].ToString());
            var weather = match.Groups[3].ToString();

            if (!finalWeather.ContainsKey(city))
            {
                WeatherReport newWeather = new WeatherReport();
                newWeather.CityName = city;
                newWeather.AverageTemperature = temperature;
                newWeather.WeatherType = weather;
                finalWeather[city] = newWeather;
            }
            else
            {
                finalWeather.Remove(city);
                WeatherReport newWeather = new WeatherReport();
                newWeather.CityName = city;
                newWeather.AverageTemperature = temperature;
                newWeather.WeatherType = weather;
                finalWeather[city] = newWeather;
            }
        }

        //Отпечатва записите за времето.
        static void PrintRecords(Dictionary<string, WeatherReport> finalWeather)
        {
            foreach (var objectCity in finalWeather.OrderBy(x => x.Value.AverageTemperature))
            {
                Console.WriteLine(objectCity.Value.CityName + " => " + String.Format("{0:0.00}", objectCity.Value.AverageTemperature) + " => " + objectCity.Value.WeatherType);
            }
        }
    }

    //Клас WeatherReport. Създава обект newWeather.
    public class WeatherReport
    {
        private string cityName;
        private string weatherType;
        private double averageTemperature;

        public string CityName
        {
            get
            {
                return this.cityName;
            }
            set
            {
                this.cityName = value;
            }
        }

        public string WeatherType
        {
            get
            {
                return this.weatherType;
            }
            set
            {
                this.weatherType = value;
            }
        }

        public double AverageTemperature
        {
            get
            {
                return this.averageTemperature;
            }
            set
            {
                this.averageTemperature = value;
            }
        }

        public WeatherReport()
        {
            this.cityName = CityName;
            this.weatherType = WeatherType;
            this.averageTemperature = AverageTemperature;
        }
    }
}