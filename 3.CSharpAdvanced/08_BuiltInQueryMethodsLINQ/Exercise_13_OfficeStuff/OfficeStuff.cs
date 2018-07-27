using System;
using System.Collections.Generic;

namespace Exercise_13_OfficeStuff
{
    public class OfficeStuff
    {
        public static void Main(string[] args)
        {
            ReceiveCompanyInformation();
        }

        //Receives firm information from the console.
        public static void ReceiveCompanyInformation()
        {
            var numberOfCompanies = int.Parse(Console.ReadLine());
            var company = string.Empty;
            var quantity = 0;
            var product = string.Empty;
            var orders = new SortedDictionary<string, Dictionary<string, int>>();

            for (var index = 1; index <= numberOfCompanies; index++)
            {
                company = Console.ReadLine();
                var temp = company.Trim('|').Split(new string[] { " - " }, StringSplitOptions.RemoveEmptyEntries);
                company = temp[0];
                quantity = int.Parse(temp[1]);
                product = temp[2];

                SortOrders(orders, company, quantity, product);
            }

            PrintOrder(orders);
        }

        //Sorts the orders received.
        public static void SortOrders(SortedDictionary<string, Dictionary<string, int>> orders, string company, int quantity, string product)
        {
            if (!orders.ContainsKey(company))
            {
                orders.Add(company, new Dictionary<string, int>());
            }

            if (!orders[company].ContainsKey(product))
            {
                orders[company].Add(product, quantity);
            }
            else
            {
                orders[company][product] += quantity;
            }
        }

        //Prints the sorted orders.
        public static void PrintOrder(SortedDictionary<string, Dictionary<string, int>> orders)
        {
            var output = string.Empty;

            foreach (var company in orders)
            {
                output = company.Key + ": ";

                foreach (var product in company.Value)
                {
                    output += product.Key + "-" + product.Value + ", ";
                }

                Console.WriteLine(output.TrimEnd(',', ' '));
            }
        }
    }
}