using System;

namespace _12_ButterFly
{
    public class butterFly
    {
        public static void Main(string[] args)
        {
            //Вход.

            var input = int.Parse(Console.ReadLine());

            //Горна част.

            for (var up = 1; up <= input - 2; up++)
            {
                if (up % 2 != 0)
                {
                    for (var starsLeftUp = 1; starsLeftUp <= input - 2; starsLeftUp++)
                    {
                        Console.Write("*");
                    }
                }
                else
                {
                    for (var dashLeftUp = 1; dashLeftUp <= input - 2; dashLeftUp++)
                    {
                        Console.Write("-");
                    }
                }

                Console.Write("\\ /");

                if (up % 2 != 0)
                {
                    for (var starsRightUp = 1; starsRightUp <= input - 2; starsRightUp++)
                    {
                        Console.Write("*");
                    }
                }
                else
                {
                    for (var dashRightUp = 1; dashRightUp <= input - 2; dashRightUp++)
                    {
                        Console.Write("-");
                    }
                }

                Console.WriteLine();
            }

            //Тяло.

            for (var body = 1; body <= input - 1; body++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("@");

            //Долна част.

            for (var down = 1; down <= input - 2; down++)
            {
                if (down % 2 != 0)
                {
                    for (var starsLeftDown = 1; starsLeftDown <= input - 2; starsLeftDown++)
                    {
                        Console.Write("*");
                    }
                }
                else
                {
                    for (var dashLeftDown = 1; dashLeftDown <= input - 2; dashLeftDown++)
                    {
                        Console.Write("-");
                    }
                }

                Console.Write("/ \\");

                if (down % 2 != 0)
                {
                    for (var starsRightDown = 1; starsRightDown <= input - 2; starsRightDown++)
                    {
                        Console.Write("*");
                    }
                }
                else
                {
                    for (var dashRightDown = 1; dashRightDown <= input - 2; dashRightDown++)
                    {
                        Console.Write("-");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
