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
        private static creationTetrimino game = new creationTetrimino();
        private Graphics graph;
        private Graphics bases;
        private Bitmap baseImage;
        private Graphics insert;
        private Bitmap piece;

        public Form2()
        {
            InitializeComponent();
            //Timer
            aTimer.Interval = 1000; //milisecunde
            aTimer.Start();

            label1.Text = "0 sec";

            //for(int i = 0; i <= 6; i++)
            //{
            //    //ici il faudra probablement faire une double boucle for
            //    DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
            //    row.Cells[i].Value = "alu";
            //    dataGridView1.Rows.Add(row);

            //}

            //Bitmap alu = new Bitmap(Filename, true);
            //alu.Save(Filename);



            pictureBox1.Width = 15 * 20;
            pictureBox1.Height = 20 * 20;
            baseImage = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            bases = Graphics.FromImage(baseImage);
            pictureBox1.Image = baseImage;
            int[,] area = new int [15, 20];
            draw();
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
            ////horizontale
            //graph = e.Graphics;
            //for (int i = 0; i < 20; i++)
            //{
            //    graph.DrawLine(blackPen, 0, i * 25, 64 * 25, i * 25);
            //}

            ////verticale
            //for (int x = 0; x < 13; ++x)
            //{
            //    graph.DrawLine(blackPen, x * 25, 0, x * 25, 64 * 25);
            //}
        }
        
        private void draw()
        {
            Tetrimino T = game.randomShape();
            piece = new Bitmap(baseImage);
            insert = Graphics.FromImage(piece);

            for (int i = 0; i < T.width; i++)
            {
                for (int j = 0; j < T.height; j++)
                {
                    if(T.shape[j, i] == 1)
                    {
                        insert.FillRectangle(Brushes.Black, (7 + i) * 25, (-T.height + j) * 25, 25, 25);
                    }
                }
            }
            pictureBox1.Image = baseImage;
        }


    }
}
