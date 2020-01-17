using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleSnake.GameObjects
{
    public class Snake
    {
      
        private const char snakeSymbol = '\u25CF';
        private Food[] foods;
        private int foodIndex;
        private int nextLeftX;
        private int nextTopY;
        private Wall wall;
        private Queue<Point> snakeElements;

        private void CreateSnake()
        {
            for (int topY = 1; topY <= 6; topY++)
            {
                this.snakeElements.Enqueue(new Point(2, topY));
            }
        }
        private int RandomFoodNumber => new Random().Next(0, this.foods.Length);
        private void GetFoods()
        {
            this.foods[0] = new Foods.FoodHash(this.wall);
            this.foods[1] = new Foods.FoodDollar(this.wall);
            this.foods[2] = new Foods.FoodAsterix(this.wall);
        }

        private void GetNextPoint(Point direction, Point snakeHead)
        {
            this.nextLeftX = snakeHead.LeftX + direction.LeftX;
            this.nextTopY = snakeHead.TopY + direction.TopY;

        }

        

        public bool IsMoving(Point direction)
        {
            Point currentSnakeHead = this.snakeElements.Last();

             GetNextPoint(direction, currentSnakeHead);

            bool isPointOfSnake = this.snakeElements.Any(x => x.LeftX == nextLeftX && x.TopY == nextTopY);

            if (isPointOfSnake)
            {
                return false;
            }

            Point snakeNewHead = new Point(this.nextLeftX, this.nextTopY);

            if (this.wall.IsPointOfWall(snakeNewHead))
            {
                return false;
            }
            this.snakeElements.Enqueue(snakeNewHead);
            snakeNewHead.Draw(snakeSymbol);

            if (this.foods[this.foodIndex].IsFoodPoint(snakeNewHead))
            {
                this.Eat(direction, currentSnakeHead);
            }

            Point snakeTail = this.snakeElements.Dequeue();
            snakeTail.Draw(' ');

            return true;
        }

        private void Eat(Point direction, Point currentSnakeHead)
        {
            int length = foods[foodIndex].FoodPoints;

            for(int i =0; i< length; i++)
            {
                this.snakeElements.Enqueue(new Point(this.nextLeftX, this.nextTopY));

            }

            this.foodIndex = this.RandomFoodNumber;
            this.foods[foodIndex].SetRandomPosition(this.snakeElements);
        }


        public Snake(Wall wall)
        {
            this.wall = wall;
            this.snakeElements = new Queue<Point>();
            this.foods = new Food[3];
            this.foodIndex = RandomFoodNumber;
            this.GetFoods();
            this.CreateSnake();
        }

    }
}
