using System;
using System.Collections.Generic;
using System.Text;

namespace P03_StudentSystem
{
    public class CommandProccessor
    {
        public void ParseCommand(StudentSystem studentSystem)
        {
            string[] args = Console.ReadLine().Split();

            if (args[0] == "Create")
            {
                var name = args[1];
                var age = int.Parse(args[2]);
                var grade = double.Parse(args[3]);
                if (!studentSystem.Repo.ContainsKey(name))
                {
                    var student = new Student(name, age, grade);
                    studentSystem.Repo[name] = student;
                }
            }
            else if (args[0] == "Show")
            {
                var name = args[1];
                if (studentSystem.Repo.ContainsKey(name))
                {
                    var student = studentSystem.Repo[name];
                    string view = $"{student.Name} is {student.Age} years old.";

                    if (student.Grade >= 5.00)
                    {
                        view += " Excellent student.";
                    }
                    else if (student.Grade < 5.00 && student.Grade >= 3.50)
                    {
                        view += " Average student.";
                    }
                    else
                    {
                        view += " Very nice person.";
                    }

                    Console.WriteLine(view);
                }

            }
            else if (args[0] == "Exit")
            {
                Environment.Exit(0);
            }
        }
    }
}
