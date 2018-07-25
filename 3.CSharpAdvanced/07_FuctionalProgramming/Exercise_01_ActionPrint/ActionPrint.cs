using System;

namespace Exercise_01_ActionPrint
{
    public class ActionPrint
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        //Receives input from the console.
        public static void ReceiveInput()
        {
            var input = Console.ReadLine().Split(' ');
            Action<string[]> print = w => Console.WriteLine(string.Join("\n", w));
            ActionPrints(input,print);
        }

        //Prints the input on the console usint Action<>.
        public static void ActionPrints(string[] input, Action<string[]> print)
        {         
            print(input);
        }
    }
}