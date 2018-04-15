using System;

namespace _10_SumOfSyllables
{
    public class SumOfSyllables
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine().ToCharArray();
            var sum = 0;

            foreach (var c in input)
            {
                switch (c)
                {
                    case 'a':
                        sum = sum + 1;
                        break;
                    case 'e':
                        sum = sum + 2;
                        break;
                    case 'i':
                        sum = sum + 3;
                        break;
                    case 'o':
                        sum = sum + 4;
                        break;
                    case 'u':
                        sum = sum + 5;
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
