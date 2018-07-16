using System;

namespace Exercise_12_CharacterMultiplier
{
    public class CharacterMultiplier
    {
        public static void Main(string[] args)
        {
            ReceiveStrings();
        }

        //Receives two strings from the console.
        public static void ReceiveStrings()
        {
            var strings = Console.ReadLine().Split(' ');
            MultiplyChars(strings);
        }

        //Multiplies the ASCII values of the coresponding chars and than sums it  up.
        public static void MultiplyChars(string[] strings)
        {
            var sum = 0;

            for (var index = 0; index < Math.Max(strings[0].Length, strings[1].Length); index++)
            {
                if (index < Math.Min(strings[0].Length, strings[1].Length))
                {
                    sum += (int)strings[0][index] * (int)strings[1][index];
                }
                else if (index >= Math.Min(strings[0].Length, strings[1].Length) &&
                Math.Max(strings[0].Length, strings[1].Length) == strings[0].Length)
                {
                    sum += (int)strings[0][index];
                }
                else if (index >= Math.Min(strings[0].Length, strings[1].Length) &&
                Math.Max(strings[0].Length, strings[1].Length) == strings[1].Length)
                {
                    sum += (int)strings[1][index];
                }
            }

            PrintSum(sum);
        }

        //Pritns the final sum of all characters.
        public static void PrintSum(int sum)
        {
            Console.WriteLine(sum);
        }
    }
}