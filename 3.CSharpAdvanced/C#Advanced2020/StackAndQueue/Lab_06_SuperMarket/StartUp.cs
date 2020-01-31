using System;
using System.Collections.Generic;

namespace Lab_06_SuperMarket
{
    class StartUp
    {
        static void Main(string[] args)
        {
            ReceiveCommand();
        }

        public static void ReceiveCommand()
        {
            var command = Console.ReadLine();
            var clientQueue = new Queue<string>();

            while (command != "End")
            {
                switch (command)
                {
                    case "Paid":
                        PrintPaid(clientQueue);
                        break;
                    default:
                        AddClients(clientQueue, command);
                        break;
                }

                command = Console.ReadLine();
            }

            PrintResults(clientQueue);
        }

        public static void AddClients(Queue<string> clientQueue, string command)
        {
            clientQueue.Enqueue(command);
        }

        public static void PrintPaid(Queue<string> clientQueue)
        {
            do
            {
                Console.WriteLine(clientQueue.Dequeue());
            }
            while (clientQueue.Count > 0);
        }

        public static void PrintResults(Queue<string> clientQueu)
        {
            Console.WriteLine(clientQueu.Count + " people remaining.");
        }
    }
}
