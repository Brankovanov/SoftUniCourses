using System;

namespace _01.BashSoft
{
    public class InputReader
    {
        private const string terminateCommand = "quit";

        //Reads the incomming commands from the console.
        public static void StartReadingCommands()
        {
            OutputWriter.WriteMessage($"{SessionData.currentPath}>");
            var input = Console.ReadLine();
            input = input.Trim();

            while (input != terminateCommand)
            {
                CommandInterpreter.InterpretCommand(input);
                OutputWriter.WriteMessage($"{SessionData.currentPath}>");
                input = Console.ReadLine();
                input = input.Trim();
            }
        }
    }
}