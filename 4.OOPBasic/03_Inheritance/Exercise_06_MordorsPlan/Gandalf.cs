namespace Exercise_06_MordorsPlan
{
    //Creates a Gandalf object that holds Gandalf's happiness,
    //method that calculates how it chnages according to his food and a method that indicates his mood.
    public class Gandalf
    {
        private int happiness;

        public int Happiness
        {
            get
            {
                return this.happiness;
            }
            set
            {
                this.happiness = value;
            }
        }

        public void Eat(string foodItem, FoodItems newItems)
        {
            this.Happiness += newItems.Feed(foodItem);
        }

        public string Mood()
        {
            if (this.Happiness < -5)
            {
                return "Angry";
            }
            else if (this.Happiness >= -5 && this.Happiness <= 0)
            {
                return "Sad";
            }
            else if (this.Happiness >= 1 && this.Happiness <= 15)
            {
                return "Happy";
            }
            else if (this.Happiness > 15)
            {
                return "JavaScript";
            }

            return string.Empty;
        }
    }
}