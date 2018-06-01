using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Exercise_08_AverageGrades
{
    public class averageGrades
    {
        public static void Main(string[] args)
        {
            ProccessInputFile();            
        }

        //Приема информация за студентите от файл input.txt.
        static void ProccessInputFile()
        {           
            List<string> listOfStudents = File.ReadAllLines("./input.txt").ToList();
            List<string> listOfClasses = new List<string>();
            var student = string.Empty;
            var numberOfStudents = 0;

            try
            {
                for (var index = 0; index <= listOfStudents.Count - 1; index++)
                {
                    int.TryParse(listOfStudents[index], out numberOfStudents);
                    if (numberOfStudents == 0)
                    {
                        student = listOfStudents[index];
                        listOfClasses.Add(student);
                        student = string.Empty;
                    }
                    else if (numberOfStudents != 0)
                    {
                        
                    }

                }
            }
            finally
            {
                CalculateAverageGrade(listOfClasses);
                listOfClasses.Clear();
            }

            PrintOutput();            
        }

        //Изчислява средна оценка.
        static void CalculateAverageGrade(List<string> listOfClasses)
        {
            List<Student> final = new List<Student>();
            List<string> temp = new List<string>();
            var averageGrade = 0.0;
            var studentName = string.Empty;

            foreach (var student in listOfClasses)
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

            CreateOutputFile(final);
        }

        //Създава обект newStudent, който съдържа име и средна оценка.
        static void CreateStudents(string studentName, double averageGrade, List<Student> final)
        {
            Student newStudent = new Student();
            newStudent.Name = studentName;
            newStudent.AverageGrade = averageGrade;
            final.Add(newStudent);
        }

        //Създава филе output.txt, който съдържа имнената и средната оценка на учениците.
        static void CreateOutputFile(List<Student> final)
        {
            File.Delete("./output.txt");
            final = final.OrderBy(x => x.Name).ThenByDescending(y => y.AverageGrade).ToList();

            foreach (var s in final)
            {
                if (s.AverageGrade >= 5)
                {
                    File.AppendAllText("./output.txt", s.Name + " -> " + String.Format("{0:0.00}", s.AverageGrade) + "\r\n"); 
                }
            }
        }

        //Принтира съдържанието на файл output.txt.
        static void PrintOutput()
        {
            Console.WriteLine(File.ReadAllText("./output.txt"));
        }
    }

    //Клас Student, съдържа името на студента и средната му оценка.
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