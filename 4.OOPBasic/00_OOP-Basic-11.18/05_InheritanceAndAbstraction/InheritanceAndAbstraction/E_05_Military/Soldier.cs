

namespace E_05_Military
{
    public class Soldier : ISoldier
    {
        private string id;
        private string firstName;
        private string lastName;

        public string Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }

        public string FistsName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                this.lastName = value;
            }
        }

        public Soldier(string id, string firstName,string lastName)
        {
            this.Id = id;
            this.FistsName = firstName;
            this.LastName = lastName;
        }

        public override string ToString()
        {
            return $"Name: {this.firstName} {lastName} Id: {id}";
        }
    }
}
