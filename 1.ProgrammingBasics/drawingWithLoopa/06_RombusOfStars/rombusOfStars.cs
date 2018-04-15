using System;

namespace _06_RombusOfStars
{
    public class rombusOfStars
    {
        public static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());

            for (var up = 1; up <= size - 1; up++)
            {
                for (var emptyUp = 1; emptyUp <= (size - up); emptyUp++)
                {
                    Console.Write(" ");
                }

                Console.Write("*");

                for (var line = 1; line <= up - 1; line++)
                {
                    Console.Write(" *");
                }

                for (var emptyUpTwo = 1; emptyUpTwo <= (size - up) / 2; emptyUpTwo++)
                {
                    Console.Write(" ");
                }

                Console.WriteLine();
            }

            Console.Write("*");

            for (var middle = 1; middle <= size - 1; middle++)
            {

                Console.Write(" *");
            }

            Console.WriteLine();

            for (var down = size - 1; down >= 1; down--)
            {
                for (var emptyDown = 1; emptyDown <= (size - down); emptyDown++)
                {
                    Console.Write(" ");
                }

                Console.Write("*");

                for (var secondLine = 1; secondLine <= down - 1; secondLine++)
                {
                    Console.Write(" *");
                }

                for (var emptyDownTwo = 1; emptyDownTwo <= (size - down) / 2; emptyDownTwo++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
