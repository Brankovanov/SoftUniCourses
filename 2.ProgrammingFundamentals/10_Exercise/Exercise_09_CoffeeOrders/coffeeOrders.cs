using System;
using System.Globalization;

namespace Exercise_09_CoffeeOrders
{
    public class coffeeOrders
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        //Receive input from the console.
        static void ReceiveInput()
        {
            var price = 0.0M;
            var totalPrice = 0.0M;
            var numberOrders = long.Parse(Console.ReadLine());

            for (var order = 1; order <= numberOrders; order++)
            {
                var pricePerCapsule = decimal.Parse(Console.ReadLine());
                var date = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                var numberOfCapsules = long.Parse(Console.ReadLine());

                price = calculatePrices(pricePerCapsule, date, numberOfCapsules, totalPrice, numberOrders, order);
                totalPrice += calculatePrices(pricePerCapsule, date, numberOfCapsules, totalPrice, numberOrders, order);

                Print(price, totalPrice, numberOrders, order);
            }
        }

        //Calculates the price of the coffee for every order and the total price for all orders.
        static decimal calculatePrices(decimal pricePerCapsule, DateTime date, long numberOfCapsules, decimal totalPrice, long numberOrders, long order)
        {
            var daysInMont = DateTime.DaysInMonth(date.Year, date.Month);
            return (daysInMont * numberOfCapsules) * pricePerCapsule;
        }

        //Prints the price of every order and in the end the total pKDrice  according the required format.
        static void Print(decimal price, decimal totalPrice, long numberOrders, long order)
        {
            Console.WriteLine($"The price for the coffee is: ${string.Format("{0:0.00}", price)}");

            if (order == numberOrders)
            {
                Console.WriteLine($"Total: ${string.Format("{0:0.00}", totalPrice)}");
            }
        }
    }
}