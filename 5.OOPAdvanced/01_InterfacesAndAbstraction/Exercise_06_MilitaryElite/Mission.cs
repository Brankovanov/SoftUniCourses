namespace Exercise_06_MilitaryElite
{
    //Mission class derived from IMission interface. It holds the mission's codename and state.
    public class Mission : IMission
    {
        private string codeName;
        private string state;

        public string State
        {
            get
            {
                return this.state;
            }
            set
            {
                if (value == "inProgress" || value == "Finished")
                {
                    this.state = value;
                }
                else
                {
                    return;
                }
            }
        }

        public string CodeName
        {
            get
            {
                return this.codeName;
            }
            private set
            {
                this.codeName = value;
            }
        }

        public void CompleteMission()
        {
            this.state = "Finished";
        }

        public Mission(string codeName, string status)
        {
            this.CodeName = codeName;
            this.State = status;
        }

        public override string ToString()
        {
            return $"Code Name: {this.codeName} State: {this.state} ";
        }
    }
}