using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_05_ArrayManipulator
{
    public class arrayManipulator
    {
        public static void Main(string[] args)
        {
            Input();
        }

        static void Input()
        {
            var input = Console.ReadLine();
            var intList = input.Split(' ').Select(x => int.Parse(x)).ToList();

            InputCommands(intList);
        }

        static void InputCommands(List<int> intList)
        {
            List<string> commandList = new List<string>();

            var command = Console.ReadLine();
            commandList.Add(command);

            do
            {
                command = Console.ReadLine();
                commandList.Add(command);
            }
            while (command != "print");

            DoCommands(commandList, intList);
        }

        static void DoCommands(List<string> commandList, List<int> intList)
        {
            List<string> comm = new List<string>();

            foreach (var command in commandList)
            {
                comm = command.Split(' ').ToList();

                if (comm[0].Equals("add"))
                {
                    Add(intList, comm);
                }
                else if (comm[0].Equals("addMany"))
                {
                    AddRange(intList, comm);
                }
                else if (comm[0].Equals("contains"))
                {
                    Contains(intList, comm);
                }
                else if (comm[0].Equals("remove"))
                {
                    Remove(intList, comm);
                }
                else if (comm[0].Equals("shift"))
                {
                    Shift(intList, comm);
                }
                else if (comm[0].Equals("sumPairs"))
                {
                    SumPairs(intList, comm);
                }
                else if (comm[0].Equals("print"))
                {
                    Print(intList);
                }

                comm.RemoveRange(0, comm.Count);
            }
        }

        static void Add(List<int> intList, List<string> comm)
        {
            intList.Insert(int.Parse(comm[1]), int.Parse(comm[2]));
        }

        static void AddRange(List<int> intList, List<string> comm)
        {
            for (var i = comm.Count - 1; i >= 2; i--)
            {
                intList.Insert(int.Parse(comm[1]), int.Parse(comm[i]));
            }
        }

        static void Contains(List<int> intList, List<string> comm)
        {
            if (intList.Contains(int.Parse(comm[1])))
            {
                for (var i = 0; i <= intList.Count - 1; i++)
                {
                    if (intList[i] == int.Parse(comm[1]))
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else
            {
                Console.WriteLine(-1);
            }
        }

        static void Remove(List<int> intList, List<string> comm)
        {
            intList.RemoveAt(int.Parse(comm[1]));
        }

        static void Shift(List<int> intList, List<string> comm)
        {
            var shiftRange = int.Parse(comm[1]);
            var lastOne = intList[0];

            for (var shift = 0; shift <= shiftRange - 1; shift++)
            {
                int firstElement = intList[0];

                for (int index = 1; index < intList.Count; index++)
                {
                    intList[index - 1] = intList[index];
                }

                intList[intList.Count - 1] = firstElement;
            }
        }

        static void SumPairs(List<int> intList, List<string> comm)
        {
            if (intList.Count() % 2 == 0)
            {
                for (int index = 0; index < intList.Count - 1; index += 2)
                {
                    intList[index] += intList[index + 1];
                    intList[index + 1] = -1;
                }
                intList.RemoveAll(x => x == -1);
            }
            else
            {
                for (int index = 0; index < intList.Count - 2; index += 2)
                {
                    intList[index] += intList[index + 1];
                    intList[index + 1] = -1;
                }
                intList.RemoveAll(x => x == -1);
            }
        }

        static void Print(List<int> intList)
        {
            var count = 0;
            Console.Write("[");

            foreach (var num in intList)
            {
                Console.Write(num);

                if (count < intList.Count - 1)
                {
                    Console.Write(", ");
                    count++;
                }
            }

            Console.Write("]");
        }
    }
}