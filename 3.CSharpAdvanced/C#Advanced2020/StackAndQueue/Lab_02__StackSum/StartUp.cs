using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_02__StackSum
{
    class StartUp
    {
        static void Main()
        {
            ReceiveArray();
        }

        public static void ReceiveArray()
        {
            var intArr = Console.ReadLine().Split(' ', StringSplitOptions.None).Select(n => int.Parse(n)).ToArray();

            CreateStack(intArr);

        }

        public static void CreateStack(int[] intArr)
        {
            var intStack = new Stack<int>();

            foreach (var n in intArr)
            {
                intStack.Push(n);
            }

            ReceiveCommands(intStack);
        }

        public static void ReceiveCommands(Stack<int> intStack)
        {
            var input = Console.ReadLine().Split(' ', StringSplitOptions.None).ToArray();

            var command = input[0].ToLower();
            var sum = 0;

            while (command != "end")
            {

                switch (command)
                {
                    case "add":
                        AddIntegers(input, intStack);
                        break;
                    case "remove":
                        RemoveIntegers(input, intStack);
                        break;
                }

                input = Console.ReadLine().Split(' ', StringSplitOptions.None).ToArray();
                command = input[0].ToLower();
            }

            sum = CalculateSum(sum, intStack);
            Print(sum);

        }

        public static void AddIntegers(string[] input, Stack<int> intStack)
        {
            for (var index = 1; index < input.Length; index++)
            {
                intStack.Push(int.Parse(input[index]));
            }
        }

        public static void RemoveIntegers(string[] input, Stack<int> intStack)
        {
            if (int.Parse(input[1]) <= intStack.Count)
            {
                for (var index = 1; index <= int.Parse(input[1]); index++)
                {
                    intStack.Pop();
                }
            }
        }

        public static int CalculateSum(int sum, Stack<int> intStack)
        {
            while (intStack.Count > 0)
            {
                sum += intStack.Pop();
            }

            return sum;
        }

        public static void Print(int sum)
        {
            Console.WriteLine("Sum: "+sum);
        }
    }
}
