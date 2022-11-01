using System;
namespace SnakeGame
{
    public class Snake
    {
        ConsoleKeyInfo keyInfo = new ConsoleKeyInfo();
        char key = 'w';

        public int x { get; set; }
        public int y { get; set; }
        public Snake()
        {
            x = 20;
            y = 20;
        }

        public void drawSnake()
        {
            Console.SetCursorPosition(x, y);
            Console.Write("▇");
        }

        public void Input()
        {
            if (Console.KeyAvailable)
            {
                key = keyInfo.KeyChar;
            }
        }
    }
}