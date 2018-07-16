using System;
using System.Collections.Generic;

namespace Lab_01_StudentResults
{
    public class StudentResult
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        //Receives input from the console.
        public static void ReceiveInput()
        {
            var studentArhive = new List<string[]>();
            var tableParameters = "Name      |   CAdv|   COOP| AdvOOP|Average|";
            var temp = tableParameters.Split('|');
            studentArhive.Add(temp);

            var numberOfStudents = int.Parse(Console.ReadLine());

            for (var index = 1; index <= numberOfStudents; index++)
            {
                var studentInformation = Console.ReadLine();
                ProcessInformation(studentInformation, studentArhive);
            }

            Prints(studentArhive);
        }

        //Process student information.
        public static void ProcessInformation(string studentInformation, List<string[]> studentArchive)
        {
            var temp = new string[5];
            var studentFile = studentInformation.Split('-', ',');
            var name = studentFile[0];
            var one = String.Format("{0:0.00}", double.Parse(studentFile[1]));
            var two = String.Format("{0:0.00}", double.Parse(studentFile[2]));
            var three = String.Format("{0:0.00}", double.Parse(studentFile[3]));
            var average = (double.Parse(studentFile[1]) + double.Parse(studentFile[2]) + double.Parse(studentFile[3])) / 3;
            var four = String.Format("{0:0.0000}", average);

            if (studentArchive[0][0].Length > name.Length)
            {
                var diff = studentArchive[0][0].Length - name.Length;
                name = name + new String(' ', diff);
                temp[0] = name;
            }
            else
            {
                var diff = name.Length - studentArchive[0][0].Length;

                for (var stud = 0; stud < studentArchive.Count; stud++)
                {
                    var mod = studentArchive[stud][0];
                    studentArchive[stud][0] = mod + new String(' ', diff);
                }

                temp[0] = name;
            }

            var first = studentArchive[0][1].Length - one.Length;
            one = new String(' ', first) + one;
            temp[1] = one;

            var second = studentArchive[0][2].Length - two.Length;
            two = new String(' ', second) + two;
            temp[2] = two;

            var third = studentArchive[0][3].Length - three.Length;
            three = new String(' ', third) + three;
            temp[3] = three;

            var fourth = studentArchive[0][4].Length - four.Length;
            four = new String(' ', fourth) + four;
            temp[4] = four;

            studentArchive.Add(temp);
        }

        //Prints the student archive.
        public static void Prints(List<string[]> studentArchive)
        {
            foreach (var student in studentArchive)
            {
                if (!string.Join("|", student).EndsWith("|"))
                {
                    Console.WriteLine(string.Join("|", student) + "|");
                }
                else
                {
                    Console.WriteLine(string.Join("|", student));
                }
            }
        }
    }
}