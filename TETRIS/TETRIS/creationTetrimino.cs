using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TETRIS
{
    class creationTetrimino : Tetrimino
    {
        private static Tetrimino[] arr;
        private int fallTick = 0;

        public creationTetrimino()
        {
            arr = new Tetrimino[]
            {
                new Tetrimino {
                    width = 2,
                    height = 2,
                    baseLeft = 7,
                    baseRight = 8,
                    name = "o",
                    shape = new int[,]
                    
                    {
                       { 1, 1 },
                       { 1, 1 }
                    }
                },

                new Tetrimino {
                    width = 1,
                    height = 4,
                    baseLeft = 7,
                    baseRight = 7,
                    name = "i",
                    shape = new int[,]

                    {
                       { 1 },
                       { 1 },
                       { 1 },
                       { 1 }
                    }
                },

                new Tetrimino {
                    width = 3,
                    height = 2,
                    baseLeft = 6,
                    baseRight = 8,
                    name = "s",
                    shape = new int[,]

                    {
                       { 0, 1, 1 },
                       { 1, 1, 0 },
                    }
                },

                new Tetrimino {
                    width = 3,
                    height = 2,
                    baseLeft = 6,
                    baseRight = 8,
                    name = "z",
                    shape = new int[,]

                    {
                       { 1, 1, 0 },
                       { 0, 1, 1 },
                    }
                },

                new Tetrimino {
                    width = 3,
                    height = 2,
                    baseLeft = 6,
                    baseRight = 8,
                    name = "l",
                    shape = new int[,]

                    {
                       { 1, 1, 1 },
                       { 1, 0, 0 },
                    }
                },

                new Tetrimino {
                    width = 3,
                    height = 2,
                    baseLeft = 6,
                    baseRight = 8,
                    name = "j",
                    shape = new int[,]

                    {
                       { 1, 1, 1 },
                       { 0, 0, 1 },
                    }
                },

                new Tetrimino {
                    width = 3,
                    height = 2,
                    baseLeft = 6,
                    baseRight = 8,
                    name = "t",
                    shape = new int[,]

                    {
                       { 1, 1, 1 },
                       { 0, 1, 0 },
                    }
                },

            };
        } //end of constructor

        public Tetrimino randomShape()
        {
           var rand = new Random();
            int choose = rand.Next(0, 6);
            return arr[choose];
        }

        public Tetrimino appear(Tetrimino T)
        {
            int currentX = 7;
            int currentY = -T.height;
            return T;
        }

        public void fall(int timer, Tetrimino T)
        {
            //speed increases with time
        }

        public void move()
        {
            //move the shape to the right, left or bottom according to the input
        }

        public void gameOver()
        {
            //if the shape touch the top of the area, the game stop
        }
    }
}
