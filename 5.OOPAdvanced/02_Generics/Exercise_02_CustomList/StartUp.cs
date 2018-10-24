using System;

namespace Exercise_02_CustomList
{
    public class StartUp
    {
        static void Main()
        {
            var newGenericList = new GenericList<string>();
            var interpreter = new CommandInterpreter();
            var sorter = new Sorter();

            ReceiveInput(newGenericList, interpreter, sorter);
        }

        //Receives input from the console.
        public static void ReceiveInput(GenericList<string> newGenericList, CommandInterpreter interpreter, Sorter sorter)
        {
            var input = Console.ReadLine();

            while (input != "END")
            {
                interpreter.Interpret(input, newGenericList,sorter);
                input = Console.ReadLine();
            }
            
        }
    }
}