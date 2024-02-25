using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise_task_7_labirintGame
{
    internal class Labirint
    {
        public char[,] map;

        public Labirint() { }

        public void ReadMap(string mapName, out int playerX, out int playerY)
        {
            playerX = 0; playerY = 0;

            string[] file = File.ReadAllLines($"maps/{mapName}.txt");
            map = new char[file.Length, file[0].Length];

            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    map[i, j] = file[i][j];

                    if (map[i, j] == '■') { playerX = i; playerY = j; }
                }
            }
        }

        public void DrawMap()
        {
            Console.Clear();
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    Console.Write(map[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
