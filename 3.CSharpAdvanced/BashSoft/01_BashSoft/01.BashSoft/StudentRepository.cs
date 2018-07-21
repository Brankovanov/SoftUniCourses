using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace _01.BashSoft
{
    //Holds the dictionary that holds the information about the cources, students and their grades.
    public class StudentRepository
    {
        public static bool isDataInitialized = false;
        private static Dictionary<string, Dictionary<string, List<int>>> studentsByCourse;

        //Initializes the data.
        public static void InitializedDada(string fileName)
        {
            if (!isDataInitialized)
            {
                OutputWriter.WriteMessageOnAnewLine("Reading data...");
                studentsByCourse = new Dictionary<string, Dictionary<string, List<int>>>();
                ReadData(fileName);
            }
            else
            {
                OutputWriter.WriteMessageOnAnewLine(ExceptionMessages.DataAlreadyInitialisedException);
            }
        }

        //Reads the incomming data from the console.
        private static void ReadData(string fileName)
        {
            var path = SessionData.currentPath + "\\" + fileName;

            if (File.Exists(path))
            {
                var pattern = new Regex(@"([A-Z][a-zA-Z#+]*_[A-Z][a-z]{2}_\d{4})\s+([A-Z][a-z]{0,3}\d{2}_\d{0,4})\s+(\d+)");
                var inputLines = File.ReadAllLines(path);

                for (var line = 0; line < inputLines.Length; line++)
                {
                    if (!string.IsNullOrEmpty(inputLines[line]) && pattern.IsMatch(inputLines[line]))
                    {
                        var currentMatch = pattern.Match(inputLines[line]);
                        var course = currentMatch.Groups[1].Value;
                        var student = currentMatch.Groups[2].Value;
                        var points = 0;
                        var scores = int.TryParse(currentMatch.Groups[3].Value, out points);

                        if (scores && points >= 0 && points <= 100)
                        {
                            if (!studentsByCourse.ContainsKey(course))
                            {
                                studentsByCourse.Add(course, new Dictionary<string, List<int>>());
                            }

                            if (!studentsByCourse[course].ContainsKey(student))
                            {
                                studentsByCourse[course].Add(student, new List<int>());
                            }

                            studentsByCourse[course][student].Add(points);
                        }
                    }
                }
            }
            else
            {
                OutputWriter.WriteMessageOnAnewLine(ExceptionMessages.InvalidPath);
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