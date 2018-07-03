using System;

namespace Exercise_16_Reception
{
    public class Reception
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        //Receives input from the console.
        static void ReceiveInput()
        {
            var firstReceptionist = int.Parse(Console.ReadLine());
            var secondReceptionist = int.Parse(Console.ReadLine());
            var thirdReceptionist = int.Parse(Console.ReadLine());
            var numberOfStudentsQuestions = int.Parse(Console.ReadLine());

            CalculateTime(firstReceptionist, secondReceptionist, thirdReceptionist, numberOfStudentsQuestions);
        }

        //Calculates how much time will be needed to answer all the questions/
        static void CalculateTime(int firstReceptionist, int secondReceptionist, int thirdReceptionist, int numberOfStudentsQuestions)
        {
            var allQuestionsAnsweredForOneHour = firstReceptionist + secondReceptionist + thirdReceptionist;
            var timeNeeded = Math.Ceiling((double)numberOfStudentsQuestions / allQuestionsAnsweredForOneHour);
            var breakTime = Math.Floor(timeNeeded / 3);

            if (timeNeeded % 3 == 0 && numberOfStudentsQuestions>0)
            {
                breakTime--;
            }
                   
            timeNeeded += breakTime;
            PrintTimeNeeded(timeNeeded);
        }

        //Prints the time needed to answer all the questions on the console.
        static void PrintTimeNeeded(double timeNeeded)
        {
            Console.WriteLine($"Time needed: {timeNeeded}h.");
        }
    }
}