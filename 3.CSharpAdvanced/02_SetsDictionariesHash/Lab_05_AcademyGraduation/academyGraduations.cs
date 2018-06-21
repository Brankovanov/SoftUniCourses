using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_05_AcademyGraduation
{
    public class academyGraduations
    {
        public static void Main(string[] args)
        {
            ReceiveStudentInformation();
        }

        //Receive information about the students from the console.
        static void ReceiveStudentInformation()
        {
            var studentName = string.Empty;
            var averageDegrees = new SortedDictionary<string, double>();
            var numberOfStudents = int.Parse(Console.ReadLine());

            for (var index = 1; index <= numberOfStudents; index++)
            {
                studentName = Console.ReadLine();
                var degrees = Console.ReadLine().Split(' ').Select(x=>double.Parse(x)).ToList();

                CalculateAverageDegrees(studentName, degrees, averageDegrees);
            }

            PrintResults(averageDegrees);
        }

        //Calculates the average detrees for every students and saves them in a dictionary.
        static void CalculateAverageDegrees(string studentName, List<double> degrees, SortedDictionary<string, double> averageDegrees)
        {
            var average = 0.0;
            var numberOfDegrees = degrees.Count();

            average = degrees.Average();

            if (averageDegrees.ContainsKey(studentName))
            {
                averageDegrees[studentName] = averageDegrees[studentName] + average;
            }
            else
            {
                averageDegrees.Add(studentName, average);
            }
        }

        //Prints the final results. 
        static void PrintResults(SortedDictionary<string, double> averageDegrees)
        {
            foreach (var student in averageDegrees)
            {
                Console.WriteLine(student.Key + " is graduated with " + student.Value);
            }
        }
    }
}