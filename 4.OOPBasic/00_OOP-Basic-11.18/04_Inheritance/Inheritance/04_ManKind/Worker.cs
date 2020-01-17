using System;

namespace _04_ManKind
{
    public class Worker : Human
    {
        private decimal weekSalary;
        private int workHours;


        public decimal WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
            set
            {
                if (value > 10)
                {
                    this.weekSalary = value;
                }
                else
                {
                    throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
                }
            }
        }

        public int WorkHours
        {
            get
            {
                return this.workHours;
            }
            set
            {
                if (value >= 1 && value <= 12)
                {
                    this.workHours = value;
                }
                else
                {
                    throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
                }
            }
        }

        public Worker(string firstName, string secondName, decimal weekSalary, int workHours)
            : base(firstName, secondName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHours = workHours;
        }

        public decimal CalculateSalaryPerHour()
        {
            return (this.weekSalary / 5) / this.WorkHours;
        }

        public override string ToString()
        {
            return base.ToString() + $"Week Salary: {string.Format("{0:0.00}", this.WeekSalary)}" + Environment.NewLine +
                $"Hours per day: {string.Format("{0:0.00}", this.WorkHours)}" + Environment.NewLine +
                $"Salary per hour:{string.Format("{0:0.00}", CalculateSalaryPerHour())}";
        }
    }
}