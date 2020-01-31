using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_05_FilterByAge
{
    class StartUp
    {
        static void Main(string[] args)
        {
            ReceiveInformation();
        }

        private static void ReceiveInformation()
        {
            var numberOfEntries = int.Parse(Console.ReadLine());
            var archive = new Dictionary<string, int>();
            var entry = new string[2];

            for (var index = 0; index < numberOfEntries; index++)
            {
                entry = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

                if (archive.ContainsKey(entry[0]))
                {
                    archive[entry[0]]=int.Parse(entry[1]);
                }
                else
                {
                    archive.Add(entry[0], int.Parse(entry[1]));
                }
            }

            ReceiveCommand(archive);
        }

        private static void ReceiveCommand(Dictionary<string, int> archive)
        {
            var condition = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var format = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            DoCommands(condition, age, format, archive);
        }

        private static void DoCommands(string condition, int age, string[] format, Dictionary<string, int> archive)
        {
            var name = string.Empty;
            var years = string.Empty;

            if(condition=="younger")
            {
                foreach (var entry in archive.Where(a => a.Value <= age))
                {
                    Print(format, entry);                  
                }
            }
            else
            {
                foreach (var entry in archive.Where(a => a.Value >= age))
                {
                    Print(format, entry);
                }
            }            
        }

        private static void Print(string[] format, KeyValuePair<string, int> entry)
        {
            if (format.Length == 2)
            {
                Console.WriteLine($"{entry.Key} - {entry.Value}");
            }
            else if (format[0] == "name")
            {
                Console.WriteLine($"{entry.Key}");
            }
            else if (format[0] == "age")
            {
                Console.WriteLine($"{entry.Value}");
            }
        }
    }
}
