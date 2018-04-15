using System;

namespace _12_Fibonachi
{
    public class fibonachi
    {
        public static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());

            var previosZero = 1;
            var previosOne = 1;
            var finalNum = 0;

            if (input <= 1)
            {
                Console.WriteLine(previosZero);
            }
            else
            {
                for (var n = 1; n < input; n++)
                {
                    finalNum = previosOne + previosZero;
                    previosZero = previosOne;
                    previosOne = finalNum;
                }

                Console.WriteLine(finalNum);
            }
        }
    }
}
