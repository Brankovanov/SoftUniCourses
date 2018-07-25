using System;
using System.Linq;

namespace Lab_04_AddedValue
{
    public class AddedValue
    {
        public static void Main(string[] args)
        {
            ReceivePrices();
        }

        //Receive the pricec on the console.
        public static void ReceivePrices()
        {
            var prices = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(p => double.Parse(p)).ToArray();
            AddValue(prices);
        }

        //Prints the prices with the added values.
        public static void AddValue(double[] prices)
        {
            foreach (var price in prices)
            {
                var final = price + (price * 0.2);
                Console.WriteLine(string.Format("{0:0.00}", final));

            }
        }
    }
}