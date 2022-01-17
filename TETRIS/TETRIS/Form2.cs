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
        private Font fnt = new Font("Arial", 10);

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
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _tick++;
            label1.Text = _tick.ToString() + " sec";

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graph = e.Graphics;
            for (int i = 0; i < 20; i++)
            {
                graph.DrawLine(blackPen, 0, i * 25, 64 * 25, i * 25);
            }

            for (int x = 0; x < 12; ++x)
            {
                graph.DrawLine(blackPen, x * 25, 0, x * 25, 64 * 25);
            }
        }
    }
}
