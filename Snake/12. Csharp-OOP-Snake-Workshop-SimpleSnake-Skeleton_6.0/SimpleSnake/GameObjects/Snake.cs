using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleSnake.GameObjects
{
    public class Snake
    {
        private const char snakeSymbol = '■';

        private readonly Queue<Point> snake;
        private readonly Food[] food;
        private readonly Wall wall;

        private int nextLeftX;
        private int nextTopY;
        private int foodIndex;

        public Snake(Wall wall)
        {
            this.snake = new Queue<Point>();
            this.food = new Food[3];

            this.wall = wall;

            this.foodIndex = this.GetRandomPosition;

            this.GetFoods();
            this.CreateSnake();

        }

        public int GetRandomPosition
            => new Random().Next(0, this.food.Length);



        public bool IsMooving(Point direction)
        {
            Point snakeHead = this.snake.Last();

            this.GetNextDirection(direction, snakeHead);

            bool isPartOfSnake = this.snake
                .Any(x => x.LeftX == this.nextLeftX && x.TopY == this.nextTopY);
            if (isPartOfSnake)
            {
                return false;
            }

            var newHead = new Point(this.nextLeftX, this.nextTopY);

            bool isWall = this.wall.IsPointOfWall(newHead);
            if (isWall)
            {
                return false;
            }

            this.snake.Enqueue(newHead);
            newHead.Draw(snakeSymbol);

            if (this.food[foodIndex].IsFoodPoint(newHead))
            {
                this.Eat(direction, newHead);
            }

            Point tail = this.snake.Dequeue();
            tail.Draw(' ');

            return true;
        }

        private void Eat(Point direction, Point newHead)
        {
            int foodPoints = this.food[this.foodIndex].FoodPoints;

            for (int i = 0; i < foodPoints; i++)
            {
                this.snake.Enqueue(new Point(this.nextLeftX, this.nextTopY));
                GetNextDirection(direction, newHead);
            }

            this.foodIndex = this.GetRandomPosition;
            this.food[this.foodIndex].SetRandomPosition(this.snake);
        }

        private void GetNextDirection(Point direction, Point snakeHead)
        {
            this.nextLeftX = snakeHead.LeftX + direction.LeftX;
            this.nextTopY = snakeHead.TopY + direction.TopY;

        }

        private void GetFoods()
        {
            this.food[0] = new FoodAsterisk(this.wall);
            this.food[1] = new FoodDollar(this.wall);
            this.food[2] = new FoodHash(this.wall);
        }

        private void CreateSnake()
        {
            for (int leftX = 3; leftX <= 9; leftX++)
            {
                this.snake.Enqueue(new Point(leftX, 3));
            }
        }
    }
}
