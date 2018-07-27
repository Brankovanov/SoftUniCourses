using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_11_SortBySpeciality
{
    public class SortBySpeciality
    {
        public static void Main(string[] args)
        {
            Receive();
        }

        //Receives students information from the console.
        public static void Receive()
        {
            var input = Console.ReadLine();
            var specialityList = new List<Speciality>();
            var specialityName = string.Empty;
            var specialtyNumber = string.Empty;

            while (input != "Students:")
            {
                var temp = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                specialtyNumber = temp.Last().Trim();
                specialityName = string.Join(" ", temp.Where(t => t != temp.Last())).Trim();

                Speciality newSpeciality = new Speciality();
                newSpeciality.SpecialtyName = specialityName;
                newSpeciality.SpecialtyNumber = specialtyNumber;
                specialityList.Add(newSpeciality);

                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            var studentList = new List<Student>();
            var group = string.Empty;
            var name = string.Empty;

            while (input != "END")
            {
                var temp = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                group = temp.First().Trim();
                name = string.Join(" ", temp.Where(n => n != group)).Trim();

                Student newStudent = new Student();
                newStudent.FacultyNumber = group;
                newStudent.Name = name;
                studentList.Add(newStudent);

                input = Console.ReadLine();
            }

            SortStudents(studentList, specialityList);
        }

        //Sorts the collection of students by their low grades.
        public static void SortStudents(List<Student> studentList, List<Speciality> specialityList)
        {
            foreach (var st in studentList.OrderBy(n => n.Name))
            {
                foreach (var sp in specialityList)
                {
                    if (sp.SpecialtyNumber == st.FacultyNumber)
                    {
                        Console.WriteLine(string.Join(" ", st.Name, st.FacultyNumber, sp.SpecialtyName));
                    }
                }
            }
        }

        //Class Student. Creates objects newStudent that holds students name and group.
        public class Student
        {
            private string facultyNumber;
            private string name;

            public string FacultyNumber
            {
                get
                {
                    return this.facultyNumber;
                }
                set
                {
                    this.facultyNumber = value;
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
                this.facultyNumber = FacultyNumber;
            }
        }

        //Class Speciality. Creates objects newSSpeciality that holds speciality name and faculty number.
        public class Speciality
        {
            private string specialtyNumber;
            private string specialtyName;

            public string SpecialtyNumber
            {
                get
                {
                    return this.specialtyNumber;
                }
                set
                {
                    this.specialtyNumber = value;
                }
            }

            public string SpecialtyName
            {
                get
                {
                    return this.specialtyName;
                }
                set
                {
                    this.specialtyName = value;
                }
            }

            public Speciality()
            {
                this.specialtyName = SpecialtyName;
                this.specialtyNumber = SpecialtyNumber;
            }
        }
    }
}