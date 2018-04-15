using System;

namespace _14_TimePlusMinutes
{
    public class timePlusMinutes
    {
        public static void Main(string[] args)
        {
            var hour = int.Parse(Console.ReadLine());
            var minute = int.Parse(Console.ReadLine());

            minute = minute + 15;

            if (minute < 60)
            {
                Console.WriteLine($"{hour}:{minute:D2}");
            }
            else if (minute >= 60)
            {
                hour++;
                minute = minute - 60;
                if (hour < 24)
                {
                    Console.WriteLine($"{hour}:{minute:D2}");
                }
                else
                {
                    hour = 0;
                    Console.WriteLine($"{hour}:{minute:D2}");
                }
            }
        }
    }
}
