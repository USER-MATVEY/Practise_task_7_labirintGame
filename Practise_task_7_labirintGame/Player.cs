using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise_task_7_labirintGame
{
    internal class Player
    {
        private int positionX;
        private int positionY;

        public int X { get { return positionX; } set { positionX = value; } }
        public int Y { get { return positionY; } set { positionY = value; } }

        public Player()
        {
            positionX = 0;
            positionY = 0;
        }

        public void MoveUp(Labirint labirint)
        {
            if (CanMove(labirint, positionX - 1, positionY))
            {
                labirint.map[positionX, positionY] = ' ';
                positionX--;
                labirint.map[positionX, positionY] = '■';
            }
        }

        public void MoveDown(Labirint labirint)
        {
            if (CanMove(labirint, positionX + 1, positionY))
            {
                labirint.map[positionX, positionY] = ' ';
                positionX++;
                labirint.map[positionX, positionY] = '■';
            }
        }
        public void MoveLeft(Labirint labirint)
        {
            if (CanMove(labirint, positionX, positionY - 1))
            {
                labirint.map[positionX, positionY] = ' ';
                positionY--;
                labirint.map[positionX, positionY] = '■';
            }
        }
        public void MoveRight(Labirint labirint)
        {
            if (CanMove(labirint, positionX, positionY + 1))
            {
                labirint.map[positionX, positionY] = ' ';
                positionY++;
                labirint.map[positionX, positionY] = '■';
            }
        }

        private bool CanMove(Labirint labirint, int posX, int posY)
        {
            if (posY == 0 || posX == 0) return false;
            else if (posY == labirint.map.GetLength(0) || posX == labirint.map.GetLength(1)) return false;
            else if (labirint.map[posX, posY] == ' ') return true;
            return false;
        }
    }
}
