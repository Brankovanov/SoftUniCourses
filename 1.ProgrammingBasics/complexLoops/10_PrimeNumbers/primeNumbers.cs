using System;

namespace _10_PrimeNumbers
{
    public class primeNumbers
    {
        public static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var check = 0;

            if (num <= 1)
            {
                Console.WriteLine("Not Prime");
            }
            else
            {
                for (var dev = 2; dev < num; dev++)
                {
                    if (num % dev == 0)
                    {
                        check++;
                        break;
                    }
                }

                if (check == 0)
                {
                    Console.WriteLine("Prime");
                }
                else
                {
                    Console.WriteLine("Not Prime");
                }
            }
        }
    }
}
