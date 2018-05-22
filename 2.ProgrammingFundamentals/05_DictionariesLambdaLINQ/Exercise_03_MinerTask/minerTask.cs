using System;
using System.Collections.Generic;

namespace Exercise_03_MinerTask
{
    public class minerTask
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        static void ReceiveInput()
        {
            List<string> resourceQuantity = new List<string>();

            var input = Console.ReadLine();
            resourceQuantity.Add(input);

            while (input != "stop")
            {
                input = Console.ReadLine();
                resourceQuantity.Add(input);
            }

            CalculateQuantity(resourceQuantity);
        }

        static void CalculateQuantity(List<string> resourceQuantity)
        {
            Dictionary<string, int> mineReport = new Dictionary<string, int>();
            resourceQuantity.Remove("stop");

            for (var index = 0; index <= resourceQuantity.Count - 1; index += 2)
            {
                if (mineReport.ContainsKey(resourceQuantity[index]))
                {
                    mineReport[resourceQuantity[index]] += int.Parse(resourceQuantity[index + 1]);
                }
                else
                {
                    mineReport.Add(resourceQuantity[index], int.Parse(resourceQuantity[index + 1]));
                }
            }

            PrintReport(mineReport);
        }

        static void PrintReport(Dictionary<string, int> mineReport)
        {
            foreach (var report in mineReport)
            {
                Console.WriteLine(report.Key + " -> " + report.Value);
            }
        }
    }
}