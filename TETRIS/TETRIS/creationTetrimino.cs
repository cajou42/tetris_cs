using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TETRIS
{
    class creationTetrimino : Tetrimino
    {
        private static Tetrimino[] arr;

        public creationTetrimino()
        {
            arr = new Tetrimino[]
            {
                new Tetrimino {
                    width = 2,
                    height = 2,
                    name = "o",
                    shape = new int[,]
                    
                    {
                       { 1, 1 },
                       { 1, 1 }
                    },
                    brush = Brushes.Yellow
                },

                new Tetrimino {
                    width = 1,
                    height = 4,
                    name = "i",
                    shape = new int[,]

                    {
                       { 1 },
                       { 1 },
                       { 1 },
                       { 1 }
                    },
                    brush = Brushes.Cyan
                },

                new Tetrimino {
                    width = 3,
                    height = 2,
                    name = "s",
                    shape = new int[,]

                    {
                       { 0, 1, 1 },
                       { 1, 1, 0 },
                    },
                    brush = Brushes.Red
                },

                new Tetrimino {
                    width = 3,
                    height = 2,
                    name = "z",
                    shape = new int[,]

                    {
                       { 1, 1, 0 },
                       { 0, 1, 1 },
                    },
                    brush = Brushes.Green
                },

                new Tetrimino {
                    width = 3,
                    height = 2,
                    name = "l",
                    shape = new int[,]

                    {
                       { 1, 1, 1 },
                       { 1, 0, 0 },
                    },
                    brush = Brushes.OrangeRed
                },

                new Tetrimino {
                    width = 3,
                    height = 2,
                    name = "j",
                    shape = new int[,]

                    {
                       { 1, 1, 1 },
                       { 0, 0, 1 },
                    },
                    brush = Brushes.Blue
                },

                new Tetrimino {
                    width = 3,
                    height = 2,
                    name = "t",
                    shape = new int[,]

                    {
                       { 1, 1, 1 },
                       { 0, 1, 0 },
                    },
                    brush = Brushes.Purple
                },

            };
        }

        public Tetrimino randomShape()
        {
           var rand = new Random();
            int choose = rand.Next(0, 6);
            return arr[choose];
        }
    }
}
