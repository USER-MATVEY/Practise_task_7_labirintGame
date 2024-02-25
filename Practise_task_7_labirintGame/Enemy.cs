using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise_task_7_labirintGame
{
    internal class Enemy
    {
        private int positionX;
        private int positionY;

        public int X { get { return positionX; } set { positionX = value; } }
        public int Y { get { return positionY; } set { positionY = value; } }

        public Enemy(int positionX, int positionY)
        {
            this.positionX = positionX;
            this.positionY = positionY;
        }

        public void MoveChoice(Labirint labirint)
        {
            Random random = new Random();
            switch (random.Next(0, 4))
            {
                case 0: MoveUp(labirint); break;
                case 1: MoveDown(labirint); break;
                case 2: MoveLeft(labirint); break;
                case 3: MoveRight(labirint); break;
            }
        }

        void MoveUp(Labirint labirint)
        {
            if (CanMove(labirint, positionX - 1, positionY))
            {
                labirint.map[positionX, positionY] = ' ';
                positionX--;
                labirint.map[positionX, positionY] = '¤';
            }
        }

        void MoveDown(Labirint labirint)
        {
            if (CanMove(labirint, positionX + 1, positionY))
            {
                labirint.map[positionX, positionY] = ' ';
                positionX++;
                labirint.map[positionX, positionY] = '¤';
            }
        }
        void MoveLeft(Labirint labirint)
        {
            if (CanMove(labirint, positionX, positionY - 1))
            {
                labirint.map[positionX, positionY] = ' ';
                positionY--;
                labirint.map[positionX, positionY] = '¤';
            }
        }
        void MoveRight(Labirint labirint)
        {
            if (CanMove(labirint, positionX, positionY + 1))
            {
                labirint.map[positionX, positionY] = ' ';
                positionY++;
                labirint.map[positionX, positionY] = '¤';
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
