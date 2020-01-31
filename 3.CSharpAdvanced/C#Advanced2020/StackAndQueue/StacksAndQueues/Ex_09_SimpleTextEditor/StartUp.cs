using System;
using System.Collections.Generic;

namespace Ex_09_SimpleTextEditor
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var text = string.Empty;

            ReceiveCommands(text);
        }

        private static void ReceiveCommands(string text)
        {
            var numberOfCommands = int.Parse(Console.ReadLine());
            var stackOfTexts = new Stack<string>();

            for (var index = 0; index < numberOfCommands; index++)
            {
                var command = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.None);

                switch (command[0])
                {
                    case "1":

                        var str = command[1];
                        AppendString(str, stackOfTexts);
                        break;

                    case "2":
                        var numberOfElements = int.Parse(command[1]);
                        EraseElements(numberOfElements, stackOfTexts);
                        break;

                    case "3":

                        var ind = int.Parse(command[1]);
                        FindElement(ind, stackOfTexts);

                        break;

                    case "4":
                        Undo(stackOfTexts);
                        break;
                }
            }
        }

        private static void Undo(Stack<string> stackOfTexts)
        {
            stackOfTexts.Pop();
        }

        private static void FindElement(int ind, Stack<string> stackOfTexts)
        {
            Console.WriteLine(stackOfTexts.Peek()[ind - 1]);
        }

        private static void EraseElements(int numberOfElements, Stack<string> stackOfTexts)
        {
            stackOfTexts.Push(stackOfTexts.Peek().Remove(stackOfTexts.Peek().Length - numberOfElements));
        }

        private static void AppendString(string str, Stack<string> stackOfString)
        {
            var text = string.Empty;

            if (stackOfString.Count > 0)
            {
                text = stackOfString.Peek() + str;
                stackOfString.Push(text);
            }
            else
            {
                stackOfString.Push(str);
            }

        }
    }
}
