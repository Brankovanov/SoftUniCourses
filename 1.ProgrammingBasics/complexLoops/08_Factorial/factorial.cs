using System;

namespace _08_Factorial
{
    public class factorial
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var factorial = 1;

            for (var num = 1; num <= n; num++)
            {
                factorial = factorial * num;
            }

            Console.WriteLine(factorial);
        }
    }
}
