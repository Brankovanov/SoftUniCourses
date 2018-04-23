using System;

namespace Lab_10__PriceChangeAlertRefractoring
{
    public class priceChangeAlertRefractoring
    {
        public static void Main(string[] args)
        {
            var numberOfPrices = int.Parse(Console.ReadLine());
            var significanceTreshold = double.Parse(Console.ReadLine());

            double[] arrayOfPrices = new double[numberOfPrices];

            Input(numberOfPrices, arrayOfPrices);
            PrintOutput(arrayOfPrices, numberOfPrices, significanceTreshold);
        }

        static void Input(int numberOfPrices, double[] arrayOfPrices)
        {
            for (var num = 0; num <= numberOfPrices - 1; num++)
            {
                arrayOfPrices[num] = InputPrices();
            }
        }

        static double InputPrices()
        {
            var price = double.Parse(Console.ReadLine());

            return price;
        }

        static void PrintOutput(double[] arrayOfPrices, int numberOfPrices, double significantTreshold)
        {
            var comparator = arrayOfPrices[0];
            var currentPrice = 0.0;

            for (var positionInTheArray = 1; positionInTheArray <= numberOfPrices - 1; positionInTheArray++)
            {
                currentPrice = arrayOfPrices[positionInTheArray];

                if (comparator - currentPrice == 0)
                {
                    Console.WriteLine($"NO CHANGE: { currentPrice }");
                }
                else if ((Math.Abs(comparator - currentPrice) / comparator >= significantTreshold))
                {
                    if (comparator < currentPrice)
                    {
                        Console.WriteLine($"PRICE UP: {comparator} to { currentPrice } ({CalculateDifferencePercent(comparator, currentPrice):F2}%)");
                    }
                    else
                    {
                        Console.WriteLine($"PRICE DOWN: {comparator} to { currentPrice} ({CalculateDifferencePercent(comparator, currentPrice):F2}%)");
                    }

                }
                else if ((Math.Abs(comparator - currentPrice) / comparator < significantTreshold))
                {
                    Console.WriteLine($"MINOR CHANGE: {comparator} to {  currentPrice } ({ CalculateDifferencePercent(comparator, currentPrice):F2}%)");

                }

                currentPrice = 0.0;
                comparator = arrayOfPrices[positionInTheArray];
            }
        }

        static double CalculateDifferencePercent(double comparator, double currentPrice)
        {
            var differencePercentage = (Math.Abs(comparator - currentPrice) / comparator) * 100;

            return differencePercentage;
        }

    }
}

