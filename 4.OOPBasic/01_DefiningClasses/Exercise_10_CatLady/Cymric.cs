namespace Exercise_10_CatLady
{
    //Creates cymric object that is derived from cat. It hold information about its fur lenght.
    public class Cymric : Cat
    {
        private double furLenght;

        public double FurLenght
        {
            get
            {
                return this.furLenght;
            }
            set
            {
                this.furLenght = value;
            }
        }

        public Cymric(double furLenght, string name, string breed)
        {
            this.Breed = breed;
            this.furLenght = furLenght;
            this.Name = name;
        }
    }
}