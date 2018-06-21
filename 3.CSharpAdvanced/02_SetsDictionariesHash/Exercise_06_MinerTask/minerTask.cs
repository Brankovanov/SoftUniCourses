using System;
using System.Collections.Generic;

namespace Exercise_06_MinerTask
{
    public class minerTask
    {
        public static void Main(string[] args)
        {
            ReceiveMiningInformation();
        }

        //Receives mining information from the console.
        static void ReceiveMiningInformation()
        {
            var miningRecord = new Dictionary<string, long>();
            var resource = Console.ReadLine();
            var quantity = Console.ReadLine();

            while (resource != "Stop")
            {
                RecordMiningInformation(resource, quantity, miningRecord);
                resource = Console.ReadLine();

                if (resource != "Stop")
                {
                    quantity = Console.ReadLine();
                }
            }

            PrintMiningRecord(miningRecord);
        }

        //Records mining information.
        static void RecordMiningInformation(string resource, string quantity, Dictionary<string, long> miningRecord)
        {
            if (miningRecord.ContainsKey(resource))
            {
                miningRecord[resource] += long.Parse(quantity);
            }
            else
            {
                miningRecord.Add(resource, long.Parse(quantity));
            }
        }

        //Prints the mining record.
        static void PrintMiningRecord(Dictionary<string, long> miningRecord)
        {
            foreach (var record in miningRecord)
            {
                Console.WriteLine($"{record.Key} -> {record.Value}");
            }
        }
    }
}