using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_10_GroupByGroup
{
    public class GroupByGroup
    {
        public static void Main(string[] args)
        {
            Receive();
        }

        //Receives students information from the console.
        public static void Receive()
        {
            var student = Console.ReadLine();
            var studentList = new SortedDictionary<string, List<Student>>();
            var group = string.Empty;
            var name = string.Empty;

            while (student != "END")
            {
                var temp = student.Split(' ').ToList();
                group = temp.Last();
                name = string.Join(" ", temp[0], temp[1]);

                Student newStudent = new Student();
                newStudent.Group = group;
                newStudent.Name = name;

                if (studentList.ContainsKey(group))
                {
                    studentList[group].Add(newStudent);
                }
                else if (!studentList.ContainsKey(group))
                {
                    studentList.Add(group, new List<Student>());
                    studentList[group].Add(newStudent);
                }

                name = string.Empty;
                student = Console.ReadLine();
            }

            SortStudents(studentList);
        }

        //Sorts the collection of students by their low grades.
        public static void SortStudents(SortedDictionary<string, List<Student>> studentList)
        {
            var output = string.Empty;

            foreach (var st in studentList)
            {
                Console.Write(st.Key + " - ");

                foreach (var ob in st.Value)
                {
                    output += ob.Name + ", ";

                }

                Console.WriteLine(output.Remove(output.Length - 2, 2));
                output = string.Empty;
            }
        }

        //Class Student. Creates objects newStudent that holds students name and group.
        public class Student
        {
            private string group;
            private string name;

            public string Group
            {
                get
                {
                    return this.group;
                }
                set
                {
                    this.group = value;
                }
            }

            public string Name
            {
                get
                {
                    return this.name;
                }
                set
                {
                    this.name = value;
                }
            }

            public Student()
            {
                this.name = Name;
                this.group = Group;
            }
        }
    }
}