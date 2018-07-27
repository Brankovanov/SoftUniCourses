using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_06_FilterStudentsByPhone
{
    public class FilterStudentsByPhone
    {
        public static void Main(string[] args)
        {
            Receive();
        }

        //Receives students information from the console.
        public static void Receive()
        {
            var student = Console.ReadLine();
            var studentList = new List<List<string>>();

            while (student != "END")
            {
                var temp = student.Split(' ').ToList();
                studentList.Add(temp);
                student = Console.ReadLine();
            }

            SortStudents(studentList);
        }

        //Sorts the collection of students first by phone codes.
        public static void SortStudents(List<List<string>> studentList)
        {
            var temp = new List<List<string>>();
            temp.AddRange(studentList.Where(st => st.Last().StartsWith("02")));
            temp.AddRange(studentList.Where(st => st.Last().StartsWith("+3592")));

            foreach (var st in temp)
            {
                Console.WriteLine(string.Join(" ", st[0], st[1]));
            }
        }
    }
}