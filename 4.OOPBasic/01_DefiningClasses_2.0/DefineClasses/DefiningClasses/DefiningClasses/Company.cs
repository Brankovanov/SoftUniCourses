using System;

namespace DefiningClasses
{
    public class Company
    {
        private string companyName;
        private string department;
        private decimal salary;

        public string CompanyName
        {
            get
            {
                return this.companyName;
            }
            set
            {
                this.companyName = value;
            }
        }

        public string Department
        {
            get
            {
                return this.department;
            }
            set
            {
                this.department = value;
            }
        }

        public decimal Salary
        {
            get
            {
                return this.salary;
            }
            set
            {
                this.salary = value;
            }
        }

        public string Output()
        {
            var output = string.Empty;

            if (this.Salary != 0)
            {
                output = Environment.NewLine+ this.CompanyName + " " + this.Department + " " + salary+ Environment.NewLine;
            }
            else
            {
                return Environment.NewLine;
            }
            return output;
        }
    }
}
