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
            int exitX;
            int exitY;

            Player player = new Player();
            Labirint labirint = new Labirint();
            List<Enemy> enemies = new List<Enemy>();

            labirint.ReadMap("level01", out positionX, out positionY, out enemies, out exitX, out exitY);

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
                for (int i = 0; i < enemies.Count; i++)
                {
                    enemies[i].MoveChoice(labirint);
                }
                if (player.X == exitX &&  player.Y == exitY)
                {
                    break;
                }
            }
            Console.WriteLine("\n\nВы Выйграли!!!");
        }
    }
}
