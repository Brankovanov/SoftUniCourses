using System;

namespace _20_Harvest
{
    public class Harvest
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        //Receives input from the console.
        static void ReceiveInput()
        {
            var vineyardArea = int.Parse(Console.ReadLine());
            var grapesPerSquareKilometer = double.Parse(Console.ReadLine());
            var wineRequired = double.Parse(Console.ReadLine());
            var numberOfWorkers = int.Parse(Console.ReadLine());

            CalculateWineProduction(vineyardArea, grapesPerSquareKilometer, wineRequired, numberOfWorkers);
        }

        //Calculates how much wine is produced.
        static void CalculateWineProduction(int vineyardArea, double grapesPerSquareKilometer, double wineRequired, int numberOfWorkers)
        {
            var totalGrapes = vineyardArea * grapesPerSquareKilometer;
            var grapesForWine = totalGrapes * 0.4;
            var wineProduced = grapesForWine / 2.5;

            CheckIfWineIsEnough(wineProduced, wineRequired, numberOfWorkers);
        }

        //Checks if the wine produced is enough.
        static void CheckIfWineIsEnough(double wineProduced, double wineRequired, int numberOfWorkers)
        {
            var output = string.Empty;

            if (wineProduced >= wineRequired)
            {
                var remainigWine = wineProduced - wineRequired;
                var winePerWorker = remainigWine / numberOfWorkers;

                output = $"Good harvest this year! Total wine: {(int)wineProduced} liters.\n{Math.Ceiling(remainigWine)} liters left -> {Math.Ceiling(winePerWorker)} liters per person.";
            }
            else
            {
                var wineNotEnough = wineRequired - wineProduced;

                output = $"It will be a tough winter! More {Math.Floor(wineNotEnough)} liters wine needed.";
            }

            PrintOutput(output);
        }

        //Prints the final output.
        static void PrintOutput(string output)
        {
            Console.WriteLine(output);
        }
    }
}