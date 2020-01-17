using CommandPattern.Core.Contracts;
using System;

namespace CommandPattern
{
    public class Commands : ICommand

    {
        public void Execute(string[] args)
        {
            switch (args[0])
            {
                case "Hello":
                   Console.WriteLine( $"Hello, {args[1]}");
                    break;
                case "Exit":
                    Environment.Exit(1);
                    break;
                default:
                    Console.WriteLine($"Invali input!");
                    break;
            }

        }
    }
}
