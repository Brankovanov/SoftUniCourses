namespace Reflection
{
    public class Person:Human,IFreeTime,IJob
    {
        public string publicNumber = "1234";
        public int publicName = 1234;
        private string name;
        private string position;
        private double salary;

     
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
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
                this.position = value;
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

        public Person(string name, int age,double salary, string position)
            :base( age)
        {
            this.Name = name;
            this.Salary = salary;
            this.position = position;
        }

        public string GoToWork()
        {
            return "Working...";
        }

        public string Sleep()
        {
            return "Sleeping...";
        }

        public string Relax()
        {
            return "Relaxing...";
        }

        public int Calculate(int age,double salary)
        {
            return age - (int)salary;
        }
    }
}
