using System;

namespace Exercise_07_Animals
{
    //Child class of cat. It can produce specific sound.
    public class Kitten : Cat
    {
        private string gender;

        public override string Gender
        {
            get
            {
                return this.gender;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || value != "Female")
                {
                    throw new ArgumentException("Invalid input!");
                }
                else
                {
                    this.gender = value;
                }
            }
        }

        public Kitten(string name, int age, string gender, string kind)
            : base(name, age, gender, kind)
        {
        }

        public override string ProduceSound()
        {
            return "Miau";
        }
    }
}