using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_04_AverageGrades
{
    public class averageGrades
    {
        public static void Main(string[] args)
        {
            ReceiveStudentInformation();
        }

        //Приема информация за студентите от конзолата.
        static void ReceiveStudentInformation()
        {
            List<string> listOfStudents = new List<string>();
            var student = string.Empty;
            var numberOfStudents = int.Parse(Console.ReadLine());

            for (var index = 0; index <= numberOfStudents - 1; index++)
            {
                student = Console.ReadLine();
                listOfStudents.Add(student);
                student = string.Empty;
            }

            CalculateAverageGrade(listOfStudents);
        }

        //Изчислява средна оценка.
        static void CalculateAverageGrade(List<string> listOfStudents)
        {
            List<Student> final = new List<Student>();
            List<string> temp = new List<string>();
            var averageGrade = 0.0;
            var studentName = string.Empty;

            foreach (var student in listOfStudents)
            {
                temp = student.Split(' ').ToList();
                studentName = temp[0];

                for (var innerIndex = 1; innerIndex <= temp.Count - 1; innerIndex++)
                {
                    averageGrade += double.Parse(temp[innerIndex]);
                }

                averageGrade = averageGrade / (temp.Count - 1);

                CreateStudents(studentName, averageGrade, final);

                temp.Clear();
                averageGrade = 0.0;
                studentName = string.Empty;
            }

            Print(final);
        }

        //Създава обект newStudent, който съдържа име и средна оценка.
        static void CreateStudents(string studentName, double averageGrade, List<Student> final)
        {
            Student newStudent = new Student();
            newStudent.Name = studentName;
            newStudent.AverageGrade = averageGrade;
            final.Add(newStudent);
        }

        //Принтира средната името и средната оценка на студента.
        static void Print(List<Student> final)
        {
            final = final.OrderBy(x => x.Name).ThenByDescending(y => y.AverageGrade).ToList();

            foreach (var s in final)
            {
                if (s.AverageGrade >= 5)
                {
                    Console.WriteLine(s.Name + " -> " + String.Format("{0:0.00}", s.AverageGrade));
                }
            }
        }
    }

    //Клас Student.
    public class Student
    {
        private string name;
        private double averageGrade;

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

        public double AverageGrade
        {
            get
            {
                return this.averageGrade;
            }
            set
            {
                this.averageGrade = value;
            }
        }

        public Student()
        {
            this.name = Name;
            this.averageGrade = AverageGrade;
        }
    }
}
