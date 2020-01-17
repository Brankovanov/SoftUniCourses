namespace Lab_04_GandalfTheHungry
{
    public class Gandalf
    {
        private int mood;

        public int Mood
        {
            get
            {
                return this.mood;
            }
            set
            {
                this.mood = value;
            }
        }

        public Gandalf()
        {
            this.Mood = 0;
        }

        public void Eat(string food)
        {
            switch (food.ToLower())
            {
                case "cram":
                    this.Mood += 2;
                    break;
                case "lembas":
                    this.Mood += 3;
                    break;
                case "apple":
                    this.Mood += 1;
                    break;
                case "melon":
                    this.Mood += 1;
                    break;
                case "honeycake":
                    this.Mood += 5;
                    break;
                case "mushrooms":
                    this.Mood -= 10;
                    break;
                default:
                    this.Mood -= 1;
                    break;
            }
        }


        public string CalculateMood()
        {
            if (this.Mood < -5)
            {
                return "Anglry";
            }
            else if (this.Mood >= -5 && this.Mood <= 0)
            {
                return "Sad";
            }
            else if (this.Mood >= 1 && this.Mood <= 15)
            {
                return "Happy";
            }
            else if (this.Mood > 15)
            {
                return "JavaScript";
            }

            return string.Empty;
        }
    }
}
