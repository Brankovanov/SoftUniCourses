using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex_05_FashionBotique
{
    class FashionBotique
    {
        static void Main(string[] args)
        {
            ReceiveClothes();
        }

        private static void ReceiveClothes()
        {
            var incoming = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.None).Select(n => int.Parse(n)).ToArray();

            var rackCapacity = int.Parse(Console.ReadLine());

            var boxOfClothes = new Stack<int>(incoming);

            ArrangeClothes(rackCapacity, boxOfClothes);
        }

        private static void ArrangeClothes(int rackCapacity, Stack<int> boxOfClothes)
        {
            var rackCounter = 1;
            var rack = 0;

            while(boxOfClothes.Count>0)
            {
                if(boxOfClothes.Peek() + rack<=rackCapacity)
                {
                    rack += boxOfClothes.Pop();
                }
                else
                {
                    rackCounter++;
                    rack = 0;
                    rack += boxOfClothes.Pop();
                }
            }

            PrintNumberOfRacks(rackCounter);
        }

        private static void PrintNumberOfRacks(int rackCounter)
        {
            Console.WriteLine(rackCounter);
        }
    }
}
