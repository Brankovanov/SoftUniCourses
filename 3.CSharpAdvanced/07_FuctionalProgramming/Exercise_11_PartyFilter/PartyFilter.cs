using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_11_PartyFilter
{
    public class PartyFilter
    {
        public static void Main(string[] args)
        {
            ReceiveGuests();
        }

        //Receive guestlist and commands from the console.
        public static void ReceiveGuests()
        {
            var guestList = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var commands = Console.ReadLine();
            var filters = new Dictionary<string, List<string>>();

            while (commands != "Print")
            {
                ModifyFilters(commands, filters);
                commands = Console.ReadLine();
            }

            ApplyFilters(guestList, filters);
            Print(guestList);
        }

        //Executes the given commands.
        public static void ModifyFilters(string commands, Dictionary<string, List<string>> filters)
        {
            var temp = commands.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            var type = temp[0];
            var filter = temp[1];
            var checker = temp[2];

            Predicate<string> typeChecker = t => t.StartsWith("Add");

            if (typeChecker(type) && !filters.ContainsKey(filter))
            {
                filters.Add(filter, new List<string>());
                filters[filter].Add(checker);
            }
            else if (typeChecker(type) && filters.ContainsKey(filter))
            {
                filters[filter].Add(checker);
            }
            else
            {
                filters[filter].Remove(checker);
            }
        }

        //Applies the filters.
        public static void ApplyFilters(List<string> guestList, Dictionary<string, List<string>> filters)
        {
            Predicate<string> actionType = a => a.EndsWith("With");
            Predicate<string> startEnd = e => e.StartsWith("Starts");
            Predicate<string> lenghtContains = l => l == ("Lenght");

            foreach (var filter in filters)
            {
                var conditions = filter.Key;

                foreach (var checker in filter.Value)
                {
                    if (actionType(conditions))
                    {
                        if (startEnd(conditions))
                        {
                            guestList.RemoveAll(r => r.StartsWith(checker));
                        }
                        else
                        {
                            guestList.RemoveAll(r => r.EndsWith(checker));
                        }
                    }
                    else if (lenghtContains(conditions))
                    {
                        guestList.RemoveAll(l => l.Length == int.Parse(checker));
                    }
                    else
                    {
                        guestList.RemoveAll(c => c.Contains(checker));
                    }
                }
            }
        }

        //Prints the final quest list.
        public static void Print(List<string> guestList)
        {
            if (guestList.Count > 0)
            {
                Console.WriteLine(string.Join(" ", guestList));
            }
        }
    }
}