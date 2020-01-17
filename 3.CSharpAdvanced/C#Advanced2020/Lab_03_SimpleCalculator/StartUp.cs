using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Lab_03_SimpleCalculator
{
    class StartUp
    {
        static void Main(string[] args)
        {
            ReceiveInput();
        }

        public static void ReceiveInput()
        {
            var input = Console.ReadLine().Split(' ',StringSplitOptions.None).Select(n => n).ToArray();

            CreateStack(input);
        }

        public static void CreateStack(string[] input)
        {
            var stackStr = new Stack<string>();
            var result = int.Parse(input[0]);

            foreach (var ch in input)
            {
                stackStr.Push(ch);
            }


            Calculate(stackStr,result);
        }
        public static void Calculate(Stack<string> stackStr,int result)
        {
           
            var num = 0;

            while (stackStr.Count > 0)
            {
                var entity = stackStr.Pop();
           
                switch (entity)
                {
                    case "+":
                        result = Add(result, num);
                        break;
                    case "-":
                        result = Remove(result, num);
                        break;
                    default:
                        num = int.Parse(entity);
                        break;
                }
            }

            PrintResutl(result);
        }

        public static int Add(int result, int num)
        {
            result += num;

            return result;
        }

        public static int Remove(int result, int num)
        {
            result -= num;

            return result;
        }

        public static void PrintResutl(int result)
        {
            Console.WriteLine(result);
        }
    }
}
