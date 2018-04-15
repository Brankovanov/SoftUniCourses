using System;

namespace _06_Bonus
{
    public class bonus
    {
        public static void Main(string[] args)
        {
            var points = double.Parse(Console.ReadLine());

            if (points <= 100)
            {
                var bonus = 5;

                if (points % 2 == 0)
                {
                    bonus++;
                }

                if (points % 10 == 5)
                {
                    bonus = bonus + 2;
                }

                Console.WriteLine(bonus);
                Console.WriteLine(points + bonus);
            }
            else if (points > 100 && points <= 1000)
            {
                var bonus = points * 0.2;

                if (points % 2 == 0)
                {
                    bonus++;
                }

                if (points % 10 == 5)
                {
                    bonus = bonus + 2;
                }

                Console.WriteLine(bonus);
                Console.WriteLine(points + bonus);
            }
            else if (points > 1000)
            {
                var bonus = points * 0.1;

                if (points % 2 == 0)
                {
                    bonus++;
                }

                if (points % 10 == 5)
                {
                    bonus = bonus + 2;
                }

                Console.WriteLine(bonus);
                Console.WriteLine(points + bonus);
            }
        }
    }
}