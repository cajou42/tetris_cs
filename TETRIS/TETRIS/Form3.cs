using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TETRIS
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            //MyProject.Computer.Audio.Play(test.My.Resources.TAMUSIQUEICI, AudioPlayMode.Background);
            //string filename = "Alarm09.wav";
            //string path = Path.Combine(Environment.CurrentDirectory, @"music\", filename);
            //SoundPlayer NOST = new SoundPlayer(path);
            //NOST.Play();
            //NOST.PlayLooping();
        }

        private void tuto_Click(object sender, EventArgs e)
        {
            MessageBox.Show("the piece fall over time and block when they touch the bottom of the grid or an other piece\n" +
                "you can move the pieces with the right and left arrows, and turn them with up arrows \n" + 
                "if the pieces reach the top of the grid, its game over\n" +
                "to increase your score complete a line, when a line is complete she disappear, and other block fall\n" +
                "you can see the next piece at the right of the grid\n" +
                "higher your score is, the higher the pieces fall");
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form1 obj1 = new Form1();
            obj1.Show();
            this.Hide();
        }
    }
}
