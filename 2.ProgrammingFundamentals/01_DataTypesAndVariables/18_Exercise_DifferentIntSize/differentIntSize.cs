using System;
using System.Numerics;

namespace _18_Exercise_DifferentIntSize
{
    public class differentIntSize
    {
        public static void Main(string[] args)
        {
            var inputInt = BigInteger.Parse(Console.ReadLine());
      
            if (inputInt >= long.MinValue && inputInt <= long.MaxValue)
            {
                Console.WriteLine(inputInt + " can fit in:");
            }
            else
            {
                Console.WriteLine(inputInt + " can't fit in any type");
            }

            if (inputInt >= sbyte.MinValue && inputInt <= sbyte.MaxValue)
            {
                Console.WriteLine("* sbyte");
            }

            if (inputInt >= byte.MinValue && inputInt <= byte.MaxValue)
            {
                Console.WriteLine("* byte");
            }

            if (inputInt >= short.MinValue && inputInt <= short.MaxValue)
            {
                Console.WriteLine("* short");
            }

            if (inputInt >= ushort.MinValue && inputInt <= ushort.MaxValue)
            {
                Console.WriteLine("* ushort");
            }

            if (inputInt >= int.MinValue && inputInt <= int.MaxValue)
            {
                Console.WriteLine("* int");
            }

            if (inputInt >= uint.MinValue && inputInt <= uint.MaxValue)
            {
                Console.WriteLine("* uint");
            }

            if (inputInt >= long.MinValue && inputInt <= long.MaxValue)
            {
                Console.WriteLine("* long");
            }
        }
    }
}
