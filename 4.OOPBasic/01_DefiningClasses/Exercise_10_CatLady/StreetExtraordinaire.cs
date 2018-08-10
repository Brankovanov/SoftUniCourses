namespace Exercise_10_CatLady
{
    //Creates street extraordinare object that is derived from cat. It hold information about its meow decibels.
    public class StreetExtraordinaire : Cat
    {
        private int decibelsOfMeows;

        public int DecibelsOfMeows
        {
            get
            {
                return this.decibelsOfMeows;
            }
            set
            {
                this.decibelsOfMeows = value;
            }
        }

        public StreetExtraordinaire(int decibelsOfMeows, string name, string breed)
        {
            this.Breed = breed;
            this.decibelsOfMeows = decibelsOfMeows;
            this.Name = name;
        }
    }
}