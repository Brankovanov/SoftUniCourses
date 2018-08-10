namespace Exercise_10_CatLady
{
    //Creates a cat object that holds the cat's name and breed.
    public class Cat
    {
        private string name;
        private string breed;

        public string Breed
        {
            get
            {
                return this.breed;
            }
            set
            {
                this.breed = value;
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
    }
}