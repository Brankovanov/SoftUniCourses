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

        public static void ReceiveInput()
        {
            List<string> initialReport = new List<string>();

            var input = Console.ReadLine();
            initialReport.Add(input);

            while(input!="report")
            {
                input = Console.ReadLine();
                initialReport.Add(input);
            }

            initialReport.Remove("report");

            ProccessInput(initialReport);
        }

        public static void ProccessInput (List<string>initialReport)
        {
            List<string> temp = new List<string>();
            var country = string.Empty;
            var city = string.Empty;
            var cityPopulation = 0;

            foreach(var entry in initialReport)
            {
              temp = entry.Split('|').ToList();
                country =temp[1].ToString();
                city = temp[0].ToString();
                cityPopulation = int.Parse(temp[2].ToString());
              
                Console.WriteLine(country);
                Console.WriteLine(city);
                Console.WriteLine(cityPopulation);


            }
        }
    }
}
