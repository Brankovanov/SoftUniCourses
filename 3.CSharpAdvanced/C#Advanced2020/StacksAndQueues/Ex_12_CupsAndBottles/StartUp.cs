using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex_12_CupsAndBottles
{
    class StartUp
    {
        static void Main(string[] args)
        {
            ReceiveInformation();
        }

        private static void ReceiveInformation()
        {
            var cups = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.None).Select(n => int.Parse(n)).ToArray();
            var bottles = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.None).Select(n => int.Parse(n)).ToArray();
            var stackOfBottles = new Stack<int>(bottles);
            var queueOfCups = new Queue<int>(cups);

            FillCups(stackOfBottles, queueOfCups);
        }

        private static void FillCups(Stack<int> stackOfBottles, Queue<int> queueOfCups)
        {
            var wastedWater = 0;

            while (true)
            {
                if(queueOfCups.Count==0)
                {
                    Console.WriteLine("Bottles: " + string.Join(' ',stackOfBottles));
                    Console.WriteLine("Wasted litters of water: " + wastedWater);
                    break;
                }
                else if(stackOfBottles.Count==0)
                {
                    Console.WriteLine("Cups: " + string.Join(' ',queueOfCups));
                    Console.WriteLine("Wasted litters of water: " + wastedWater);
                    break;
                }
                else if(stackOfBottles.Peek()>=queueOfCups.Peek())
                {
                    wastedWater += stackOfBottles.Pop() - queueOfCups.Dequeue();
                }
                else if(stackOfBottles.Peek()<queueOfCups.Peek())
                {
                    var temp=  stackOfBottles.Pop();
                    stackOfBottles.Push(stackOfBottles.Pop() + temp);
                }
            }
        }
    }
}