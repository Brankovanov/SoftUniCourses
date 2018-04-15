using System;

namespace _12_VolleyBall
{
    public class volleyball
    {
        public static void Main(string[] args)
        {
            var year = Console.ReadLine();
            var hollyDays = int.Parse(Console.ReadLine());
            var weekendsTravell = int.Parse(Console.ReadLine());

            var weekend = (48 - weekendsTravell) * 0.75;   
            var holly =hollyDays * 0.66666666666666666;

            if (year.Equals("normal"))
            {
                Console.WriteLine(Math.Truncate(weekend + holly + weekendsTravell));
            }
            else
            {
                Console.WriteLine(Math.Truncate((weekend + holly + weekendsTravell) + ((weekend + holly + weekendsTravell) * 0.15)));
            }
        }
    }
}
