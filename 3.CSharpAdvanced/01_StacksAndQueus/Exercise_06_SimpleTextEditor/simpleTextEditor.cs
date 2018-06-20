using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_06_SimpleTextEditor
{
    public class simpleTextEditor
    {
        public static void Main(string[] args)
        {
            ReceiveCommands();
        }

        //Receives commands from the console.
        static void ReceiveCommands()
        {
            var finalString = new StringBuilder();
            var previousversion = new Stack<string>();
            var command = string.Empty;
            var numberOfCommands = int.Parse(Console.ReadLine());

            for (var index = 1; index <= numberOfCommands; index++)
            {
                command = Console.ReadLine();
                ExecuteCommand(finalString, command, previousversion);
            }
        }

        //Executes the received commands.
        static void ExecuteCommand(StringBuilder finalString, string command, Stack<string> previousversion)
        {
            var temp = command.Split(' ');
            var type = temp[0];
            var argument = string.Empty;

            if (type.Equals("1"))
            {
                argument = temp[1];
                AppendText(finalString, argument, previousversion);
            }
            else if (type.Equals("2"))
            {
                argument = temp[1];
                Remove(finalString, argument, previousversion);
            }
            else if (type.Equals("3"))
            {
                argument = temp[1];
                PrintElement(finalString, argument);
            }
            else if (type.Equals("4"))
            {
                finalString.Clear();
                finalString.Append(previousversion.Pop());
            }
        }

        //Appends to the text.
        static void AppendText(StringBuilder finalString, string argument, Stack<string> previousversion)
        {
            previousversion.Push(finalString.ToString());
            finalString = finalString.Append(argument);
        }

        //Remove parts of the string.
        static void Remove(StringBuilder finalString, string argument, Stack<string> previousversion)
        {
            if (int.Parse(argument) > finalString.Length)
            {
                previousversion.Push(finalString.ToString());
                finalString = finalString.Remove(0, int.Parse(argument));
            }
            else
            {
                previousversion.Push(finalString.ToString());
                finalString = finalString.Remove((finalString.Length) - int.Parse(argument), int.Parse(argument));
            }
        }

        //Prints element.
        static void PrintElement(StringBuilder finalString, string argument)
        {
            Console.WriteLine(finalString[int.Parse(argument) - 1]);
        }
    }
}