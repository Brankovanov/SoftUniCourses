using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex_03_MaxAndMinElements
{
    class StartUp
    {
        static void Main(string[] args)
        {
            ReceiveCommads();
        }

        public static void ReceiveCommads()
        {
            var stackToManipulate = new Stack<int>();

            var numberOfCommands = int.Parse(Console.ReadLine());

            for (var index = 0; index < numberOfCommands; index++)
            {
                var command = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.None).Select(n => int.Parse(n)).ToArray();

                switch (command[0])
                {
                    case 1:
                        PushElement(stackToManipulate, command[1]);
                        break;

                    case 2:
                        PopElement(stackToManipulate);
                        break;

                    case 3:
                        PrintMax(stackToManipulate);
                        break;

                    case 4:
                        PrintMin(stackToManipulate);
                        break;
                }
            }

            PrintStack(stackToManipulate);
        }

        public static void PrintStack(Stack<int> stackToManipulate)
        {
            var output = string.Empty;

            while (stackToManipulate.Count > 0)
            {
                output += stackToManipulate.Pop() + ", ";
            }

            Console.WriteLine(output.TrimEnd(',', ' '));
        }

        public static void PrintMin(Stack<int> stackToManipulate)
        {
            if (stackToManipulate.Count > 0)
            {
                Console.WriteLine(stackToManipulate.Min());
            }
        }

        public static void PrintMax(Stack<int> stackToManipulate)
        {
            if (stackToManipulate.Count > 0)
            {
                Console.WriteLine(stackToManipulate.Max());
            }
        }

        public static void PopElement(Stack<int> stackToManipulate)
        {
            if (stackToManipulate.Count > 0)
            {
                if (stackToManipulate.Count > 0)
                {
                    stackToManipulate.Pop();
                }
            }
        }

        public static void PushElement(Stack<int> stackToManipulate, int element)
        {
            stackToManipulate.Push(element);
        }
    }
}
