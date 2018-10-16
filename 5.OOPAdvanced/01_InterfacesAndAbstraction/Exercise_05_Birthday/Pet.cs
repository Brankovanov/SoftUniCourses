namespace Exercise_05_Birthday
{
    //Class derived from IBorn interface. Holds pet's name and birthdate.
    public class Pet : IBorn
    {
        private string birthDate;
        private string name;

        public string BirthDate
        {
            get
            {
                return this.birthDate;
            }
            set
            {
                this.birthDate = value;
            }
        }

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

        public Pet(string birthDate, string name)
        {
            this.Name = name;
            this.BirthDate = birthDate;
        }
    }
}