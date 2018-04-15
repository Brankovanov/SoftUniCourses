using System;

namespace _04_Triangle
{
    public class triangle
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (var m = 1; m <= n; m++)
            {
                for (var p = 1; p <= m; p++)
                {
                    Console.Write("$ ");
                }

                Console.WriteLine();
            }
        }
    }
}
