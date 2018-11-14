using System;

namespace Exercise_01_ListIterator
{
    public class StartUp
    {
        public static void Main()
        {
            ReceiveCommands();
        }

        //Receives commands from the console.
        public static void ReceiveCommands()
        {
            var commands = Console.ReadLine();
            var iterator = new ListyIterator<string>();

            while (commands != "END")
            {
                ProccessCommands(commands, iterator);
                commands = Console.ReadLine();
            }
        }

        //Proccesses the different commands received from the comsole.
        public static void ProccessCommands(string commands, ListyIterator<string> iterator)
        {
            if (commands.StartsWith("Create"))
            {
                iterator.Elements.AddRange(commands.Substring(6, commands.Length - 6).Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
            }

            switch (commands)
            {
                case "HasNext":
                    HasNext(iterator);
                    break;

                case "Move":
                    MoveNext(iterator);
                    break;

                case "Print":
                    Print(iterator);
                    break;

                case "PrintAll":
                    PrintAll(iterator);
                    break;

                default:
                    break;
            }
        }

        //Check if there are more elements  in the collection.
        public static void HasNext(ListyIterator<string> iterator)
        {
            Console.WriteLine(iterator.HasNext().ToString());
        }

        //Move to the next element in the collection if it exists.
        public static void MoveNext(ListyIterator<string> iterator)
        {
            Console.WriteLine(iterator.MoveNext());
        }

        //Prints hte current element in the collection.
        public static void Print(ListyIterator<string> iterator)
        {
            Console.WriteLine(iterator.Print());
        }

        //Prints all the elements currently in the collection.
        public static void PrintAll(ListyIterator<string> iterator)
        {
            Console.WriteLine(iterator.PrintAll());
        }
    }
}