
namespace E_05_Military
{
    public class Private : Soldier, IPrivate
    {
        private decimal salary;
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

        public Private(string id, string firsName, string lastName, decimal salary)
            :base(id,firsName,lastName)
        {
            this.Salary = salary;
        }

        public override string ToString()
        {
            return base.ToString() + $" Salary: {this.Salary}";
                
        }
    }
}
