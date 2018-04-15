using System;

namespace _08_SunGlasses
{
    public class sunGlasses
    {
        public static void Main(string[] args)
        {

            //Вход. 

            var input = int.Parse(Console.ReadLine());

            //Горна част на очилата.

            for (var upperLeft = 1; upperLeft <= input * 2; upperLeft++)
            {
                Console.Write("*");
            }

            for (var upperMiddle = 1; upperMiddle <= input; upperMiddle++)
            {
                Console.Write(" ");
            }

            for (var upperRight = 1; upperRight <= input * 2; upperRight++)
            {
                Console.Write("*");
            }

            Console.WriteLine();

            //Стредна част на очилата.
            //Проверка четен или нечетен брой редове.

            if (input % 2 == 0)
            {
                //input - четен.
                //Горна средна част.

                for (var upperHalf = 1; upperHalf <= ((input - 2) / 2)-1; upperHalf++)
                {
                    Console.Write("*");

                    for (var middleLeft = 1; middleLeft <= (input * 2) - 2; middleLeft++)
                    {
                        Console.Write("/");
                    }

                    Console.Write("*");

                    for (var middleMiddle = 1; middleMiddle <= input; middleMiddle++)
                    {
                        Console.Write(" ");
                    }

                    Console.Write("*");

                    for (var middleRight = 1; middleRight <= (input * 2) - 2; middleRight++)
                    {
                        Console.Write("/");
                    }

                    Console.Write("*");
                    Console.WriteLine();
                }

                //Връзка межди ляво и дясно.

                Console.Write("*");

                for (var middleConnectLeft = 1; middleConnectLeft <= (input * 2) - 2; middleConnectLeft++)
                {
                    Console.Write("/");
                }

                Console.Write("*");

                for (var middleConnectMiddle = 1; middleConnectMiddle <= input; middleConnectMiddle++)
                {
                    Console.Write("|");
                }

                Console.Write("*");

                for (var middleConnectRight = 1; middleConnectRight <= (input * 2) - 2; middleConnectRight++)
                {
                    Console.Write("/");
                }

                Console.Write("*");
                Console.WriteLine();

                // Долан средна част.

                for (var m = 1; m <= (input - 2) / 2; m++)
                {
                    Console.Write("*");

                    for (var middleLeft = 1; middleLeft <= (input * 2) - 2; middleLeft++)
                    {
                        Console.Write("/");
                    }

                    Console.Write("*");

                    for (var middleMiddle = 1; middleMiddle <= input; middleMiddle++)
                    {
                        Console.Write(" ");
                    }

                    Console.Write("*");

                    for (var middleRight = 1; middleRight <= (input * 2) - 2; middleRight++)
                    {
                        Console.Write("/");
                    }

                    Console.Write("*");

                    Console.WriteLine();
                }

                Console.Write("*");

                //Долна част на очилата.

                for (var lowerLeft = 1; lowerLeft <= (input * 2) - 1; lowerLeft++)
                {
                    Console.Write("*");
                }

                for (var lowerMiddle = 1; lowerMiddle <= input; lowerMiddle++)
                {
                    Console.Write(" ");
                }

                for (var lowerRight = 1; lowerRight <= input * 2; lowerRight++)
                {
                    Console.Write("*");
                }


            }
            else
            {
                //input - нечетен           
                //Горна средна част.

                for (var upperHalf = 1; upperHalf <= (input - 2) / 2; upperHalf++)
                {
                    Console.Write("*");

                    for (var middleLeft = 1; middleLeft <= (input * 2) - 2; middleLeft++)
                    {
                        Console.Write("/");
                    }

                    Console.Write("*");

                    for (var middleMiddle = 1; middleMiddle <= input; middleMiddle++)
                    {
                        Console.Write(" ");
                    }

                    Console.Write("*");

                    for (var middleRight = 1; middleRight <= (input * 2) - 2; middleRight++)
                    {
                        Console.Write("/");
                    }

                    Console.Write("*");
                    Console.WriteLine();
                }

                //Връзка межди ляво и дясно.

                Console.Write("*");

                for (var middleConnectLeft = 1; middleConnectLeft <= (input * 2) - 2; middleConnectLeft++)
                {
                    Console.Write("/");
                }

                Console.Write("*");

                for (var middleConnectMiddle = 1; middleConnectMiddle <= input; middleConnectMiddle++)
                {
                    Console.Write("|");
                }

                Console.Write("*");

                for (var middleConnectRight = 1; middleConnectRight <= (input * 2) - 2; middleConnectRight++)
                {
                    Console.Write("/");
                }

                Console.Write("*");
                Console.WriteLine();

                // Долан средна част.

                for (var m = 1; m <= (input - 2) / 2; m++)
                {
                    Console.Write("*");

                    for (var middleLeft = 1; middleLeft <= (input * 2) - 2; middleLeft++)
                    {
                        Console.Write("/");
                    }

                    Console.Write("*");

                    for (var middleMiddle = 1; middleMiddle <= input; middleMiddle++)
                    {
                        Console.Write(" ");
                    }

                    Console.Write("*");

                    for (var middleRight = 1; middleRight <= (input * 2) - 2; middleRight++)
                    {
                        Console.Write("/");
                    }

                    Console.Write("*");

                    Console.WriteLine();
                }

                Console.Write("*");

                //Долна част на очилата.

                for (var lowerLeft = 1; lowerLeft <= (input * 2) - 1; lowerLeft++)
                {
                    Console.Write("*");
                }

                for (var lowerMiddle = 1; lowerMiddle <= input; lowerMiddle++)
                {
                    Console.Write(" ");
                }

                for (var lowerRight = 1; lowerRight <= input * 2; lowerRight++)
                {
                    Console.Write("*");
                }
            }
        }
    }
}