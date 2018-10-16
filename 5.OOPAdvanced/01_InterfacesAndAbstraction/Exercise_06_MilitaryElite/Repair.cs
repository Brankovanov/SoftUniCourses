namespace Exercise_06_MilitaryElite
{
    //Class repair derived from the IRepair interface.
    public class Repair : IRepair
    {
        private string partName;
        private int hoursWork;

        public string PartName
        {
            get
            {
                return this.partName;
            }
            private set
            {
                this.partName = value;
            }
        }

        public int HoursWork
        {
            get
            {
                return this.hoursWork;
            }
            private set
            {
                this.hoursWork = value;
            }
        }

        public Repair(string partName, int hoursWork)
        {
            this.PartName = partName;
            this.HoursWork = hoursWork;
        }

        public override string ToString()
        {
            return $"  Part Name: {this.partName} Hours Worked: {this.hoursWork} ";
        }
    }
}