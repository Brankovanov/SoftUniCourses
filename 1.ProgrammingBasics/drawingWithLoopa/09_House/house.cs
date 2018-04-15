using System;

namespace _09_House
{
    public class house
    {
        public static void Main(string[] args)
        {

            //Вход.

            var input = double.Parse(Console.ReadLine());

            // input - четен или нечетен. 

            if (input % 2 == 0) // input - четен.
            {

                //Покрив.

                var roofTopEven = 2;

                for (var roof = 1; roof <= input / 2; roof++)
                {
                    for (var emptyLeft = 1; emptyLeft <= (input - roofTopEven) / 2; emptyLeft++)
                    {
                        Console.Write("-");
                    }

                    for (var roofTiles = 1; roofTiles <= roofTopEven; roofTiles++)
                    {
                        Console.Write("*");
                    }

                    for (var emptyRight = 1; emptyRight <= (input - roofTopEven) / 2; emptyRight++)
                    {
                        Console.Write("-");
                    }

                    Console.WriteLine();
                    roofTopEven = roofTopEven + 2;
                }

                //Тяло.

                for (var building = 1; building <= input / 2; building++)
                {
                    Console.Write("|");

                    for (var bricks = 1; bricks <= input - 2; bricks++)
                    {
                        Console.Write("*");
                    }

                    Console.Write("|");
                    Console.WriteLine();
                }
            }
            else // input - нечетен.
            {

                //Покрив.

                var roofTopOdd = 1;

                for (var roof = 1; roof <= Math.Ceiling(input / 2); roof++)
                {
                    for (var emptyLeft = 1; emptyLeft <= (input - roofTopOdd) / 2; emptyLeft++)
                    {
                        Console.Write("-");
                    }

                    for (var roofTiles = 1; roofTiles <= roofTopOdd; roofTiles++)
                    {
                        Console.Write("*");
                    }

                    for (var emptyRight = 1; emptyRight <= (input - roofTopOdd) / 2; emptyRight++)
                    {
                        Console.Write("-");
                    }

                    Console.WriteLine();
                    roofTopOdd = roofTopOdd + 2;
                }

                //Тяло.

                for (var building = 1; building <= Math.Floor(input / 2); building++)
                {
                    Console.Write("|");

                    for (var bricks = 1; bricks <= input - 2; bricks++)
                    {
                        Console.Write("*");
                    }

                    Console.Write("|");
                    Console.WriteLine();
                }
            }
        }
    }
}
