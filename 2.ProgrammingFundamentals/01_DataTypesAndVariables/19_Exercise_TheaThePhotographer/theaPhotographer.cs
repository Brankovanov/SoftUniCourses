using System;

namespace _19_Exercise_TheaThePhotographer
{
    public class theaPhotographer
    {
        public static void Main(string[] args)
        {
            var picturesTaken = double.Parse(Console.ReadLine());
            var timeToFilter = double.Parse(Console.ReadLine());
            var percentageOfGoodPics = double.Parse(Console.ReadLine());
            var timeToUploadAPicture = double.Parse(Console.ReadLine());

            var totalTime = (picturesTaken * timeToFilter) + (Math.Ceiling(picturesTaken * (percentageOfGoodPics / 100)) * timeToUploadAPicture);

            var time = new TimeSpan(0, 0, 0, (int)totalTime);

            Console.WriteLine(time.ToString(@"d\:hh\:mm\:ss"));
        }
    }
}
