using System;

namespace _10_Diamond
{
    public class diamond
    {
        public static void Main(string[] args)
        {

            //Вход. 

            var input = double.Parse(Console.ReadLine());
            var insideFill = 0;

            if (input <= 2) //Ако входът е 1 или 2. 
            {
                for (var diamond = 1; diamond <= input; diamond++)
                {
                    Console.Write("*");
                }
            }
            else //Ако входът е по-голям от 2. 
            {

                if (input % 2 == 0) //Четен вход.
                {

                    //Горна половина.

                    for (var upperHalf = 1; upperHalf <= (input / 2) - 1; upperHalf++)
                    {

                        for (var outsideLeft = 1; outsideLeft <= ((input / 2) - 1) - (insideFill / 2); outsideLeft++)
                        {
                            Console.Write("-");
                        }

                        Console.Write("*");

                        for (var inside = 0; inside < insideFill; inside++)
                        {
                            Console.Write("-");
                        }

                        Console.Write("*");

                        for (var outsideRight = 1; outsideRight <= ((input / 2) - 1) - (insideFill / 2); outsideRight++)
                        {
                            Console.Write("-");
                        }

                        insideFill = insideFill + 2;

                        Console.WriteLine();
                    }

                    //Долна половина.

                    for (var lowerHalf = 1; lowerHalf <= (input / 2); lowerHalf++)
                    {

                        for (var outsideLeft = ((input / 2) - 1) - (insideFill / 2); outsideLeft >= 1; outsideLeft--)
                        {
                            Console.Write("-");
                        }

                        Console.Write("*");

                        for (var inside = insideFill; inside > 0; inside--)
                        {
                            Console.Write("-");
                        }

                        Console.Write("*");

                        for (var outsideRight = ((input / 2) - 1) - (insideFill / 2); outsideRight >= 1; outsideRight--)
                        {
                            Console.Write("-");
                        }

                        insideFill = insideFill - 2;
                        Console.WriteLine();
                    }
                }
                else //Нечетен вход
                {
                    insideFill = 3;

                    //Горна част

                    for (var firstRollLeft = 0; firstRollLeft < Math.Floor(input / 2); firstRollLeft++)
                    {
                        Console.Write("-");
                    }

                    Console.Write("*");

                    for (var firstRollRight = 0; firstRollRight < Math.Floor(input / 2); firstRollRight++)
                    {
                        Console.Write("-");
                    }

                    Console.WriteLine();

                    for (var upperHalf = 1; upperHalf <= Math.Floor(input / 2) - 1; upperHalf++)
                    {
                        for (var outsideUpLeft = 1; outsideUpLeft <= Math.Ceiling(input - insideFill) / 2; outsideUpLeft++)
                        {
                            Console.Write("-");
                        }

                        Console.Write("*");

                        for (var inside = 1; inside <= insideFill - 2; inside++)
                        {
                            Console.Write("-");
                        }

                        Console.Write("*");

                        for (var outsideUpLeft = 1; outsideUpLeft <= Math.Ceiling(input - insideFill) / 2; outsideUpLeft++)
                        {
                            Console.Write("-");
                        }

                        insideFill = insideFill + 2;
                        Console.WriteLine();
                    }

                    //Средна част

                    Console.Write("*");

                    for (var mid = 1; mid <= input - 2; mid++)
                    {
                        Console.Write("-");
                    }

                    Console.Write("*");
                    Console.WriteLine();

                    //Долна част

                    insideFill = insideFill - 2;

                    for (var loweHalf = 1; loweHalf <= Math.Floor(input / 2) - 1; loweHalf++)
                    {
                        for (var outsideDownLeft = Math.Ceiling(input - insideFill) / 2; outsideDownLeft >= 1; outsideDownLeft--)
                        {
                            Console.Write("-");
                        }

                        Console.Write("*");

                        for (var inside = insideFill - 2; inside >= 1; inside--)
                        {
                            Console.Write("-");
                        }

                        Console.Write("*");

                        for (var outsideDownRight = Math.Ceiling(input - insideFill) / 2; outsideDownRight >= 1; outsideDownRight--)
                        {
                            Console.Write("-");
                        }

                        insideFill = insideFill - 2;
                        Console.WriteLine();
                    }

                    for (var lastRollLeft = 0; lastRollLeft < Math.Floor(input / 2); lastRollLeft++)
                    {
                        Console.Write("-");
                    }

                    Console.Write("*");

                    for (var lastRollRight = 0; lastRollRight < Math.Floor(input / 2); lastRollRight++)
                    {
                        Console.Write("-");
                    }
                }
            }
        }
    }
}
