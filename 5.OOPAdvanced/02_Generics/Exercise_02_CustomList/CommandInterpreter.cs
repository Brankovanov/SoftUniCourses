using System;
using System.Linq;

namespace Exercise_02_CustomList
{
    public class CommandInterpreter
    {
        public void Interpret(string input, GenericList<string> newGenericList,Sorter sorter)
        {
            if (input.StartsWith("Add"))
            {
                var temp = input.Split(' ').ToArray();
                var element = temp[1];
                newGenericList.Add(element);
            }
            else if (input.StartsWith("Remove"))
            {
                var temp = input.Split(' ').ToArray();
                var index = int.Parse(temp[1]);
                newGenericList.Remove(index);
            }
            else if (input.StartsWith("Contains"))
            {
                var temp = input.Split(' ').ToArray();
                var element = temp[1];
                Console.WriteLine(newGenericList.Contains(element));
            }
            else if (input.StartsWith("Swap"))
            {
                var temp = input.Split(' ').ToArray();
                var firstIndex = int.Parse(temp[1]);
                var secondIndex = int.Parse(temp[2]);
                newGenericList.Swap(firstIndex, secondIndex);
            }
            else if (input.StartsWith("Greater"))
            {
                var temp = input.Split(' ').ToArray();
                var element = temp[1];
                Console.WriteLine(newGenericList.CountGreaterThan(element));
            }
            else if (input.StartsWith("Max"))
            {
               Console.WriteLine(newGenericList.Max());
            }
            else if (input.StartsWith("Min"))
            {
               Console.WriteLine(newGenericList.Min());
            }
            else if (input.StartsWith("Print"))
            {
                foreach (var entity in newGenericList.List)
                {
                    Console.WriteLine(entity);
                }
            }
            else if(input.StartsWith("Sort"))
            {
                sorter.Sort(newGenericList);
            }
        }

    }
}