using System;
using System.Collections.Generic;

namespace _01.BashSoft
{
    //Holds the dictionary that holds the information about the cources, students and their grades.
    public class StudentRepository
    {
        public static bool isDataInitialized = false;
        private static Dictionary<string, Dictionary<string, List<int>>> studentsByCourse;

        //Initializes the data.
        public static void InitializedDada()
        {
            if (!isDataInitialized)
            {
                OutputWriter.WriteMessageOnAnewLine("Reading data...");
                studentsByCourse = new Dictionary<string, Dictionary<string, List<int>>>();
                ReadData();
            }
            else
            {
                OutputWriter.WriteMessageOnAnewLine(ExceptionMessages.DataAlreadyInitialisedException);
            }
        }

        //Reads the incomming data from the console.
        private static void ReadData()
        {
            var input = Console.ReadLine();

            while (!string.IsNullOrEmpty(input))
            {
                var tokens = input.Split(' ');
                var course = tokens[0];
                var student = tokens[1];
                var mark = int.Parse(tokens[2]);

                if (!studentsByCourse.ContainsKey(course))
                {
                    studentsByCourse.Add(course, new Dictionary<string, List<int>>());
                }

                if (!studentsByCourse[course].ContainsKey(student))
                {
                    studentsByCourse[course].Add(student, new List<int>());
                }

                studentsByCourse[course][student].Add(mark);
                input = Console.ReadLine();
            }

            isDataInitialized = true;
            OutputWriter.WriteMessageOnAnewLine("Data read!");
        }

        //Checks if the query for the course is possible.
        private static bool IsQueryForTheCoursePossibble(string courseName)
        {
            if (isDataInitialized && studentsByCourse.ContainsKey(courseName))
            {
                return true;
            }
            else if (isDataInitialized && !studentsByCourse.ContainsKey(courseName))
            {
                OutputWriter.DisplayExceotions(ExceptionMessages.InexistingCourseInDataBase);
            }
            else if (!isDataInitialized)
            {
                OutputWriter.DisplayExceotions(ExceptionMessages.DataNotInitializedExceptionMessage);
            }

            return false;
        }

        //Checks if the query for the student is possible.
        private static bool IsQueryForTheStudentPossible(string courseName, string studentUserName)
        {
            if (IsQueryForTheCoursePossibble(courseName) && studentsByCourse[courseName].ContainsKey(studentUserName))
            {
                return true;
            }
            else
            {
                OutputWriter.DisplayExceotions(ExceptionMessages.InexistingStudentInDataBase);
            }

            return false;
        }

        //Gets the scores of a student from the course.
        public static void GetStudentScoresFromCourse(string courseName, string userName)
        {
            if (IsQueryForTheStudentPossible(courseName, userName))
            {
                OutputWriter.PrintStudent(new KeyValuePair<string, List<int>>(userName, studentsByCourse[courseName][userName]));
            }
        }

        //Gets the scores of all the students from the course.
        public static void GetAllStudentsScoresFromCourse(string courseName)
        {
            if (IsQueryForTheCoursePossibble(courseName))
            {
                OutputWriter.WriteMessageOnAnewLine($"{courseName}");

                foreach (var studentMaksEntry in studentsByCourse[courseName])
                {
                    OutputWriter.PrintStudent(studentMaksEntry);
                }
            }
        }
    }
}