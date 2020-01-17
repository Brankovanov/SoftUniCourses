using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleSnake.GameObjects
{
    public class Food : Point
    {
        private Wall wall;
        private Random random;
        private char foodSymbol;
        public int FoodPoints { get; set; }
       


        public void SetRandomPosition(Queue<Point> snakeElements)
        {
            this.LeftX = random.Next(2, wall.LeftX - 2);
            this.TopY = random.Next(2, wall.TopY - 2);

            bool isPointOfSnake = snakeElements.
                Any(x => x.LeftX == this.LeftX && x.TopY == this.TopY);

            while (isPointOfSnake)
            {
                this.LeftX = this.random.Next(2, this.wall.LeftX - 2);
                this.TopY = this.random.Next(2, this.wall.TopY - 2);

               isPointOfSnake = snakeElements.
               Any(x => x.LeftX == this.LeftX && x.TopY == this.TopY);
            }


            Console.BackgroundColor = ConsoleColor.Red;
            this.Draw(foodSymbol);
            Console.BackgroundColor = ConsoleColor.White;

        }

        public bool IsFoodPoint(Point snake)
        {
            return this.TopY == this.TopY &&
                this.LeftX == this.LeftX;

        }

        

        protected Food(Wall wall, char foodSymbol, int points)
            : base(wall.LeftX, wall.TopY)
        {
            this.wall = wall;
            this.FoodPoints = points;
            this.foodSymbol = foodSymbol;
            this.random = new Random();
        }
    }
}
