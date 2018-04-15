using System;

namespace _13_PointInAFigure
{
    public class pointInAFigure
    {
        public static void Main(string[] args)
        {
            var blockSide = int.Parse(Console.ReadLine());
            var x = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());

            var lowBaseY = 0;
            var lowRoofY = blockSide;
            var lowLeftX = 0;
            var lowRightX = 3 * blockSide;
            var highRoofY = blockSide * 4;
            var towerLeftX = blockSide;
            var towerRightX = blockSide * 2;

            if ((y >= lowBaseY && y <= lowRoofY) && (x >= lowLeftX && x <= lowRightX))
            {
                if ((y > lowBaseY && y < lowRoofY) && (x > lowLeftX && x < lowRightX))
                {
                    Console.WriteLine("inside");
                }
                else if (y == lowRoofY && (x > blockSide && x < blockSide * 2))
                {
                    Console.WriteLine("inside");
                }
                else
                {
                    Console.WriteLine("border");
                }
            }
            else if ((y >= lowRoofY && y <= highRoofY) && (x >= towerLeftX && x <= towerRightX))
            {
                if ((y > lowRoofY && y < highRoofY) && (x > towerLeftX && x < towerRightX))
                {
                    Console.WriteLine("inside");
                }
                else if (y == lowRoofY && (x > blockSide && x <= blockSide * 2))
                {
                    Console.WriteLine("inside");
                }
                else
                {
                    Console.WriteLine("border");
                }
            }
            else
            {
                Console.WriteLine("outside");
            }
        }
    }
}
