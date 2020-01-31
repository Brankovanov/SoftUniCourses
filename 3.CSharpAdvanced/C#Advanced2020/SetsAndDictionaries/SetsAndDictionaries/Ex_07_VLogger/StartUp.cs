using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex_07_VLogger
{
    class StartUp
    {
        static void Main(string[] args)
        {
            ReceiveCommands();
        }

        private static void ReceiveCommands()
        {
            var commands = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var vlogger = commands[0];
            var command = string.Empty;
            var entry = string.Empty;

            var vloggerArchive = new Dictionary<string, List<string>[]>();

            while (vlogger != "Statistics")
            {
                command = commands[1];
                entry = string.Join(null, command, 2, command.Length - 2);
                switch (command)
                {
                    case "joined":
                        Joint(vlogger, vloggerArchive);
                        break;
                    case "followed":
                        Follow(vlogger, vloggerArchive, entry);
                        break;
                }

                commands = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                vlogger = commands[0];

            }

            PrintStatistics(vloggerArchive);
        }

        private static void PrintStatistics(Dictionary<string, List<string>[]> vloggerArchive)
        {
            var counter = 1;
            Console.WriteLine($"The V-Logger has a total of {vloggerArchive.Count} vloggers in its logs.");
       
            foreach (var vlo in vloggerArchive.OrderByDescending(v => v.Value[0].Count).ThenBy(v => v.Value[1].Count))
            {
                if (counter == 1)
                {
                    Console.WriteLine($"{counter}. {vlo.Key} : " +
                    $"{vlo.Value[0].Count} followers," +
                $"{vlo.Value[1].Count} following" +
                $"{string.Join($"{Environment.NewLine}* ", vlo.Value[0].OrderBy(c => c))}");
                }
                else
                {
                    Console.WriteLine($"{counter}. {vlo.Key} : " +
                 $"{vlo.Value[0].Count} followers," +
                 $"{vlo.Value[1].Count} following");

                }

                counter++;
            }


        }

        private static void Follow(string vlogger, Dictionary<string, List<string>[]> vloggerArchive, string entry)
        {
            if ((vloggerArchive.ContainsKey(vlogger) && vloggerArchive.ContainsKey(entry))
                && (vlogger != entry)
                && !vloggerArchive[vlogger][0].Contains(entry))
            {
                vloggerArchive[vlogger][0].Add(entry);
                vloggerArchive[entry][1].Add(vlogger);
            }
        }

        private static void Joint(string vlogger, Dictionary<string, List<string>[]> vloggerArchive)
        {
            if (!vloggerArchive.ContainsKey(vlogger))
            {
                vloggerArchive.Add(vlogger, new List<string>[2]);
                vloggerArchive[vlogger][0] = new List<string>();
                vloggerArchive[vlogger][1] = new List<string>();
            }
        }
    }
}
