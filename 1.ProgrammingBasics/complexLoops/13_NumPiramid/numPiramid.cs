using System;

namespace _13_NumPiramid
{
    public class numPiramid
    {
        public static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            var number = 1;
            var l = 1;

            for (var line = 1; line <= l; line++)
            {

                if (number > input)
                {
                    break;
                }

                for (var digit = 1; digit <= line; digit++)
                {
                    if (number > input)
                    {
                        break;
                    }
                    Console.Write(number + " ");
                    number++;
                }

                l++;
                Console.WriteLine();
            }
        }
    }
}
