namespace SimpleSnake
{
    using SimpleSnake.GameObjects;
    using Utilities;

    public class StartUp
    {
        public static void Main()
        {
            ConsoleWindow.CustomizeConsole();

            //Point point = new Point(10, 10);
            //point.Draw('@');

            Wall wall = new Wall(50, 20);
        }
    }
}
