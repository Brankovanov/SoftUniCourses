using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Exercise_18_BarIncome
{
    public class BarIncome
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
            var temp = order.Split(new char[] { '%', '|' }, StringSplitOptions.RemoveEmptyEntries);
            var namePattern = "^[A-Z]{1}[a-z]+$";
            var productPattern = @"^[<]{1}\w+[>]$";
            var pricePattern = @"\d+(\d|[\.]{1}\d+)[\$]{1}";
            var nameRegex = new Regex(namePattern);
            var productRegex = new Regex(productPattern);
            var priceRegex = new Regex(pricePattern);
            var name = temp[0].Trim(' ', '%');
            var product = temp[1];
            product = product.Remove(product.IndexOf('>')+1, product.Length-(product.IndexOf('>') + 1)) ;
            var quantity = 0;
            var price = string.Empty;

            if (temp.Length == 4)
            {
                int.TryParse(temp[2], out quantity);
                price = temp[3];
            }

            var pricePerOne = 0.0;
            var orderPrice = 0.0;

            if (order.StartsWith("%") && nameRegex.IsMatch(name) && productRegex.IsMatch(product) && quantity != 0 && price.EndsWith("$"))
            {
                product = product.Trim('<', '>');
                pricePerOne = double.Parse(priceRegex.Match(price).ToString().TrimEnd('$'));
                orderPrice = pricePerOne * quantity;
             
                Console.WriteLine($"{name}: {product} - {string.Format("{0:0.00}", orderPrice)}");
            }

            priceList.Add(orderPrice);
        }

        //Prints the total income on the console after the end of the shift.
        static void PrintsTotalPrice(double totalPrice)
        {
            Console.WriteLine($"Total income: {string.Format("{0:0.00}", totalPrice)}");
        }
    }
}
