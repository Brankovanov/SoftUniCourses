using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Exercise_05_AMinerTask
{
    public class aMinerTask
    {
        public static void Main(string[] args)
        {
            ProccessInputFile();
        }

        //Обработва информацията подадена във файла input.txt.
        static void ProccessInputFile()
        {
            List<string> resourceQuantity = File.ReadAllLines("./input.txt").ToList();
            CalculateQuantity(resourceQuantity);
            PrintOutput();
        }

        //Изчислява количеството добит ресурс.
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

            CreateOutput(mineReport);
        }

        //Създава файл output.txt.
        static void CreateOutput(Dictionary<string, int> mineReport)
        {
            File.Delete("./output.txt");

            foreach (var report in mineReport)
            {
                File.AppendAllText("./output.txt", report.Key + " => ");
                File.AppendAllText("./output.txt", report.Value.ToString() + "\r\n");
            }
        }

        //Принтира информацията във файла output.txt.
        static void PrintOutput()
        {
            Console.WriteLine(File.ReadAllText("./output.txt"));
        }
    }
}
