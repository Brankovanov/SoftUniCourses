using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_02_ChangeList
{
    public class changeList
    {
        public static void Main(string[] args)
        {
            List<string> listOfCommands = new List<string>();

            Input(listOfCommands);
        }

        static void Input(List<string> listOfCommands)
        {
            var input = Console.ReadLine();

            ReceiveCommands(input, listOfCommands);
        }

        static void ReceiveCommands(string input, List<string> listOfCommands)
        {
            var command = Console.ReadLine();

            if (command.Contains("Delete") || command.Contains("Insert"))
            {
                listOfCommands.Add(command);
                command = string.Empty;
                ReceiveCommands(input, listOfCommands);             
            }
            else if (command == "Odd" || command == "Even")
            {
                listOfCommands.Add(command);
                CreateList(input, listOfCommands);  
            }
        }

        static void CreateList(string input, List<string> listOfCommands)
        {
            List<int> listOfNumbers = new List<int>();
            listOfNumbers = input.Split(' ').Select(x => int.Parse(x)).ToList();

            ProccessListOfNumbers(listOfCommands, listOfNumbers);
        }


        static void ProccessListOfNumbers(List<string> listOfCommands, List<int> listOfNumbers)
        {
            foreach (var command in listOfCommands)
            {
                var temp = command.Split(' ').ToList();

                if (temp[0].Equals("Delete"))
                {
                    listOfNumbers.RemoveAll(z => z == int.Parse(temp[1]));
                }
                else if (temp[0].Equals("Insert"))
                {
                    listOfNumbers.Insert(int.Parse(temp[2]), int.Parse(temp[1]));
                }
                else if (temp[0].Equals("Odd"))
                {
                    PrintOdd(listOfNumbers);
                }
                else if (temp[0].Equals("Even"))
                {
                    PrintEven(listOfNumbers);
                }
            }
        }

        static void PrintEven(List<int> listOfNumbers)
        {
            foreach (var num in listOfNumbers)
            {
                if (num % 2 == 0)
                {
                    Console.Write(num + " ");
                }
            }
        }

        static void PrintOdd(List<int> listOfNumbers)
        {
            foreach (var num in listOfNumbers)
            {
                if (num % 2 != 0)
                {
                    Console.Write(num + " ");
                }
            }
        }
    }
}
