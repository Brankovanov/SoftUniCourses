using System;

namespace _13_Exercise_VolewOrDigit
{
    public class volowOrDigits
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();

            if (int.TryParse(input, out var result) == true)
            {
                Console.WriteLine("digit");
            }
            else
            {
                switch (input)
                {
                    case "a":
                        Console.WriteLine("vowel");
                        break;
                    case "e":
                        Console.WriteLine("vowel");
                        break;
                    case "o":
                        Console.WriteLine("vowel");
                        break;
                    case "u":
                        Console.WriteLine("vowel");
                        break;
                    case "i":
                        Console.WriteLine("vowel");
                        break;
                    default:
                        Console.WriteLine("other");
                        break;
                }
            }
        }
    }
}
