using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TETRIS
{
    
    public partial class Form1 : Form
    {
        string music1;
        public Form1(string music)
        {
            InitializeComponent();
            this.BackgroundImage = Properties.Resources.back;
            if(music == "") {
                music1 = "Tetris_theme";
            }
            else
            {
                music1 = music;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 obj2 = new Form3();
            obj2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 obj1 = new Form2(music1);
            obj1.Show();
            this.Hide();
        }


        private void TETRIS_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
