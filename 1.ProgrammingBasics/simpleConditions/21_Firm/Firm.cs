using System;

namespace _21_Firm
{
    public class Firm
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        //Receives input from the console.
        static void ReceiveInput()
        {
            var hoursRequired = int.Parse(Console.ReadLine());
            var daysAvailable = double.Parse(Console.ReadLine());
            var numberOfWorkers = int.Parse(Console.ReadLine());

            CalculateWorkingHours(daysAvailable, numberOfWorkers, hoursRequired);
        }

        //Calculates working hours available.
        static void CalculateWorkingHours(double daysAvailable, int numberOfWorkers, int hoursRequired)
        {
            var timesToStudy = (daysAvailable * 0.1);
            var daysToWork = daysAvailable - timesToStudy;
            var workingHours = daysToWork * 8;
            var aditionalHours = numberOfWorkers * (2 * daysAvailable);
            workingHours += aditionalHours;

            CheckWorkingHours(workingHours, hoursRequired);
        }

        //Checks if working hours are enough.
        static void CheckWorkingHours(double workingHours, int hoursRequired)
        {
            var output = string.Empty;

            if (workingHours >= hoursRequired)
            {
                var leftOverTime = (int)(workingHours - hoursRequired);
                output = $"Yes!{leftOverTime} hours left.";
            }
            else
            {
                var timeNeeded = Math.Ceiling(hoursRequired - workingHours);          
                output = $"Not enough time!{timeNeeded} hours needed.";
            }

            PrintOutput(output);
        }

        //Prints the output.
        static void PrintOutput(string output)
        {
            Console.WriteLine(output);
        }
    }
}