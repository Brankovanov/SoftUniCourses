using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Exercise_20_BarIncomeII
{
    public class BarIncomeII
    {
        public static void Main(string[] args)
        {
            ReceiveOrders();
        }

        //Receives orders from the console.
        static void ReceiveOrders()
        {
            var priceList = new List<double>();
            var totalPrice = 0.0;
            var order = Console.ReadLine();

            while (order != "end of shift")
            {
                ValidateOrders(order, priceList);
                order = Console.ReadLine();
            }

            foreach (var p in priceList)
            {
                totalPrice += p;
            }

            PrintsTotalPrice(totalPrice);
        }

        //Checks if the received order is valid.
        static void ValidateOrders(string order, List<double> priceList)
        {
            var namePattern = "^[A-Z]{1}[a-z]+$";
            var productPattern = @"\w+";
            var pricePattern = @"\d+(\d|[\.]{1}\d+)";
            var quantityPattern = @"\d+$";
            var nameRegex = new Regex(namePattern);
            var productRegex = new Regex(productPattern);
            var priceRegex = new Regex(pricePattern);
            var quantityRagex = new Regex(quantityPattern);

            var name = string.Empty;
            var product = string.Empty;
            var quantity = 0;
            var price = string.Empty;

            var pricePerOne = 0.0;
            var orderPrice = 0.0;

            if (order.StartsWith("%") && order.IndexOf('%') != order.LastIndexOf('%'))
            {
                name = order.Substring(1, order.LastIndexOf('%') - 1);

                if (!nameRegex.IsMatch(name))
                {
                    return;
                }
            }

            if (order.Contains('<') && order.Contains('>'))
            {
                product = order.Substring(order.IndexOf('<') + 1, order.LastIndexOf('>') - order.IndexOf('<') - 1);

                if (!productRegex.IsMatch(product))
                {
                    return;
                }
            }

            var temp = order.Split('|');

            try
            {
                int.TryParse(quantityRagex.Match(temp[1]).ToString(), out quantity);
            }
            catch (IndexOutOfRangeException)
            {
                return;
            }

            if (quantity == 0)
            {
                return;
            }

            price = temp[2];

            if (price.Contains('$'))
            {
                double.TryParse(priceRegex.Match(price).ToString().TrimEnd('$'), out pricePerOne);
            }
            else
            {
                return;
            }

            if (pricePerOne == 0)
            {
                return;
            }

            orderPrice = pricePerOne * quantity;
            Console.WriteLine($"{name}: {product} - {string.Format("{0:0.00}", orderPrice)}");
            priceList.Add(orderPrice);
        }

        //Prints the total income on the console after the end of the shift.
        static void PrintsTotalPrice(double totalPrice)
        {
            Console.WriteLine($"Total income: {string.Format("{0:0.00}", totalPrice)}");
        }
    }
}