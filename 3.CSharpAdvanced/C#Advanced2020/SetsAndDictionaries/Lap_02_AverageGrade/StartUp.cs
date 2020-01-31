using System;
using System.Collections.Generic;
using System.Linq;

namespace Lap_02_AverageGrade
{
    class StartUp
    {
        static void Main(string[] args)
        {
            CreateArchive();
        }

        private static void CreateArchive()
        {
            var numberOfStudents = int.Parse(Console.ReadLine());
            var studentGrades = new Dictionary<string, List<double>>();

            for (var index = 1; index <= numberOfStudents; index++)
            {
                var array = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var name = array[0];
                var grade = double.Parse(array[1]);

                if (studentGrades.ContainsKey(name))
                {
                    studentGrades[name].Add(grade);
                }
                else
                {
                    studentGrades.Add(name, new List<double>());
                    studentGrades[name].Add(grade);
                }
            }


            FindAverageGrade(studentGrades);
        }

        private static void FindAverageGrade(Dictionary<string, List<double>> studentGrades)
        {
            foreach (var st in studentGrades)
            {
                Console.Write($"{st.Key} -> ");

                foreach(var g in st.Value)
                {
                    Console.Write($"{string.Format("{0:0.00}", g)} ");
                }

                Console.WriteLine($"(avg: {string.Format("{0:0.00}", st.Value.Average())})");
            }
        }
    }
}