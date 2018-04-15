using System;

namespace _06_NumbersInRange
{
    public class numbersInRange
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a number in the range [1...100]: ");
            var input = int.Parse(Console.ReadLine());

            if (input <= 100 && input >= 1)
            {
                Console.WriteLine("The number is: " + input);
            }
            else
            {

                Console.WriteLine("Invalid number!");

                for (var n = 0; n <= 1; n--)
                {
                    Console.Write("Enter a number in the range [1...100]: ");
                    input = int.Parse(Console.ReadLine());

                    if (input <= 100 && input >= 1)
                    {
                        Console.WriteLine("The number is: " + input);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid number!");
                    }
                }
            }
        }
    }
}
