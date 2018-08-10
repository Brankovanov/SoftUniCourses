using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_03_CompanyRooster
{
    public class CompanyRoooster
    {
        public static void Main()
        {
            ReceiveEmployeeInformation();
        }

        //Receives information for the employees from the console.
        public static void ReceiveEmployeeInformation()
        {
            var numberOfEmployers = int.Parse(Console.ReadLine());
            var company = new Dictionary<string, List<Employee>>();

            for (var index = 1; index <= numberOfEmployers; index++)
            {
                var information = Console.ReadLine();
                CreateEmployeeInformation(information, company);
            }

            CalculateHighestAverageSalary(company);
        }

        //Records the workers' profiles sorted by departments.
        public static void CreateEmployeeInformation(string information, Dictionary<string, List<Employee>> company)
        {
            var temp = information.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            var name = temp[0];
            var salary = decimal.Parse(temp[1]);
            var position = temp[2];
            var department = temp[3];
            var email = string.Empty;
            var age = 0;

            if (temp.Length == 6)
            {               
                email = temp[4];
                age = int.Parse(temp[5]);

                var emp = new Employee(name, salary, position, department, email, age);
                Record(emp, company, department);
            }
            else if (temp.Length == 5)
            {
                var checker = int.TryParse(temp[4], out age);

                if (checker)
                {
                    var emp = new Employee(name, salary, position, department, age);
                    Record(emp, company, department);
                }
                else
                {
                    email = temp[4];
                    var emp = new Employee(name, salary, position, department, email);
                    Record(emp, company, department);
                }
            }
            else if (temp.Length == 4)
            {
                var emp = new Employee(name, salary, position, department);
                Record(emp, company, department);
            }
        }

        //Records the workers' profiles in the dictionary.
        public static void Record(Employee emp, Dictionary<string, List<Employee>> company, string department)
        {
            if (!company.ContainsKey(department))
            {
                company.Add(department, new List<Employee>());
            }
            if (company.ContainsKey(department))
            {
                company[department].Add(emp);
            }
        }

        //Calculates the highest average salary.
        public static void CalculateHighestAverageSalary(Dictionary<string, List<Employee>> company)
        {
            var averageSalary = 0.0m;
            var highestAverageSalary = 0.0m;
            var dep = string.Empty;

            foreach (var department in company)
            {
                foreach (var employee in department.Value)
                {
                    averageSalary += employee.Salary;
                }

                averageSalary = averageSalary / department.Value.Count;

                if (highestAverageSalary < averageSalary)
                {
                    highestAverageSalary = averageSalary;
                    dep = department.Key;
                }

                averageSalary = 0.0m;
            }

            Print(company, highestAverageSalary, dep);
        }

        //Prints the department with the highest average salary.
        public static void Print(Dictionary<string, List<Employee>> company, decimal highestAverageSalary, string dep)
        {
            Console.WriteLine("Highest Average Salary: " + dep);

            foreach (var empl in company[dep].OrderByDescending(e => e.Salary))
            {
                Console.WriteLine(string.Join(" ", empl.Name, string.Format("{0:0.00}", empl.Salary), empl.Email, empl.Age));
            }
        }
    }
}