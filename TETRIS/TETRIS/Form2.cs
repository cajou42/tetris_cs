using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace TETRIS
{
    public partial class Form2 : Form
    {
        private const string Filename = @"C:\Users\louis\Desktop\Tetris_cs\TETRIS\TETRIS\image\Nice bro.png";
        private int _tick;
        private int fallingTick;
        Pen blackPen = new Pen(Color.Black, 3);
        private static creationTetrimino game = new creationTetrimino();
        private Graphics graph;
        private Graphics bases;
        private Bitmap baseImage;
        private Graphics insert;
        private Bitmap piece;
        private Tetrimino T;
        private int[,] area;

        public Form2()
        {
            InitializeComponent();
            //Timer
            aTimer.Interval = 1000; //milisecunde
            aTimer.Start();

            label1.Text = "0 sec";


            pictureBox1.Width = 325;
            pictureBox1.Height = 20 * 20;
            baseImage = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            bases = Graphics.FromImage(baseImage);
            pictureBox1.Image = baseImage;
            area = new int [13, 20];
            T = game.randomShape();
            fallingTimer.Interval = 800;
            fallingTimer.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _tick++;
            label1.Text = _tick.ToString() + " sec";

        }
        private void pictureBox1_Paint_1(object sender, PaintEventArgs e)
        {
            //horizontale
            graph = e.Graphics;
            for (int i = 0; i < 20; i++)
            {
                graph.DrawLine(blackPen, 0, i * 25, 64 * 25, i * 25);
            }

            //verticale
            for (int x = 0; x < 14; ++x)
            {
                graph.DrawLine(blackPen, x * 25, 0, x * 25, 64 * 25);
            }
        }
        


        private Tetrimino draw(Tetrimino T)
        {
            piece = new Bitmap(baseImage);
            insert = Graphics.FromImage(piece);

            for (int i = 0; i < T.width; i++)
            {
                for (int j = 0; j < T.height; j++)
                {
                    if(T.shape[j, i] == 1)
                    {
                        insert.FillRectangle(Brushes.Black, (7 + i) * 25, (0 + j) * 25, 25, 25);
                    }
                }
            }
            pictureBox1.Image = piece;
            return T;
        }

        private void insertGrid(Tetrimino T, int lateral = 7, int vertical = 0)
        {
            for (int i = 0; i < T.width; i++)
            {
                for (int j = 0; j < T.height; j++)
                {
                    if (T.shape[j, i] == 1)
                    {
                        area[lateral+i,vertical+j] = 1;
                    }
                }
            }
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            insertGrid(T);
            draw(T);
            if (e.KeyCode == Keys.Left)
            {
                if (T.baseLeft > 0 && area[T.baseLeft--,0] != 1)
                {
                    int temp = T.baseLeft - 1; 
                    insertGrid(T,temp);
                    draw(T);
                }
            }
            else if(e.KeyCode == Keys.Right)
            {
                if (T.baseRight < area.Length && area[T.baseRight++, 0] != 0)
                {
                    int temp = T.baseRight - 1;
                    insertGrid(T, temp);
                    draw(T);
                }
            }
        }
        private void gameOver()
        {
            
        }

        private void fallingTimer_Tick(object sender, EventArgs e)
        {
            int desc = 0;
            fallingTick++;
            desc++;
            insertGrid(T,7,desc);

        }
    }
}
