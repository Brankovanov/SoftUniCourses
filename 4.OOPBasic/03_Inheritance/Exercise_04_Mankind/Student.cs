using System;
using System.Linq;

namespace Exercise_04_Mankind
{
    //Creates a derived clas student that holds the person's faculty number., also his names.
    public class Student : Human
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
                if (value.Length >= 5 && value.Length <= 10)
                {
                    if (value.All(char.IsLetterOrDigit))
                    {
                        this.facultyNumber = value;
                    }
                    else
                    {
                        throw new ArgumentException("Invalid faculty number!");
                    }
                }
                else
                {
                    throw new ArgumentException("Invalid faculty number!");
                }
            }
        }

        public Student(string firstName, string lastName, string facultyNumber)
            : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }
    }
}