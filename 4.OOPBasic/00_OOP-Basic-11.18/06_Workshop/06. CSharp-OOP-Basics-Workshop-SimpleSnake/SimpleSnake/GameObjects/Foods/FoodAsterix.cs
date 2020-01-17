namespace SimpleSnake.GameObjects.Foods
{
    public class FoodAsterix:Food
    {
        private const char foodSymbol = '*';
        private const int points = 1;
        public FoodAsterix(Wall wall)
            : base(wall, foodSymbol, points)
        {

        }
    }
}
