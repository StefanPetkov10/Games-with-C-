using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleSnake.GameObjects
{
    public abstract class Food : Point
    {
        private readonly char foodSymbol;
        private readonly Random random;
        private readonly Wall wall;

        protected Food(Wall wall, char foodSymbol, int points)
            : base(0, 0)
        {
            this.wall = wall;
            this.foodSymbol = foodSymbol;
            this.FoodPoints = points;

            this.random = new Random();
        }

        public int FoodPoints { get; private set; }

        public bool IsFoodPoint(Point snakeHead)
            => snakeHead.TopY == this.TopY && snakeHead.LeftX == this.LeftX;


        public void SetRandomPosition(Queue<Point> snake)
        {
            this.LeftX = this.random.Next(1, this.wall.LeftX - 1);
            this.TopY = this.random.Next(1, this.wall.TopY - 1);

            bool isPartOfSnake = snake
                .Any(x => x.TopY == this.TopY && x.LeftX == this.LeftX);

            while (isPartOfSnake)
            {
                this.LeftX = this.random.Next(1, this.wall.LeftX - 1);
                this.TopY = this.random.Next(1, this.wall.TopY - 1);

                isPartOfSnake = snake
                    .Any(x => x.TopY == this.TopY && x.LeftX == this.LeftX);
            }

            Console.BackgroundColor = ConsoleColor.Red;

            //Console.SetCursorPosition(this.LeftX, this.TopY);
            //Console.Write(this.foodSymbol);
            this.Draw(foodSymbol);

            Console.BackgroundColor = ConsoleColor.White;
        }
    }
}
