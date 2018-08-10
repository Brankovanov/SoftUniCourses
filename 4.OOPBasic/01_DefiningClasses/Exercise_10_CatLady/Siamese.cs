namespace Exercise_10_CatLady
{
    //Creates siamese object that is derived from cat. It hold information about its ear size.
    public class Siamese : Cat
    {
        private int earSize;

        public int EarSize
        {
            get
            {
                return this.earSize;
            }
            set
            {
                this.earSize = value;
            }
        }

        public Siamese(int earSize, string name, string breed)
        {
            this.Breed = breed;
            this.earSize = earSize;
            this.Name = name;
        }
    }
}