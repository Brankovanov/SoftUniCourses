using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_05_EvenNumbers
{
    class StartUp
    {
        static void Main(string[] args)
        {
            ReceiveNumbers();
        }

        public static void ReceiveNumbers()
        {
            var numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.None).Select(n => int.Parse(n)).ToArray();

            CreateQueue(numbers);
        }

        public static void CreateQueue(int[] numbers)
        {

            var numbeQ = new Queue<int>();

            foreach (var num in numbers)
            {
                numbeQ.Enqueue(num);
            }

            PrintEvenNumbers(numbeQ);
        }

        public static void PrintEvenNumbers(Queue<int> numbeQ)
        {
            var num = string.Empty;
            do
            {
                if (numbeQ.Peek() % 2 == 0)
                {
                    num += numbeQ.Dequeue() + ", ";
                    
                }
                else
                {
                    numbeQ.Dequeue();
                }
            }
            while (numbeQ.Count > 0);

            Print(num);
        }


        public static void Print(string number)
        {
            Console.WriteLine(number.TrimEnd(',', ' '));
        }
    }
}
