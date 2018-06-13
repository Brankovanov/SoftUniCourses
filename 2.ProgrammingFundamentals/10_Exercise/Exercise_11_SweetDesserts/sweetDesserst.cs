using System;

namespace Exercise_11_SweetDesserts
{
    public class sweetDesserst
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        //Receive input from the console.
        static void ReceiveInput()
        {
            var amountOfMoney = double.Parse(Console.ReadLine());
            var guests = double.Parse(Console.ReadLine());
            var priceOfBanana = double.Parse(Console.ReadLine());
            var priceOfEgg = double.Parse(Console.ReadLine());
            var priceOfKiloBerries = double.Parse(Console.ReadLine());

            var sets = CalculateSetsOfPortions(guests);
            var priceOfSets = CalculateThePriceOfASet(priceOfBanana, priceOfEgg, priceOfKiloBerries);
            CalculateTotalPrice(sets, priceOfSets, amountOfMoney);
        }

        //Calculate the number of portions sets(6 portions each).
        static double CalculateSetsOfPortions(double guests)
        {
            return Math.Ceiling(guests / 6);
        }

        //Calculate the price of one set of portions.
        static double CalculateThePriceOfASet(double priceOfBanana, double priceOfEgg, double priceOfKilloBerries)
        {
            return (priceOfBanana * 2) + (priceOfEgg * 4) + (priceOfKilloBerries * 0.2);
        }

        //Calculates the total prices.
        static void CalculateTotalPrice(double sets, double priceOfSets, double amountOfMoney)
        {
            var totalPrice = sets * priceOfSets;

            ComparePriceAndMoneyAvailable(totalPrice, amountOfMoney);
        }

        //Compare the prices and the money available.
        static void ComparePriceAndMoneyAvailable(double totalPrice, double amountOfMoney)
        {
            if (totalPrice <= amountOfMoney)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {string.Format("{0:0.00}", totalPrice)}lv.");
            }
            else
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {string.Format("{0:0.00}", totalPrice - amountOfMoney)}lv more.");
            }
        }
    }
}