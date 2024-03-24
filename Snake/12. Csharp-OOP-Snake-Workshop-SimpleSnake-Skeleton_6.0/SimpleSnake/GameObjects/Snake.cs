using System.Collections.Generic;

namespace SimpleSnake.GameObjects
{
    public class Snake
    {
        private Queue<Point> snake;
        private Food[] food;
        private Wall wall;

        private int nextLeftX;
        private int nextTopY;

        public Snake(Wall wall)
        {
            this.snake = new Queue<Point>();
            this.food = new Food[3];

            this.GetFoods();
            this.CreateSnake();
            this.wall = wall;
        }

        public bool IsPointOfWall(Point snakeHead)
            => snakeHead.LeftX == 0 || snakeHead.LeftX == this.wall.LeftX || snakeHead.TopY == 0 || snakeHead.TopY == this.wall.TopY;


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
