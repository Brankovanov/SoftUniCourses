using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_09_SortStudentsByYear
{
    public class StudentsByYear
    {

        public static void Main(string[] args)
        {
            Receive();
        }

        //Receives students information from the console.
        public static void Receive()
        {
            var student = Console.ReadLine();
            var studentList = new Dictionary<string, List<int>>();
            var facultyNumber = string.Empty;
            var grades = new List<int>();

            while (student != "END")
            {
                var temp = student.Split(' ').ToList();
                facultyNumber = temp[0];
                grades.AddRange(temp.Skip(1).Select(g => int.Parse(g)));

                if (studentList.ContainsKey(facultyNumber))
                {
                    studentList[facultyNumber].AddRange(grades);
                }
                else if (!studentList.ContainsKey(facultyNumber))
                {
                    studentList.Add(facultyNumber, new List<int>());
                    studentList[facultyNumber].AddRange(grades);
                }

                grades.Clear();
                student = Console.ReadLine();
            }

            SortStudents(studentList);
        }

        //Sorts the collection of students by their low grades.
        public static void SortStudents(Dictionary<string, List<int>> studentList)
        {
            foreach (var st in studentList)
            {
                if (st.Key.EndsWith("14") || st.Key.EndsWith("15"))
                {
                    Console.WriteLine(string.Join(" ", st.Value));
                }
            }
        }
    }
}