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
        Pen blackPen = new Pen(Color.Black, 3);
        int canvasWidth = 15;
        int canvasHeight = 20;
        private static creationTetrimino game = new creationTetrimino();
        private Graphics graph;
        private Graphics bases;
        private Bitmap baseImage;
        private Graphics insert;
        private Bitmap piece;
        private Tetrimino T;
        private int[,] area;
        private int X;
        private int Y;
        private int iscore;

        public Form2()
        {
            InitializeComponent();
            //Timer
            aTimer.Interval = 1000; //milisecunde
            aTimer.Start();

            label1.Text = "0 sec";

            pictureBox1.Width = 375;
            pictureBox1.Height = 500;//canvasHeight * 20;
            baseImage = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            bases = Graphics.FromImage(baseImage);
            bases.FillRectangle(Brushes.LightGray, 0, 0, baseImage.Width, baseImage.Height);
            pictureBox1.Image = baseImage;
            area = new int[15, 20];
            T = arrive();
            fallingTimer.Tick += fallingTimer_Tick;
            fallingTimer.Interval = 500;
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
            for (int i = 0; i < 21; i++)
            {
                graph.DrawLine(blackPen, 0, i * 25, 64 * 25, i * 25);
            }

            //verticale
            for (int x = 0; x < 16; ++x)
            {
                graph.DrawLine(blackPen, x * 25, 0, x * 25, 64 * 25);
            }
        }

        private Tetrimino arrive()
        {
            Tetrimino shape = game.randomShape();
            X = 7;
            Y = -shape.height;
            return shape;
        }

        private void draw()
        {
            piece = new Bitmap(baseImage);
            insert = Graphics.FromImage(piece);

            for (int i = 0; i < T.width; i++)
            {
                for (int j = 0; j < T.height; j++)
                {
                    if (T.shape[j, i] == 1)
                    {
                        insert.FillRectangle(T.brush, (X + i) * 25, (Y + j) * 25, 25, 25);
                    }
                }
            }
            pictureBox1.Image = piece;
        }

        private void actualisation()
        {
            for (int i = 0; i < T.width; i++)
            {
                for (int j = 0; j < T.height; j++)
                {
                    if (T.shape[j, i] == 1)
                    {
                        gameOver();
                        area[X + i, Y + j] = 1;
                    }
                }
            }
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            int vertical = 0;
            int horizontal = 0;
            if (e.KeyCode == Keys.Left)
            {
                horizontal--;
            }
            else if (e.KeyCode == Keys.Right)
            {
                horizontal++;
            }
            else if (e.KeyCode == Keys.Down)
            {
                vertical++;
            }
            else if (e.KeyCode == Keys.Up)
            {
                T.turn();
            }
            else
            {
                return;
            }

            bool success = move(vertical, horizontal);
            if (!success && e.KeyCode == Keys.Up)
            {
                T.rollback();
            }

        }
        private void gameOver()
        {
            if (Y < 0)
            {
                fallingTimer.Stop();
                MessageBox.Show("Game Over");
                Application.Restart();
            }
        }

        private void fallingTimer_Tick(object sender, EventArgs e)
        {
            bool desc = move(vertical: 1);
            if (!desc)
            {
                baseImage = new Bitmap(piece);
                actualisation();
                T = arrive();
                clearLine();

            }

        }

        private bool move(int vertical = 0, int lateral = 0)
        {
            int newX = X + lateral;
            int newY = Y + vertical;
            if (newX < 0 || newX + T.width > canvasWidth || newY + T.height > canvasHeight)
            {
                return false;
            }

            for (int i = 0; i < T.width; i++)
            {
                for (int j = 0; j < T.height; j++)
                {
                    if (newY + j > 0 && area[newX + i, newY + j] == 1 && T.shape[j, i] == 1)
                    {
                        return false;
                    }
                }
            }

            X = newX;
            Y = newY;
            draw();
            return true;
        }

        private void clearLine()
        {
            for (int i = 0; i < canvasHeight; i++)
            {
                int j;
                for (j = canvasWidth - 1; j >= 0; j--)
                {
                    if (area[j, i] == 0)
                        break;
                }

                if (j == -1)
                {
                    iscore++;
                    label2.Text = "Score = " + iscore / 10;
                    fallingTimer.Interval -= 10;

                    for (j = 0; j < canvasWidth; j++)
                    {
                        for (int k = i; k > 0; k--)
                        {
                            area[j, k] = area[j, k - 1];
                        }

                        area[j, 0] = 0;
                    }
                }
            }

            for (int i = 0; i < canvasWidth; i++)
            {
                for (int j = 0; j < canvasHeight; j++)
                {
                    bases = Graphics.FromImage(baseImage);
                    bases.FillRectangle(
                        area[i, j] == 1 ? Brushes.Transparent : Brushes.LightGray,
                        i * 25, j * 25, 25, 25
                        );
                }
            }

            pictureBox1.Image = baseImage;
        }
    }
}
