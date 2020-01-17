using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex_04_FastFood
{
    class StartUp
    {
        static void Main(string[] args)
        {
            ReceiveOrders();
        }

        private static void ReceiveOrders()
        {
            var availableFood = int.Parse(Console.ReadLine());

            var incommingOrders = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.None).Select(n => int.Parse(n)).ToArray();

            var orders = new Queue<int>(incommingOrders);

            ProcessOrders(orders, availableFood);
        }

        private static void ProcessOrders(Queue<int> orders, int availableFood)
        {
            FindBiggestOrder(orders);

            while (true)
            {
                if (orders.Peek() <= availableFood)
                {
                    availableFood = availableFood - orders.Dequeue();
                }
                else
                {
                    Console.WriteLine("Orders left: " + string.Join(" ", orders));
                    break;
                }

                if (orders.Count == 0)
                {
                    Console.WriteLine("Orders complete");
                    break;
                }
            }
        }

        private static void FindBiggestOrder(Queue<int> orders)
        {
            Console.WriteLine(orders.Max());
        }
    }
}