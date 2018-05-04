using System;
using System.Linq;

namespace Exercise_02_RotateAndSum
{
    public class rotateAndSum
    {
        public static void Main(string[] args)
        {
            Input();
        }

        static void Input()
        {
            var numberArray = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            var round = int.Parse(Console.ReadLine());

            Rotate(numberArray, round);
        }

        static void Rotate(int[] numberArray, int round)
        {
            int[] sumArray = new int[numberArray.Length];
            int[] temporaryArray = new int[numberArray.Length];
            var temporaryVar = 0;

            for (var rounds = 1; rounds <= round; rounds++)
            {
                Sum(numberArray, round, sumArray, temporaryArray, temporaryVar);
            }

            Print(sumArray);
        }

        static void Sum(int[] numberArray, int round, int[] sumArray, int[] temporaryArray, int temporaryVar)
        {
            var temp = numberArray[numberArray.Length - 1];

            for (var index = 0; index <= numberArray.Length - 2; index++)
            {
                temporaryVar = numberArray[index];

                temporaryArray[index + 1] = temporaryVar;
            }
            temporaryArray[0] += temp;

            for (var n = 0; n <= numberArray.Length - 1; n++)
            {
                sumArray[n] += temporaryArray[n];
                numberArray[n] = temporaryArray[n];
                temporaryArray[n] = 0;
            }
        }

        static void Print(int[] sumArray)
        {
            foreach (var num in sumArray)
            {
                Console.Write(num + " ");
            }
        }
    }
}
