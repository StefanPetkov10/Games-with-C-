using System;

namespace SimpleSnake.GameObjects
{
    public class Wall : Point
    {
        public Wall(int leftX, int topY)
            : base(leftX, topY)
        {
            this.InitializeBorders();
        }

        private void InitializeBorders()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.Write("-");
            }

            for (int i = 1; i < 10; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write("-");
            }

            for (int i = 1; i < 10; i++)
            {
                Console.SetCursorPosition(49, i);
                Console.Write("-");
            }

            Console.SetCursorPosition(0, 10);

            for (int i = 0; i < 50; i++)
            {
                Console.Write("-");
            }
        }
    }
}
