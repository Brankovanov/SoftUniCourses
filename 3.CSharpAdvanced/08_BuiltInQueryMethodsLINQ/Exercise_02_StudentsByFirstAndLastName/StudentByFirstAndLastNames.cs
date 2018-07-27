using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_02_StudentsByFirstAndLastName
{
    public class StudentByFirstAndLastNames
    {
        public static void Main(string[] args)
        {
            ReceiveStudentsInformation();
        }

        //Receives students' information from the console.
        public static void ReceiveStudentsInformation()
        {
            var studentInfo = Console.ReadLine();
            var groupStudents = new List<string>();
            var name = string.Empty;
            var lastName = string.Empty;

            while (!studentInfo.Equals("END"))
            {
                groupStudents.Add(studentInfo);
                studentInfo = Console.ReadLine();
            }

            Print(groupStudents);
        }

        //Prints group two from the dictionary on the console.
        public static void Print(List<string> groupStudents)
        {
            var check = new SortedSet<string>();
            var first = string.Empty;
            var last = string.Empty;

            foreach (var name in groupStudents)
            {
                var token = name.Split(' ');
                first = token[0];
                last = token[1];
                check.Add(first);
                check.Add(last);

                if (check.First().Equals(first))
                {
                    Console.WriteLine(first + " " + last);
                }

                check.Clear();
            }
        }
    }
}