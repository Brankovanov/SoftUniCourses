namespace Exercise_08_Google
{
    //Creates a company object that holds the name of the company where the person works, his department and his salary.
    public class Company
    {
        private string companyName;
        private string department;
        private double salary;

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

        public double Salary
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

        public Company(string companyName, string department, double salary)
        {
            this.companyName = companyName;
            this.department = department;
            this.salary = salary;
        }
    }
}