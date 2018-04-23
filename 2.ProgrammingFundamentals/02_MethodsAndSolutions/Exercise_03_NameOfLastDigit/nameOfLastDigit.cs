using System;

namespace Exercise_03_NameOfLastDigit
{
    public class nameOfLastDigit
    {
        public static void Main(string[] args)
        {
            var number = 0;

            Input(number);
        }

        static void Input(long number)
        {
            number = long.Parse(Console.ReadLine());

            PrintNameOfLastDigit(number);
        }

        static void PrintNameOfLastDigit(long number)
        {
            switch (Math.Abs(number) % 10)
            {
                case 0:
                    Console.Write( "zero");
                    break;
                case 1:
                    Console.Write("one");
                    break;
                case 2:
                    Console.Write("two");
                    break;
                case 3:
                    Console.Write("three");
                    break;
                case 4:
                    Console.Write("four");
                    break;
                case 5:
                    Console.Write("five");
                    break;
                case 6:
                    Console.Write("six");
                    break;
                case 7:
                    Console.Write("seven");
                    break;
                case 8:
                    Console.Write("eight");
                    break;
                case 9:
                    Console.Write("nine");
                    break;
            }
        }
    }
}
