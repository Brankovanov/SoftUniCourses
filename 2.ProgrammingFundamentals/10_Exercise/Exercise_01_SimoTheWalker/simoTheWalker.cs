using System;
using System.Globalization;

namespace Exercise_01_SimoTheWalker
{
    public class simoTheWalker
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        //Получава входна информация от конолата.
        static void ReceiveInput()
        {
            var timeOfLeaving = DateTime.ParseExact(Console.ReadLine(), "HH:mm:ss", CultureInfo.InvariantCulture);
            var numberOfSteos = int.Parse(Console.ReadLine()) % 86400;
            var secondsPerStep = int.Parse(Console.ReadLine()) % 86400;

            CalculateTime(timeOfLeaving, numberOfSteos, secondsPerStep);
        }

        //Изчислява необходимото време.
        static void CalculateTime(DateTime timeOfLeaving, int numberOfSteps, int secondsPerStep)
        {
            var timeOfArrival = timeOfLeaving.AddSeconds(numberOfSteps * secondsPerStep);

            Print(timeOfArrival);
        }

        //Отпечатва времето на пристигане.
        static void Print(DateTime timeOfArrival)
        {
            Console.Write("Time Arrival: " + timeOfArrival.ToString("HH:mm:ss"));
        }
    }
}