using System;

namespace Exercise_01_HalloName
{
    public class helloName
    {
        public static void Main(string[] args)
        {
            var inputName = Console.ReadLine();

            PrintGreeting(inputName);
        }

        static void PrintGreeting (string inputName)
        {
            Console.WriteLine($"Hello, {inputName}!");
        }
    }
}
