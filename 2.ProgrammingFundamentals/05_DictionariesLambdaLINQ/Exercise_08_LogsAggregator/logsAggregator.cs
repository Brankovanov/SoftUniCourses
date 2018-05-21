using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_08_LogsAggregator
{
    public class logsAggregator
    {
        public static void Main(string[] args)
        {
            ReceiveLogs();
        }

        static void ReceiveLogs()
        {
            List<string> listOfLogs = new List<string>();

            var numberOfLogs = int.Parse(Console.ReadLine());

            for (var index = 1; index <= numberOfLogs; index++)
            {
                listOfLogs.Add(Console.ReadLine());
            }

            ProccessLogs(listOfLogs);
        }

        static void ProccessLogs(List<string> listOfLogs)
        {
            SortedDictionary<string, SortedDictionary<string, int>> dictionaryOfLogs = new SortedDictionary<string, SortedDictionary<string, int>>();
            List<string> temp = new List<string>();
            var ip = string.Empty;
            var name = string.Empty;
            var duration = 0;

            foreach (var log in listOfLogs)
            {
                temp = log.Split(' ').ToList();
                ip = temp[0];
                name = temp[1];
                duration = int.Parse(temp[2]);

                CreateDictionary(ip, name, duration, dictionaryOfLogs);

                ip = string.Empty;
                name = string.Empty;
                duration = 0;
            }

            Print(dictionaryOfLogs);
        }

        static void CreateDictionary(string ip, string name, int duration, SortedDictionary<string, SortedDictionary<string, int>> dictionaryOfLogs)
        {
            if (!dictionaryOfLogs.ContainsKey(name))
            {
                dictionaryOfLogs[name] = new SortedDictionary<string, int>();
            }

            if (!dictionaryOfLogs[name].ContainsKey(ip))
            {
                dictionaryOfLogs[name][ip] = duration;
            }
            else
            {
                dictionaryOfLogs[name][ip] += duration;
            }
        }

        static void Print(SortedDictionary<string, SortedDictionary<string, int>> dictionaryOfLogs)
        {
            var totalTime = 0;

            foreach (var log in dictionaryOfLogs)
            {
                Console.Write(log.Key + ": ");

                foreach (var duration in log.Value)
                {
                    totalTime += duration.Value;
                }

                Console.Write(totalTime + " ");
                totalTime = 0;
                Console.Write("[");

                foreach (var ip in log.Value)
                {
                    if (ip.Key != log.Value.Keys.Last())
                    {
                        Console.Write(ip.Key + ", ");
                    }
                    else
                    {
                        Console.Write(ip.Key);
                    }
                }

                Console.Write("]");
                Console.WriteLine();
            }
        }
    }
}