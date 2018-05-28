using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_07_CalculateBill
{
    public class calculateBill
    {
        public static void Main(string[] args)
        {
            ReceiveMenu();
        }

        //Получава информация за менюто от конзолата.
        static void ReceiveMenu()
        {
            Dictionary<string, double> menu = new Dictionary<string, double>();
            List<string> temp = new List<string>();
            var numberOfItems = int.Parse(Console.ReadLine());
            var products = string.Empty;
            var prices = 0.0;

            for (var item = 1; item <= numberOfItems; item++)
            {
                temp = Console.ReadLine().Split('-').ToList();
                products = temp[0];
                prices = double.Parse(temp[1]);

                if (menu.ContainsKey(products))
                {
                    menu[products] = prices;
                }
                else
                {
                    menu.Add(products, prices);
                }

                products = string.Empty;
                prices = 0.0;
                temp.Clear();
            }

            ReceiveOrders(menu);
        }

        //Получава информация за поръчките от конзолата.
        static void ReceiveOrders(Dictionary<string, double> menu)
        {
            var name = string.Empty;
            var product = string.Empty;
            var quantity = 0;
            var personalOrder = string.Empty;
            List<string> temp = new List<string>();
            SortedDictionary<string, Dictionary<string, int>> listOfOrders = new SortedDictionary<string, Dictionary<string, int>>();

            while (personalOrder != "end of clients")
            {
                personalOrder = Console.ReadLine();
                temp = personalOrder.Split('-', ',').ToList();

                try
                {
                    name = temp[0];
                    product = temp[1];
                    quantity = int.Parse(temp[2]);

                    if (!listOfOrders.ContainsKey(name))
                    {
                        listOfOrders[name] = new Dictionary<string, int>();
                    }

                    if (!listOfOrders[name].ContainsKey(product) && menu.ContainsKey(product))
                    {
                        listOfOrders[name][product] = quantity;
                    }
                    else if (listOfOrders[name].ContainsKey(product) && menu.ContainsKey(product))
                    {
                        listOfOrders[name][product] += quantity;
                    }

                    name = string.Empty;
                    product = string.Empty;
                    quantity = 0;
                    temp.Clear();
                }
                catch (ArgumentOutOfRangeException)
                {
                    listOfOrders.Remove("end of clients");
                }
            }

            CreateOrder(menu, listOfOrders);
        }

        //Създава обект Order, който съдържа информация за менюто и поръчките.
        static void CreateOrder(Dictionary<string, double> menu, SortedDictionary<string, Dictionary<string, int>> listOfOrders)
        {
            Order finalOrder = new Order();
            finalOrder.BarCard = menu;
            finalOrder.ClientsOrders = listOfOrders;

            Calculate(finalOrder);
        }

        //Извиква метод CalculateBill от обекта finalOrder, която изчислява сметката.
        static void Calculate(Order finalOrder)
        {
            finalOrder.CalculateBill();
        }
    }

    //Клас Order.
    public class Order
    {
        private Dictionary<string, double> barCard;
        private SortedDictionary<string, Dictionary<string, int>> clientsOrders;

        public Dictionary<string, double> BarCard
        {
            get
            {
                return this.barCard;
            }
            set
            {
                this.barCard = value;
            }
        }

        public SortedDictionary<string, Dictionary<string, int>> ClientsOrders
        {
            get
            {
                return this.clientsOrders;
            }
            set
            {
                this.clientsOrders = value;
            }
        }

        //Изчислява и отоечатва индивидуалните сметки на клиентите и общата сметка.
        public void CalculateBill()
        {
            var totalBill = 0.0;
            var bill = 0.0;
            var counter = 0;

            foreach (var client in clientsOrders)
            {
                foreach (var ord in client.Value)
                {
                    if (barCard.ContainsKey(ord.Key))
                    {
                        Console.WriteLine(client.Key);
                        break;
                    }
                }

                foreach (var order in client.Value)
                {
                    if (barCard.ContainsKey(order.Key))
                    {
                        bill += order.Value * barCard[order.Key];
                        Console.WriteLine("-- " + order.Key + " - " + order.Value);

                        if (counter == client.Value.Count - 1)
                        {
                            Console.WriteLine("Bill: " + String.Format("{0:0.00}", bill));
                        }                   
                    }

                    counter++;
                }

                totalBill += bill;
                counter = 0;
                bill = 0.0;
            }

            Console.WriteLine("Total bill: " + String.Format("{0:0.00}", totalBill));
        }
    }
}