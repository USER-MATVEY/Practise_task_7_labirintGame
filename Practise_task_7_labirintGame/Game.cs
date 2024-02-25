using System;

namespace Practise_task_7_labirintGame
{
    class Programm
    {
        static void Main()
        {
            ConsoleKeyInfo key;

            int positionX;
            int positionY;

            Player player = new Player();
            Labirint labirint = new Labirint();

            labirint.ReadMap("level01", out positionX, out positionY);

            player.X = positionX;
            player.Y = positionY;

            Console.SetWindowSize(labirint.map.GetLength(0) * 3, labirint.map.GetLength(1) + 3);

            while (true)
            {
                labirint.DrawMap();
                key = Console.ReadKey();
                if (key.Key == ConsoleKey.UpArrow)
                {
                    player.MoveUp(labirint);
                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    player.MoveDown(labirint);
                }
                else if (key.Key == ConsoleKey.LeftArrow)
                {
                    player.MoveLeft(labirint);
                }
                else if (key.Key == ConsoleKey.RightArrow)
                {
                    player.MoveRight(labirint);
                }
            }
        }
    }
}
