using System;

namespace _11_Exercise_ConvertSpeedUnits
{
    public class convertSpeedUnits
    {
        public static void Main(string[] args)
        {
            var distanceMetres = float.Parse(Console.ReadLine());
            var hours = float.Parse(Console.ReadLine());
            var minutes = float.Parse(Console.ReadLine());
            var seconds = float.Parse(Console.ReadLine());

            var totalSeconds = (hours * 3600) + (minutes * 60) + seconds;


            var distanceKilometres = distanceMetres / 1000;
            var distanceMiles = distanceMetres / 1609; //A mile.

            var metresPerSecond = distanceMetres / totalSeconds;
            var kilometresPerHour = distanceKilometres / (totalSeconds / 3600);
            var milesPerHour = distanceMiles / (totalSeconds / 3600);

            Console.WriteLine(metresPerSecond);
            Console.WriteLine(kilometresPerHour);
            Console.WriteLine(milesPerHour);
        }
    }
}
