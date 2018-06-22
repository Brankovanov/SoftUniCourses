using System;

namespace _14_StudyHall
{
    public class studyHall
    {
        public static void Main(string[] args)
        {
            ReceiveRoomSize();
        }

        //Receives the size of the room.
        static void ReceiveRoomSize()
        {
            var height = double.Parse(Console.ReadLine());
            var widht = double.Parse(Console.ReadLine());

            CalculateWorkingPlaces(widht, height);
        }

        //Calculates how manu working places there are in the room.
        static void CalculateWorkingPlaces(double widht, double height)
        {
            var rolls = Math.Floor(height / 1.2);
            var columns = Math.Floor((widht - 1) / 0.7);
            var workingPlaces = Math.Floor(rolls * columns);

            workingPlaces = workingPlaces - 3;
            Print(workingPlaces);
        }

        //Prints the number of available places.
        static void Print(double workingPlaces)
        {
            Console.WriteLine(workingPlaces);
        }
    }
}