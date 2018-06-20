using System;
using System.Collections.Generic;

namespace Exercise_10_StackFibonachi
{
    public class stackFibonachi
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        //Receives the n-th number from the sequence.
        static void ReceiveInput()
        {
            var n = long.Parse(Console.ReadLine());
            GenerateNumber(n);
        }

        //Generates the n-th number from the sequence.
        static void GenerateNumber(long n)
        {
            var lastButOne = 1l;
            var lastNumber = 1l;
            var result = new Stack<long>();

            if (n < 3)
            {
                result.Push(1);
            }
            else
            {
                for (var cycle = 3; cycle <= n; cycle++)
                {
                    result.Push(lastNumber + lastButOne);
                    lastButOne = lastNumber;
                    lastNumber = result.Peek();
                }
            }

            Print(result);
        }

        //Prints the n-th number.
        static void Print(Stack<long> result)
        {
            Console.WriteLine(result.Peek());
        }
    }
}