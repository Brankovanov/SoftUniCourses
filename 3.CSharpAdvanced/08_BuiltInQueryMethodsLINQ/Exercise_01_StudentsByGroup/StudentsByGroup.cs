using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_01_StudentsByGroup
{
    public class StudentsByGroup
    {
        public static void Main(string[] args)
        {
            ReceiveStudentsInformation();
        }

        //Receives students' information from the console.
        public static void ReceiveStudentsInformation()
        {
            var studentInfo = Console.ReadLine();
            var groupStudents = new Dictionary<int, List<string>>();
            var name = string.Empty;
            var group = 0;

            while (!studentInfo.Equals("END"))
            {
                var temp = studentInfo.Split(' ');
                name = temp[0] + " " + temp[1];
                group = int.Parse(temp[2]);
                SortGroups(groupStudents, name, group);
                studentInfo = Console.ReadLine();
            }

            Print(groupStudents);
        }

        //Sorts the students by thei groups.
        public static void SortGroups(Dictionary<int, List<string>> groupStudents, string name, int group)
        {
            if (groupStudents.ContainsKey(group))
            {
                groupStudents[group].Add(name);
            }
            else
            {
                groupStudents.Add(group, new List<string>());
                groupStudents[group].Add(name);
            }
        }

        //Prints group two from the dictionary on the console.
        public static void Print(Dictionary<int, List<string>> groupStudents)
        {
            Console.WriteLine(string.Join("\n", groupStudents[2].OrderBy(n => n)));
        }
    }
}