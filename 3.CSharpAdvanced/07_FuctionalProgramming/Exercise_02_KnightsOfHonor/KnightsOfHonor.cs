using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_02_KnightsOfHonor
{
    public class KnightsOfHonor
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        //Receives input from the console.
        public static void ReceiveInput()
        {
            var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            Action<List<string>> print = w => w.ForEach(n => Console.WriteLine("Sir " + n));
            ActionPrints(input,print);
        }

        //Prints the input on the console usint Action<>.
        public static void ActionPrints(List<string> input, Action<List<string>> print)
        { 
            print(input);
        }
    }
}