using System;

namespace _14_InTimeForTheExam
{
    public class intTimeForTheExam
    {
        public static void Main(string[] args)
        {
            var hourOfTheExam = int.Parse(Console.ReadLine());
            var minutesOfTheExam = int.Parse(Console.ReadLine());
            var hourOfArrival = int.Parse(Console.ReadLine());
            var minutesOfArrival = int.Parse(Console.ReadLine());

            var exam = (hourOfTheExam * 60) + minutesOfTheExam;
            var arrival = (hourOfArrival * 60) + minutesOfArrival;
            var indicator = exam - arrival;

            if (indicator >= 0 && indicator <= 30)
            {
                Console.WriteLine("On time");

                if (indicator != 0)
                {
                    Console.WriteLine(indicator + " minutes before the start");
                }

            }
            else if (indicator > 30)
            {
                Console.WriteLine("Early");

                if (indicator < 60)
                {
                    Console.WriteLine(indicator + " minutes before the start");
                }
                else if (indicator >= 60)
                {
                    var early = DateTime.Parse(hourOfTheExam + ":" + minutesOfTheExam) - DateTime.Parse(hourOfArrival + ":" + minutesOfArrival);

                    Console.WriteLine(early.Hours + ":" + early.Minutes.ToString("D2") + " hours before the start");
                }
            }
            else if (indicator < 0)
            {
                Console.WriteLine("Late");

                if (indicator > -60)
                {
                    Console.WriteLine(Math.Abs(indicator) + " minutes after the start");
                }
                else if (indicator <= -60)
                {
                    var late = DateTime.Parse(hourOfArrival + ":" + minutesOfArrival) - DateTime.Parse(hourOfTheExam + ":" + minutesOfTheExam);

                    Console.WriteLine(late.Hours + ":" + late.Minutes.ToString("D2") + " hours after the start");
                }
            }
        }
    }
}
