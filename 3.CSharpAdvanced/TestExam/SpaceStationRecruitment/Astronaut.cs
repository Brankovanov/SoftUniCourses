namespace SpaceStationRecruitment
{
    public class Astronaut
    {
        private string name;
        private int age;
        private string country;



        public string Name { get => this.name; set => this.name = value; }

        public string Country { get => this.country; set => this.country = value; }
        public int Age { get => this.age; set => this.age = value; }

        public Astronaut(string name, int age, string country)
        {
            this.Name = name;
            this.Age = age;
            this.Country = country;
        }

        public override string ToString()
        {
            return $"Astronaut: {this.Name}, {this.Age}, ({this.country})";
        }
    }
}