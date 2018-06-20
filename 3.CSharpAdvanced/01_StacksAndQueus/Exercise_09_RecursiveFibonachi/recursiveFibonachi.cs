using System;

namespace Exercise_09_RecursiveFibonachi
{
    public class recursiveFibonachi
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
            var result = 0l;

            if(n<3)
            {
                result = 1;
            }
            else
            {
                for (var cycle = 3; cycle <= n; cycle++)
                {
                    result = lastNumber + lastButOne;
                    lastButOne = lastNumber;
                    lastNumber = result;
                }
            }

            Print(result);
        }

        //Prints the n-th number.
        static void Print(long result)
        {
            Console.WriteLine(result);
        }
    }
}