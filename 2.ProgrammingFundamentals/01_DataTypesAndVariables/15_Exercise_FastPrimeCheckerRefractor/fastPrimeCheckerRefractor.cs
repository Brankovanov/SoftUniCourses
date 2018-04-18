using System;

namespace _15_Exercise_FastPrimeCheckerRefractor
{
    public class fastPrimeCheckerRefractor
    {
        public static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());

            for (var numbers = 2; numbers <= input; numbers++)
            {
                bool cheker = true;

                for (var divider = 2; divider <= Math.Sqrt(numbers); divider++)
                {
                    if (numbers % divider == 0)
                    {
                        cheker = false;
                        break;
                    }
                }

                Console.WriteLine($"{numbers} -> {cheker}");
            }
        }
    }
}
