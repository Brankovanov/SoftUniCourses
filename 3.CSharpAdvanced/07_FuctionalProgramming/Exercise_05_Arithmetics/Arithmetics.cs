using System;
using System.Linq;

namespace Exercise_05_Arithmetics
{
    public class Arithmetics
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        //Receives input from the console.
        public static void ReceiveInput()
        {
            var numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(n => int.Parse(n)).ToArray();
            var commands = Console.ReadLine();

            while (commands != "end")
            {
                ExecuteCommand(commands, numbers);
                commands = Console.ReadLine();
            }
        }

        //Executes the received commands;
        public static void ExecuteCommand(string commands, int[] numbers)
        {
            Func<int[], int, int[]> calculator = Calculate;
            var modifier = 0;

            switch (commands)
            {
                case "add":
                    modifier = 1;
                    calculator(numbers, modifier);
                    break;
                case "multiply":
                    modifier = 2;
                    calculator(numbers, modifier);
                    break;
                case "subtract":
                    modifier = -1;
                    calculator(numbers, modifier);
                    break;
                case "print":
                    Print(numbers);
                    break;
            }
        }

        //Executes the received commands.
        private static int[] Calculate(int[] numbers, int modifier)
        {
            if (modifier == 2)
            {
                for (var index = 0; index < numbers.Length; index++)
                {
                    numbers[index] = numbers[index] * modifier;
                }
            }
            else
            {
                for (var index = 0; index < numbers.Length; index++)
                {
                    numbers[index] = numbers[index] + modifier;
                }
            }

            return numbers;
        }

        //Prints the collection of numbers.
        public static void Print(int[] numbers)
        {
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}