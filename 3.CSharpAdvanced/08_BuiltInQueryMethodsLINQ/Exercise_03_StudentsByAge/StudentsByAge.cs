using System;
using System.Collections.Generic;

namespace Exercise_03_StudentsByAge
{
    public class StudentsByAge
    {
        public static void Main(string[] args)
        {
            ReceiveStudentInformation();
        }

        //Receives the student information from the console.
        public static void ReceiveStudentInformation()
        {
            var students = Console.ReadLine();
            var firstName = string.Empty;
            var lastName = string.Empty;
            var age = 0;
            var studentArchive = new List<string>();
            Func<string, string, int, string> sort = SortStudentInformation;

            while (!students.Equals("END"))
            {
                var temp = students.Split(' ');
                firstName = temp[0];
                lastName = temp[1];
                age = int.Parse(temp[2]);

                if (sort(firstName, lastName, age) != null)
                {
                    studentArchive.Add(sort(firstName, lastName, age));
                }

                students = Console.ReadLine();
            }

            Print(studentArchive);
        }

        //Sorts the student information by their age.
        private static string SortStudentInformation(string firstName, string lastName, int age)
        {
            if (age >= 18 && age <= 24)
            {
                return firstName + " " + lastName + " " + age;
            }

            return null;
        }

        //Prinst the sorted studetns information.
        private static void Print(List<string> studentArchive)
        {
            Console.WriteLine(string.Join("\n", studentArchive));
        }
    }
}