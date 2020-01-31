using System;
using System.Collections.Generic;

namespace Ex_08_BalancedParenthesis
{
    class StartUp
    {
        static void Main(string[] args)
        {
            ReceiveInput();
        }

        private static void ReceiveInput()
        {
            var input = Console.ReadLine();

            FindParenthesis(input);
        }

        private static void FindParenthesis(string input)
        {
            var stackP = new Stack<char>();

            foreach (var ch in input)
            {
                if (stackP.Count == 0)
                {
                    stackP.Push(ch);
                }
                else if (stackP.Count > 0 &&
                     (ch == '(' && stackP.Peek() == ')') ||
                     (ch == '[' && stackP.Peek() == ']') ||
                     (ch == '{' && stackP.Peek() == '}') ||
                     (ch == ')' && stackP.Peek() == '(') ||
                     (ch == ']' && stackP.Peek() == '[') ||
                     (ch == '}' && stackP.Peek() == '{'))
                     {
                        stackP.Pop();
                     }
                else
                { 
                    stackP.Push(ch); 
                }
            }

            if (stackP.Count == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}