using System;

namespace SimpleSnake.GameObjects
{
    public class Wall : Point
    {

        private const char wallSymbol = '■'; // \u25A0

        public Wall(int leftX, int topY)
            : base(leftX, topY)
        {
            this.InitializeBorders();
        }

        private void InitializeBorders()
        {
            SetHorizontalBorder(0);
            SetVerticalBorder(0);
            SetVerticalBorder(this.LeftX - 1);
            SetHorizontalBorder(this.TopY);

        }

        private void SetHorizontalBorder(int y)
        {
            Console.SetCursorPosition(0, y);

            for (int i = 0; i < this.LeftX; i++)
            {
                Console.Write(wallSymbol);
            }
        }

        private void SetVerticalBorder(int x)
        {
            for (int i = 1; i < this.TopY; i++)
            {
                Console.SetCursorPosition(x, i);
                Console.Write(wallSymbol);
            }
        }
    }
}
//private void InitializeBorders()
//{
//    for (int i = 0; i < 50; i++)
//    {
//        Console.Write("-");
//    }

//    for (int i = 1; i < 10; i++)
//    {
//        Console.SetCursorPosition(0, i);
//        Console.Write("-");
//    }

//    for (int i = 1; i < 10; i++)
//    {
//        Console.SetCursorPosition(49, i);
//        Console.Write("-");
//    }

//    Console.SetCursorPosition(0, 10);

//    for (int i = 0; i < 50; i++)
//    {
//        Console.Write("-");
//    }
//}