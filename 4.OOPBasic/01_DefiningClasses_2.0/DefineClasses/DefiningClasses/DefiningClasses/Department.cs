using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class Department
    {
        private Dictionary<string,List<Employee>> departments;

        public Dictionary<string,List<Employee>> Departments
        {
            get
            {
                return this.departments;
            }
            set
            {
                this.departments = value;
            }
        }

        public Department()
        {
            this.Departments = new Dictionary<string, List<Employee>>();
        }

        public string CalculateIncome()
        {
            var income = 0M;
            var temp = 0M;
            var departmentName = string.Empty;
            var output = string.Empty;


            foreach (var department in this.Departments)
            {
                foreach (var employee in department.Value)
                {
                    temp += employee.Salary;
                }

                if(temp>income)
                {
                    income = temp;
                    departmentName = department.Key;
                }

                temp = 0;
            }

            output = $"Highest Average Salary: {departmentName}" + Environment.NewLine;
            foreach (var employ in this.Departments[departmentName].OrderByDescending(s=>s.Salary))
            {
                output += employ.Name + " " 
                    + employ.Salary + " " 
                    + employ.Email + " "
                    + employ.Age +
                    Environment.NewLine;
            }

            return output;
        }
    }
}

