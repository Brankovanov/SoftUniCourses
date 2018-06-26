using System;

namespace _19_SleepyCatTom
{
    public class SleepyTom
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        //Receives input from the console.
        static void ReceiveInput()
        {
            var holidays = int.Parse(Console.ReadLine());

            CalculateSleep(holidays);
        }

        //Calculates the quantity of sleep.
        static void CalculateSleep(int holidays)
        {
            var workingDays = 365 - holidays;
            var sleepHolidays = holidays * 127;
            var sleepWorking = workingDays * 63;
            var totalSleep = sleepHolidays + sleepWorking;

            CreateOutput(totalSleep);
        }

        //Creates output.
        static void CreateOutput(int totalSleep)
        {
            var outputOne = string.Empty;
            var outputTwo = string.Empty;

            if (totalSleep <= 30000)
            {
                var aditionslaSleep = 30000 - totalSleep;
                var hours = aditionslaSleep / 60;
                var minutes = aditionslaSleep - (hours * 60);
                outputOne = $"Tom sleeps well";
                outputTwo = $"{hours} hours and {minutes} minutes less for play";

            }
            else
            {
                var aditionslaSleep = totalSleep - 30000;
                var hours = aditionslaSleep / 60;
                var minutes = aditionslaSleep - (hours * 60);
                outputOne = $"Tom will run away";
                outputTwo = $"{hours} hours and {minutes} minutes more for play";
            }

            Print(outputOne, outputTwo);
        }

        //Prints the output.
        static void Print(string outputOne, string outputTwo)
        {
            Console.WriteLine(outputOne);
            Console.WriteLine(outputTwo);
        }
    }
}