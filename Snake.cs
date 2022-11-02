using System;
using System.Collections.Generic;

namespace SnakeGame
{
    public class Snake
    {
        ConsoleKeyInfo keyInfo = new ConsoleKeyInfo();
        char key = 'w';
        char currentDirection = 'u';
        List<Position> snakeBody;

        public int x { get; set; }
        public int y { get; set; }
        public Snake()
        {
            x = 20;
            y = 20;
            snakeBody = new List<Position>();

            snakeBody.Add(new Position(x, y));
        }

        public void drawSnake()
        {
            foreach (Position pos in snakeBody)
            {
                Console.SetCursorPosition(pos.x, pos.y);
                Console.Write("▇");
            }
        }

        public void Input()
        {
            if (Console.KeyAvailable)
            {
                keyInfo = Console.ReadKey(true);
                key = keyInfo.KeyChar;
            }
        }

        public void moveSnake()
        {
            direction();

            switch (currentDirection)
            {
                case 'u':
                    y--;
                    break;
                case 'd':
                    y++;
                    break;
                case 'l':
                    x--;
                    break;
                case 'r':
                    x++;
                    break;
            }

            // move the snake
            snakeBody.Add(new Position(x, y));
            snakeBody.RemoveAt(0);
            Thread.Sleep(100);
        }

        private void direction()
        {

            // can't turn to opposite direction of currentDirection
            if (key == 'w' && currentDirection != 'd')
            {
                currentDirection = 'u';
            }
            else if (key == 's' && currentDirection != 'u')
            {
                currentDirection = 'd';
            }
            else if (key == 'd' && currentDirection != 'l')
            {
                currentDirection = 'r';
            }
            else if (key == 'a' && currentDirection != 'r')
            {
                currentDirection = 'l';
            }
        }
    }
}