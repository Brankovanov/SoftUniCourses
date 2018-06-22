using System;

namespace _15_VegetableMarket
{
    public class vegetableMarket
    {
        public static void Main(string[] args)
        {
            ReceivingInput();
        }

        //Receives input from the console.
        static void ReceivingInput()
        {
            var priceVegetables = double.Parse(Console.ReadLine());
            var priceFruits = double.Parse(Console.ReadLine());
            var totalVegetables = int.Parse(Console.ReadLine());
            var totalFruits = int.Parse(Console.ReadLine());

            CalculatePrices(priceVegetables, priceFruits, totalVegetables, totalFruits);
        }

        //Calculates the final prices in euro.
        static void CalculatePrices(double priceVegetables, double priceFruits, int totalVegetables, int totalFruitts)
        {
            var output = ((priceFruits * totalFruitts) + (priceVegetables * totalVegetables)) / 1.94;
            Print(output);
        }

        //Prints output.
        static void Print(double output)
        {
            Console.WriteLine(output);
        }
    }
}