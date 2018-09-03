using System;

namespace Exercise_04_Mankind
{
    //Creates a derived class worker that hold the worker's week salary, the hours of work per day and the worker's name.
    public class Worker : Human
    {
        private decimal weekSalary;
        private int workHoursPerDay;

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

        public int WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            set
            {
                if (value >= 1 && value <= 12)
                {
                    this.workHoursPerDay = value;
                }
                else
                {
                    throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
                }
            }
        }

        public decimal CalculateMoneyPerHour()
        {
            var moneyPerHour = (weekSalary / 5) / workHoursPerDay;
            return moneyPerHour;
        }

        public Worker(string firstName, string lastName, decimal weekSalary, int workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }
    }
}