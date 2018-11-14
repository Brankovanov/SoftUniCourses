using System;

namespace Exercise_09_LinkedList
{
    public class StartUp
    {
        public static void Main()
        {
            ReceiveInput();
        }

        //Receives input from the console.
        public static void ReceiveInput()
        {
            var newCustomList = new CustomList();
            var numberOfCommands = int.Parse(Console.ReadLine());

            for (var index = 0; index < numberOfCommands; index++)
            {
                var command = Console.ReadLine().Split(' ');
                InterpretCommand(command, newCustomList);
            }

            PrintResult(newCustomList);
        }

        //Interpretting the commands.
        public static void InterpretCommand(string[] command, CustomList newCustomList)
        {
            var type = command[0];
            var element = int.Parse(command[1]);

            switch (type)
            {
                case "Add":
                    newCustomList.Add(element);
                    return;
                case "Remove":
                    newCustomList.Remove(element);
                    return;
            }
        }

        //Prints the final results.
        public static void PrintResult(CustomList newCustomList)
        {
            Console.WriteLine(newCustomList.Count);
            Console.WriteLine(newCustomList.ToString());
        }
    }
}