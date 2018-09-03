using System;

namespace Exercise_07_Animals
{
    //Child class of cat. It can produce specific sound.
    public class Tomcat : Cat
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
                if (string.IsNullOrEmpty(value) || value != "Male")
                {
                    throw new ArgumentException("Invalid input!");
                }
                else
                {
                    this.gender = value;
                }
            }
        }

        public Tomcat(string name, int age, string gender, string kind)
           : base(name, age, gender, kind)
        {
        }

        public override string ProduceSound()
        {
            return "Give me one million b***h";
        }
    }
}