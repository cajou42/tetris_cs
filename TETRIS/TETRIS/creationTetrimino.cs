﻿using System;
using System.Collections.Generic;
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
                    }
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
                    }
                },

                new Tetrimino {
                    width = 3,
                    height = 3,
                    name = "s",
                    shape = new int[,]

                    {
                       { 0, 1, 1 },
                       { 1, 1, 0 },
                    }
                },

                new Tetrimino {
                    width = 3,
                    height = 3,
                    name = "z",
                    shape = new int[,]

                    {
                       { 1, 1, 0 },
                       { 0, 1, 1 },
                    }
                },

                new Tetrimino {
                    width = 3,
                    height = 3,
                    name = "l",
                    shape = new int[,]

                    {
                       { 1, 1, 1 },
                       { 1, 0, 0 },
                    }
                },

                new Tetrimino {
                    width = 3,
                    height = 3,
                    name = "j",
                    shape = new int[,]

                    {
                       { 1, 1, 1 },
                       { 0, 0, 1 },
                    }
                },

                new Tetrimino {
                    width = 3,
                    height = 3,
                    name = "t",
                    shape = new int[,]

                    {
                       { 1, 1, 1 },
                       { 0, 1, 0 },
                    }
                },

            };
        } //end of constructor

        public void fall(int timer)
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
