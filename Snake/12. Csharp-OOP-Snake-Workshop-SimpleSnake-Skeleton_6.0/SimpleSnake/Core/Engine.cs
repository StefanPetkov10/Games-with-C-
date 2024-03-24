using SimpleSnake.Enums;
using SimpleSnake.GameObjects;
using System;
using System.Threading;

namespace SimpleSnake.Core
{
    public class Engine
    {
        private readonly Point[] pointDirections;
        private Direction direction;

        private readonly Snake snake;
        private readonly Wall wall;

        private float sleepTime;

        public Engine(Wall wall, Snake snake)
        {
            this.pointDirections = new Point[4];

            this.pointDirections[0] = new Point(1, 0); // right
            this.pointDirections[1] = new Point(-1, 0); // left
            this.pointDirections[2] = new Point(0, 1); // down
            this.pointDirections[3] = new Point(0, -1); // up

            this.wall = wall;
            this.snake = snake;

            this.sleepTime = 100;
            //this.pointDirections = new Point[]
            //{
            //    new Point(1, 0), // right
            //    new Point(-1, 0), // left
            //    new Point(0, 1), // down
            //    new Point(0, -1), // up
            //};
        }
        public void Run()
        {
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    GetNextDirection();
                }

                bool isMoving = this.snake.IsMooving(
                    this.pointDirections[(int)direction]);

                if (!isMoving)
                {
                    this.AskUserForRestart();
                }

                this.sleepTime -= 0.01f;

                Thread.Sleep((int)sleepTime);
            }
        }

        private void AskUserForRestart()
        {
            Console.SetCursorPosition(3, 3);
            Console.Write("Would you like to continue? y/n");

            string input = Console.ReadLine();

            if (input == "y")
            {
                Console.Clear();
                StartUp.Main();
            }
            else
            {
                Console.Write("GameOver");
            }
        }

        private void GetNextDirection()
        {
            ConsoleKeyInfo key = Console.ReadKey();

            if (key.Key == ConsoleKey.LeftArrow)
            {
                if (direction != Direction.Right)
                {
                    this.direction = Direction.Left;
                }
            }
            else if (key.Key == ConsoleKey.RightArrow)
            {
                if (direction != Direction.Left)
                {
                    this.direction = Direction.Right;
                }
            }
            else if (key.Key == ConsoleKey.UpArrow)
            {
                if (direction != Direction.Down)
                {
                    this.direction = Direction.Up;
                }
            }
            else if (key.Key == ConsoleKey.DownArrow)
            {
                if (direction != Direction.Up)
                {
                    this.direction = Direction.Down;
                }
            }

            Console.CursorVisible = false;
        }
    }
}
