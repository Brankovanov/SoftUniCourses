using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_02_CubicRube
{
    public class CubicRube
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        //Receives dimentions from the console.
        public static void ReceiveInput()
        {
            var dimentions = int.Parse(Console.ReadLine());
            var coordinates = Console.ReadLine();
            var coordinatesArhive = new Queue<string>();
            var sum = 0L;
            var count = 0;

            while (coordinates != "Analyze")
            {
                var temp = coordinates.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(c => int.Parse(c)).ToArray();
                var lenght = temp[0];
                var widht = temp[1];
                var depth = temp[2];
                var key = string.Join(" ", lenght, widht, depth);
                var particle = temp[3];

                if ((lenght >= 0 && lenght < dimentions) 
                   && (widht >= 0 && widht < dimentions) 
                   && (depth >= 0 && depth < dimentions) 
                   && !coordinatesArhive.Contains(key) 
                   && particle != 0)
                {
                    sum += particle;
                    count++;
                    coordinatesArhive.Enqueue(key);
                }

                coordinates = Console.ReadLine();
            }

            PrintResults(sum, count, dimentions);
        }

        //Prints the results from the experiment.
        public static void PrintResults(long sum, int counter, int dimentions)
        {
            var unchanged = Math.Pow(dimentions, 3) - counter;

            Console.WriteLine(sum);
            Console.WriteLine(unchanged);
        }
    }
}