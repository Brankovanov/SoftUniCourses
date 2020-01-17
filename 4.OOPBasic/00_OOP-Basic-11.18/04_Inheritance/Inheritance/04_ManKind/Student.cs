using System;

namespace _04_ManKind
{
    public class Student:Human
    {
        private string facultyNumber;

        public string FacultyNumber
        {
            get
            {
                return this.facultyNumber;
            }
            set
            {
                if (value.Length >= 5 && value.Length <= 100)
                {
                    this.facultyNumber = value;
                }
                else
                {
                    throw new ArgumentException("Invalid faculty number!");
                }
            }
        }


        public Student(string firstName, string secondName, string facultyNumber)
            :base(firstName,secondName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public override string ToString()
        {
            return base.ToString() + $"Faculty Number: {this.FacultyNumber}";
        }

    }
}
