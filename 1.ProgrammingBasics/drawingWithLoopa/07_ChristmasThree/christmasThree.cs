using System;

namespace _07_ChristmasThree
{
    public class christmasThree
    {
        public static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());

            for (var emptyUp = 1; emptyUp <= size; emptyUp++)
            {
                Console.Write(" ");
            }

            Console.Write(" | ");

            for (var emptyUpTwo = 1; emptyUpTwo <= size/ 2; emptyUpTwo++)
            {
                Console.Write(" ");
            }

            Console.WriteLine();

            for (var up = 1; up <= size; up++)
            {
                for (var emptyUp = 1; emptyUp <= (size - up); emptyUp++)
                {
                    Console.Write(" ");
                }
               
                for (var line = 1; line <= up; line++)
                {
                    Console.Write("*");
                }

                Console.Write(" | ");

                for (var lineTwo = 1; lineTwo <= up; lineTwo++)
                {
                    Console.Write("*");
                }

                for (var emptyUpTwo = 1; emptyUpTwo <= (size - up) / 2; emptyUpTwo++)
                {
                    Console.Write(" ");
                }

                Console.WriteLine();
            }

        }
    }
}
