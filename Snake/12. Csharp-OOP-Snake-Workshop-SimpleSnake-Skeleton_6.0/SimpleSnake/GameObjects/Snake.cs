using System.Collections.Generic;

namespace SimpleSnake.GameObjects
{
    public class Snake
    {
        private Queue<Point> snake;

        public Snake()
        {
            this.snake = new Queue<Point>();

            this.CreateSnake();
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
