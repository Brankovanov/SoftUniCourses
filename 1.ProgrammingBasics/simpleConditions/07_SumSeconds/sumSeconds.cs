using System;

namespace _07_SumSeconds
{
    public class sumSeconds
    {
        public static void Main(string[] args)
        {
            var first = int.Parse(Console.ReadLine());
            var second = int.Parse(Console.ReadLine());
            var third = int.Parse(Console.ReadLine());

            var totalTime = first + second + third;

            var minutes = totalTime / 60;

            var seconds = totalTime - (minutes * 60);

            Console.WriteLine(minutes + ":" + seconds.ToString("00"));
        }
    }
}
