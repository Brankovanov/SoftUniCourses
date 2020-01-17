namespace Reflection
{
  public  class Human
    {
        private int age;
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }
        }

        public Human(int age)
        {
            this.Age = age;
        }
    }
}
