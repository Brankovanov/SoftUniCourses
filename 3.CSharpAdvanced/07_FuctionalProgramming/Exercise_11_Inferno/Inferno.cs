using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_11_Inferno
{
    public class Inferno
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        //Receive guestlist and commands from the console.
        public static void ReceiveInput()
        {
            var numList = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(n => int.Parse(n)).ToList();
            var commands = Console.ReadLine();
            var filters = new Dictionary<string, List<string>>();

            while (commands != "Forge")
            {
                ModifyFilters(commands, filters);
                commands = Console.ReadLine();
            }

            ApplyFilters(numList, filters);
            Print(numList);
        }

        //Executes the given commands.
        public static void ModifyFilters(string commands, Dictionary<string, List<string>> filters)
        {
            var temp = commands.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            var type = temp[0];
            var filter = temp[1];
            var checker = temp[2];

            Predicate<string> typeChecker = t => t.StartsWith("Exclude");

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
        public static void ApplyFilters(List<int> numList, Dictionary<string, List<string>> filters)
        {
            var leftIndexModfier = -1;
            var rightIndexModfier = 1;
            var modifier = 0;

            Predicate<string> left = a => a.EndsWith("Left");
            Predicate<string> right = e => e.StartsWith("Righ");
            Func<int, int, List<int>, List<int>> exclude = ExcludeNumbers;

            foreach (var filter in filters)
            {
                var conditions = filter.Key;

                foreach (var checker in filter.Value)
                {
                    var check = int.Parse(checker);

                    if (left(conditions))
                    {
                        numList = exclude(leftIndexModfier, check, numList);
                    }
                    else if (right(conditions))
                    {
                        numList = exclude(rightIndexModfier, check, numList);
                    }
                    else
                    {
                        numList = exclude(modifier, check, numList);
                    }
                }
            }
        }

        private static List<int> ExcludeNumbers(int modifier, int check, List<int> numList)
        {
            var sum = 0;

            for (var index = 0; index < numList.Count; index++)
            {
                sum = numList[index];

                if (index + modifier == -1)
                {
                    Remove(sum, check, index, numList);
                }
                else if (index + modifier == numList.Count)
                {
                    Remove(sum, check, index, numList);
                }
                else
                {
                    if (modifier < 0)
                    {
                        for (var innerIndex = index - 1; innerIndex >= 0; innerIndex += modifier)
                        {
                            sum += numList[innerIndex];
                            Remove(sum, check, index, numList);
                        }
                    }
                    else if (modifier > 0)
                    {
                        for (var innerIndex = index + 1; innerIndex < numList.Count; innerIndex += modifier)
                        {
                            sum += numList[innerIndex];
                            Remove(sum, check, index, numList);
                        }
                    }
                    else if (modifier == 0)
                    {
                        if (index - 1 >= 0 && index + 1 < numList.Count && numList[index] + numList[index - 1] + numList[index + 1] == check)
                        {
                            numList.RemoveAt(index);
                            index--;
                        }
                        else if (index - 1 < 0 && index + 1 < numList.Count && numList[index] + 0 + numList[index + 1] == check)
                        {
                            numList.RemoveAt(index);
                            index--;
                        }
                        else if (index - 1 >= 0 && index + 1 == numList.Count && numList[index] + numList[index - 1] + 0 == check)
                        {
                            numList.RemoveAt(index);
                            index--;
                        }
                    }
                }
            }

            return numList;
        }

        //Removes the numbers that are equal to the filter.
        public static void Remove(int sum, int check, int index, List<int> numList)
        {
            if (sum == check)
            {
                numList.RemoveAt(index);
                index--;
            }
        }

        //Prints the final quest list.
        public static void Print(List<int> numList)
        {
            if (numList.Count > 0)
            {
                Console.WriteLine(string.Join(" ", numList));
            }
        }
    }
}