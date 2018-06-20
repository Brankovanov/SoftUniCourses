using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_02_StackOperations
{
    public class stackOperations
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        //Receives input from the console.
        static void ReceiveInput()
        {
            var parameters = Console.ReadLine();
            var elements = Console.ReadLine();

            ProcessInput(parameters, elements);
        }

        //Process the input from the console.
        static void ProcessInput(string parameters, string elements)
        {
            var stackParameters = parameters.Split(' ').Select(n => int.Parse(n)).ToArray();
            var stackElements = elements.Split(' ').Select(n => int.Parse(n)).ToArray();

            var elementsToPush = stackParameters[0];
            var elementsToPop = stackParameters[1];
            var elementToSeek = stackParameters[2];

            ExecuteCommands(elementsToPush, elementsToPop, elementToSeek, stackElements);
        }

        //Executes the commands.
        static void ExecuteCommands(int elementsToPush, int elementsToPop, int elementToSeek, int[] stackElements)
        {
            var stack = new Stack<int>();
            var output = string.Empty;

            for (var index = 0; index <= elementsToPush - 1; index++)
            {
                stack.Push(stackElements[index]);
            }

            for (var popIndex = 1; popIndex <= elementsToPop; popIndex++)
            {
                if (stack.Count > 0)
                {
                    stack.Pop();
                }
                else
                {
                    break;
                }
            }

            if (stack.Contains(elementToSeek))
            {
                output = "true";
            }
            else
            {
                if (stack.Count > 0)
                {
                    output = stack.Min().ToString();
                }
                else
                {
                    output = "0";
                }
            }

            PrintOutput(output);
        }

        //Print the required answer.
        static void PrintOutput(string output)
        {
            Console.WriteLine(output);
        }
    }
}