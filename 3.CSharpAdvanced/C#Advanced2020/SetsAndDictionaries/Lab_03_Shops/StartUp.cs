using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_03_Shops
{
    class StartUp
    {
        static void Main(string[] args)
        {
            ReceiveInformations();
        }

        private static void ReceiveInformations()
        {
            var information = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            var shopArchive = new Dictionary<string, Dictionary<string, double>>();

            while(information[0]!="Revision")
            {
                var shop = information[0];
                var product = information[1];
                var price = double.Parse(information[2]);

                if(shopArchive.ContainsKey(shop))
                {
                    if(shopArchive[shop].ContainsKey(product))
                    {
                        shopArchive[shop][product] = price;
                    }
                    else
                    {
                        shopArchive[shop].Add(product, price);
                    }
                }
                else
                {
                    shopArchive.Add(shop, new Dictionary<string, double>());
                    shopArchive[shop].Add(product, price);
                }

                information = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            }

            MakeRevision(shopArchive);
        }

        private static void MakeRevision(Dictionary<string, Dictionary<string, double>> shopArchive)
        {
            foreach(var sh in shopArchive.OrderBy(s=>s.Key))
            {
                Console.WriteLine($"{sh.Key.ToString()}->");

                foreach(var pr in sh.Value)
                {
                    Console.WriteLine($"Product: {pr.Key}, Price: {pr.Value}");
                }
            }
        }
    }
}
