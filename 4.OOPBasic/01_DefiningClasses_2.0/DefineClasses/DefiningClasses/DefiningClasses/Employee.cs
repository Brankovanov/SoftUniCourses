namespace DefiningClasses
{
    public class Employee
    {
        private string name;
        private decimal salary;
        private string position;
        private string department;
        private string email;
        private int age;


        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value != string.Empty)
                {
                    this.name = value;
                }
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
                if (value != 0)
                {
                    this.salary = value;
                }
            }
        }

        public string Position
        {
            get
            {
                return this.position;
            }
            set
            {
                if (value != string.Empty)
                {
                    this.position = value;
                }
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
                if (value != string.Empty)
                {
                    this.department = value;
                }
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                if (value != string.Empty)
                {
                    this.email = value;
                }
                else
                {
                    this.email = "n/a";
                }
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value != 0)
                {
                    this.age = value;
                }
                else
                {
                    this.age = -1;
                }
            }
        }

        public Employee(string name, decimal salary, string position,
            string department,string email, int age)
        {
            this.Name = name;
            this.Salary = salary;
            this.Position = position;
            this.Department = department;
            this.Email = email;
            this.Age = age;
        }
    }
}

