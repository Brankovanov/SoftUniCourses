using System;

namespace _11_Fortress
{
    public class fortress
    {
        public static void Main(string[] args)
        {
            //Вход.

            var input = int.Parse(Console.ReadLine());

            if (input % 2 != 0)
            {

                //Покрив.

                Console.Write("/");

                for (var leftTower = 1; leftTower <= input / 2; leftTower++)
                {
                    Console.Write("^");
                }

                Console.Write("\\");

                for (var middleRoof = 0; middleRoof <= (input * 2) - (input + 4); middleRoof++)
                {
                    Console.Write("_");
                }

                Console.Write("/");

                for (var rightTower = 1; rightTower <= input / 2; rightTower++)
                {
                    Console.Write("^");
                }

                Console.Write("\\");
                Console.WriteLine();

                //Тяло. 

                for (var floors = 1; floors <= input - 3; floors++)
                {
                    Console.Write("|");

                    for (var building = 1; building <= (input * 2) - 2; building++)
                    {
                        Console.Write(" ");
                    }

                    Console.Write("|");
                    Console.WriteLine();
                }

                Console.Write("|");

                for (var leftTower = 0; leftTower <= input / 2; leftTower++)
                {
                    Console.Write(" ");
                }

                for (var middleRoof = 0; middleRoof <= (input * 2) - (input + 4); middleRoof++)
                {
                    Console.Write("_");
                }

                for (var rightTower = 0; rightTower <= input / 2; rightTower++)
                {
                    Console.Write(" ");
                }

                Console.Write("|");
                Console.WriteLine();

                //Основа.

                Console.Write("\\");

                for (var leftBase = 1; leftBase <= input / 2; leftBase++)
                {
                    Console.Write("_");
                }

                Console.Write("/");

                for (var middleBase = 0; middleBase <= (input * 2) - (input + 4); middleBase++)
                {
                    Console.Write(" ");
                }

                Console.Write("\\");

                for (var rightTower = 1; rightTower <= input / 2; rightTower++)
                {
                    Console.Write("_");
                }

                Console.Write("/");
                Console.WriteLine();
            }
            else
            {
                //Покрив.

                Console.Write("/");

                for (var leftTower = 1; leftTower <= input / 2; leftTower++)
                {
                    Console.Write("^");
                }

                Console.Write("\\");

                for (var middleRoof = 0; middleRoof < (input * 2) - (input + 4); middleRoof++)
                {
                    Console.Write("_");
                }

                Console.Write("/");

                for (var rightTower = 1; rightTower <= input / 2; rightTower++)
                {
                    Console.Write("^");
                }

                Console.Write("\\");
                Console.WriteLine();

                //Тяло. 

                for (var floors = 1; floors <= input - 3; floors++)
                {
                    Console.Write("|");

                    for (var building = 0; building < (input * 2) - 2; building++)
                    {
                        Console.Write(" ");
                    }

                    Console.Write("|");
                    Console.WriteLine();
                }

                Console.Write("|");

                for (var leftTower = 0; leftTower <= input / 2; leftTower++)
                {
                    Console.Write(" ");
                }

                for (var middleRoof = 0; middleRoof < (input * 2) - (input + 4); middleRoof++)
                {
                    Console.Write("_");
                }

                for (var rightTower = 0; rightTower <= input / 2; rightTower++)
                {
                    Console.Write(" ");
                }

                Console.Write("|");
                Console.WriteLine();

                //Основа.

                Console.Write("\\");

                for (var leftBase = 1; leftBase <= input / 2; leftBase++)
                {
                    Console.Write("_");
                }

                Console.Write("/");

                for (var middleBase = 0; middleBase < (input * 2) - (input + 4); middleBase++)
                {
                    Console.Write(" ");
                }

                Console.Write("\\");

                for (var rightTower = 1; rightTower <= input / 2; rightTower++)
                {
                    Console.Write("_");
                }

                Console.Write("/");
                Console.WriteLine();
            }
        }
    }
}
