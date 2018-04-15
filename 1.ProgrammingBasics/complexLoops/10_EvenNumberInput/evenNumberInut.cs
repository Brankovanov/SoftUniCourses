using System;

namespace _10_EvenNumberInput
{
    public class evenNumberInut
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter even number: ");

            var input = Console.ReadLine();

            int.TryParse(input, out int num);

            while (num == 0 || num % 2 != 0)
            {
                Console.WriteLine("Invalid number!");
                Console.Write("Enter even number: ");
                input = Console.ReadLine();

                int.TryParse(input, out num);
            }

            Console.WriteLine("Even number entered: " + num);
        }
    }
}
