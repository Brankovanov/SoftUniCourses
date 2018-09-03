using System;

namespace Exercise_04_Mankind
{
    public class StartUp
    {
        static void Main()
        {
            var student = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var worker = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            try
            {
                var newStudent = new Student(student[0], student[1], student[2]);
                var newWorker = new Worker(worker[0], worker[1], decimal.Parse(worker[2]), int.Parse(worker[3]));

                Console.WriteLine("First Name: " + newStudent.FirstName);
                Console.WriteLine("Last Name: " + newStudent.LastName);
                Console.WriteLine("Faculty number: " + newStudent.FacultyNumber);
                Console.WriteLine();

                Console.WriteLine("First Name: " + newWorker.FirstName);
                Console.WriteLine("Last Name: " + newWorker.LastName);
                Console.WriteLine("Week Salary: " + string.Format("{0:0.00}", newWorker.WeekSalary));
                Console.WriteLine("Hours per day: " + string.Format("{0:0.00}", newWorker.WorkHoursPerDay));
                Console.WriteLine("Salary per hour: " + string.Format("{0:0.00}", newWorker.CalculateMoneyPerHour()));
                Console.WriteLine();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}