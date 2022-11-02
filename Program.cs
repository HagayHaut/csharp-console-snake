namespace SnakeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Canvas canvas = new Canvas();
            Snake snake = new Snake();
            bool finished = false;

            while (!finished)
            {
                canvas.drawCanvas();
                snake.Input();
                snake.drawSnake();
                snake.drawSnake();
            }
        }
    }
}