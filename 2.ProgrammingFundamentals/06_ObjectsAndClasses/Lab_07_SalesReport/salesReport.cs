using System;
using System.Collections.Generic;

namespace Lab_07_SalesReport
{
    public class salesReport
    {
        public static void Main(string[] args)
        {
            ReceiveLog();
        }

        //Получава информация за продажбите.
        static void ReceiveLog()
        {
            List<string> listOfTradeLogs = new List<string>();
            var numberOfLogs = int.Parse(Console.ReadLine());

            for (var index = 1; index <= numberOfLogs; index++)
            {
                listOfTradeLogs.Add(Console.ReadLine());
            }

            CreateSales(listOfTradeLogs);
        }

        //Извиква клас Sales, който създава индивидуална продажба.
        static void CreateSales(List<string> listOfTradeLogs)
        {
            SortedDictionary<string, Sale> listOfSales = new SortedDictionary<string, Sale>();

            foreach (var log in listOfTradeLogs)
            {
                var temp = log.Split(' ');

                if (!listOfSales.ContainsKey(temp[0]))
                {
                    Sale newSale = new Sale();
                    newSale.Town = temp[0];
                    newSale.Price = double.Parse(temp[2]) * double.Parse(temp[3]);

                    listOfSales.Add(temp[0], newSale);
                }
                else
                {
                    listOfSales[temp[0]].Price += double.Parse(temp[2]) * double.Parse(temp[3]);
                }
            }

            printOutput(listOfSales);
        }

        //Принтира общите продажби сортирани по град.
        static void printOutput(SortedDictionary<string, Sale> listOfSales)
        {
            foreach (var sale in listOfSales)
            {
                Console.Write(sale.Value.Town + " -> " + String.Format("{0:0.00}", sale.Value.Price));
                Console.WriteLine();
            }
        }
    }

    //Създава индивидуална продажба.
    public class Sale
    {
        private string town;
        private double price;

        public string Town
        {
            get
            {
                return this.town;
            }
            set
            {
                this.town = value;
            }
        }

        public double Price
        {
            get
            {
                return this.price;
            }
            set
            {
                this.price = value;
            }
        }

        public Sale()
        {
            this.Town = town;
            this.Price = price;
        }
    }
}