using System;

namespace Exercise_02_Stack
{
    public class StartUp
    {
        static void Main()
        {
            ReceiveCommands();
        }

        //Receives commands from the console.
        public static void ReceiveCommands()
        {
            var stack = new CustomStack();
            var command = Console.ReadLine();

            while (command != "END")
            {
                InterpretsCommand(command, stack);
                command = Console.ReadLine();
            }

            Iterate(stack);
        }

        //Interprets the commands received from the console.
        public static void InterpretsCommand(string command, CustomStack stack)
        {
            if (command.StartsWith("Push"))
            {
                Push(stack, command);
            }
            else if (command.StartsWith("Pop"))
            {
                Pop(stack);
            }
        }

        //Pushes new elements in the custom stack.
        public static void Push(CustomStack stack, string command)
        {
            var temp = command.Substring(4, command.Length - 4).Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            stack.Push(temp);
        }

        //Pops new elements from the stack.
        public static void Pop(CustomStack stack)
        {
            stack.Pop();
        }

        //Itterates the custom stack after the end command.
        public static void Iterate(CustomStack stack)
        {
            Console.WriteLine((stack.Iterator()) + Environment.NewLine + stack.Iterator());
        }
    }
}