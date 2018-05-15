using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_03_SearchForANumber
{
    public class searchForANumber
    {
        public static void Main(string[] args)
        {
            Input();
        }

        static void Input()
        {
            var numbers = Console.ReadLine();
            var commands = Console.ReadLine();

            CreateLists(numbers, commands);
        }

        static void CreateLists(string numbers, string commands)
        {
            List<int> numbersList = new List<int>();
            List<int> commandList = new List<int>();

            numbersList = numbers.Split(' ').Select(x => int.Parse(x)).ToList();
            commandList = commands.Split(' ').Select(y => int.Parse(y)).ToList();

            SearchList(numbersList, commandList);
        }

        static void SearchList(List<int> numbersList, List<int> commandList)
        {
            var index = commandList[0];
            var count = Math.Abs((commandList[0]) - numbersList.Count);

            numbersList.RemoveRange(index, count);

            index = 0;
            count = 0;

            numbersList.RemoveRange(0, commandList[1]);

            Print(numbersList, commandList);
        }

        static void Print(List<int> numbersList, List<int> commandList)
        {
            if (numbersList.Contains(commandList[2]))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
