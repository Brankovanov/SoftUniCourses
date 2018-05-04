using System;
using System.Linq;

namespace Exercise_03_FoldAndSum
{
    public class foldAndSum
    {
        public static void Main(string[] args)
        {
            Input();
        }

        static void Input()
        {
            var intArray = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

            Fold(intArray);
        }

        static void Fold(int[] intArray)
        {
            var fold = intArray.Length / 4;
            var index = 0;
            int[] foldedArray = new int[fold * 2];

            for (var begin = fold - 1; begin >= 0; begin--)
            {
                foldedArray[index] = intArray[begin];
                index++;
            }

            Array.Reverse(intArray);

            for (var end =0 ; end <= fold - 1; end++)
            {
                foldedArray[fold + end] = intArray[end];
            }

            Array.Reverse(intArray);

            Sum(foldedArray, intArray, fold);
        }

        static void Sum(int[] foldedArray, int[] intArray, int fold)
        {
            var additive = 0;

            foreach(var num in foldedArray)
            {
                Console.Write(num + intArray[fold+additive] +" ");

                additive++;
            }
        }
    }
}
