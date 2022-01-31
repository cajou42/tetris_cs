using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TETRIS
{
    class Tetrimino
    {
        public int width;
        public int height;
        public int[,] shape;
        private int[,] backup;
        public string name;
        public Brush brush;

        public void turn()
        {
            backup = shape;
            shape = new int[width, height];
            for(int i  = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    shape[i, j] = backup[height - 1 - j, i];
                }
            }
            var temp = width;
            width = height;
            height = temp;
        }

        public void rollback()
        {
            shape = backup;

            var temp = width;
            width = height;
            height = temp;
        }
    }
}
