namespace SnakeGame
{
    public class Canvas
    {

        public int Width { get; set; }
        public int Height { get; set; }

        public Canvas()
        {
            Width = 50;
            Height = 30;

            Console.CursorVisible = false;
        }

        public void drawCanvas()
        {
            Console.Clear();

            for (int i = 0; i < Width; i++)
            {
                Console.SetCursorPosition(i, 0);
                Console.Write("--");
            }

            for (int i = 0; i < Width; i++)
            {
                Console.SetCursorPosition(i, Height);
                Console.Write("--");
            }

            for (int i = 0; i < Height; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write('-');
            }

            for (int i = 0; i < Height; i++)
            {
                Console.SetCursorPosition(Width, i);
                Console.Write('-');
            }
        }
    }
}