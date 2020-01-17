using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_04_BracketsFinder
{
    class StartUp
    {
        static void Main(string[] args)
        {
            ReceiveInput();
        }

        public static void ReceiveInput()
        {
            var expression = Console.ReadLine().ToCharArray().ToList();
            FindSubExpressions(expression);
        }


        public static void FindSubExpressions(List<char> expression)
        {
            var indStack = new Stack<int>();

            for (var index=0;index<expression.Count;index++)
            {
                if (expression[index] == '(')
                {
                    indStack.Push(index);
                }
                else if (expression[index]==')')
                {
                    var openingIndex = indStack.Pop();
                    var closingIndex =index;

                    PrintSubExpression(closingIndex, openingIndex, expression);
                }
            }
        }

        public static void PrintSubExpression(int closingInd, int openingInd, List<char> expression)
        {
            for (var index = openingInd; index<=closingInd; index++)
            {
                Console.Write(expression[index]);
            }

            Console.WriteLine();
        }
    }
}
