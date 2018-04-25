using System;

namespace Exercise_10_CubeProperties
{
    public class cubeProperties
    {
        public static void Main(string[] args)
        {
            var side = 0.0;
            var parameters = string.Empty;

            Input(side, parameters);
        }

        static void Input(double side, string parameters)
        {
            side = double.Parse(Console.ReadLine());
            parameters = Console.ReadLine();

            ChooseParameters(side, parameters);
        }

        static void ChooseParameters(double side, string parameters)
        {
            if (parameters.Equals("face"))
            {
                Console.WriteLine($"{Face(side):F2}");
            }
            else if (parameters.Equals("space"))
            {
                Console.WriteLine($"{Space(side):F2}");
            }
            else if (parameters.Equals("area"))
            {
                Console.WriteLine($"{Area(side):F2}");
            }
            else if (parameters.Equals("volume"))
            {
                Console.WriteLine($"{Volume(side):F2}");
            }
        }

        static double Face(double side)
        {
            return Math.Sqrt(2 * (Math.Pow(side, 2)));
        }

        static double Space(double side)
        {
            return Math.Sqrt(3 * (Math.Pow(side, 2)));
        }

        static double Area(double side)
        {
            return Math.Pow(side, 2) * 6;
        }

        static double Volume(double side)
        {
            return Math.Pow(side, 3);
        }
    }
}
