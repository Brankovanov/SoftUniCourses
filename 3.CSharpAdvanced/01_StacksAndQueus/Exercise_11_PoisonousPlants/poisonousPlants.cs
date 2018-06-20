using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_11_PoisonousPlants
{
    public class poisonousPlants
    {
        public static void Main(string[] args)
        {
            ReceivePlantInformation();
        }

        //Receive information about the plants from the console.
        static void ReceivePlantInformation()
        {
            var numberOfPlants = int.Parse(Console.ReadLine());
            var plantList = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToList();
            var dayCounter = 0;
            SortPlants(plantList, numberOfPlants, dayCounter);
        }

        //Sorts the plants that survive.
        static void SortPlants(List<int> plantList, int numberOfPlants, int dayCounter)
        {
            var counter = false;
            var pest = plantList[0];
            dayCounter++;

            for (var index = 1; index <= plantList.Count - 1; index++)
            {
                if (pest < plantList[index])
                {
                    pest = plantList[index];
                    plantList.RemoveAt(index);
                    index--;
                    counter = true;
                }
                else
                {
                    pest = plantList[index];
                }
            }

            if (counter == true)
            {
                SortPlants(plantList, numberOfPlants, dayCounter);
            }
            else
            {
                Console.WriteLine(dayCounter - 1);
            }
        }
    }
}