using System;

namespace _17_Exercise_PrintPartOfASCIITable
{
    public class printPartOfASCIITable
    {
        public static void Main(string[] args)
        {
            var start = int.Parse(Console.ReadLine());
            var finish = int.Parse(Console.ReadLine());

            for (var ch = start; ch<=finish; ch++)
            {
                Console.Write((char)ch + " ");
            }
        }
    }
}
