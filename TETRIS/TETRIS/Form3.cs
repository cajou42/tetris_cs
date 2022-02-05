using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TETRIS
{
    public partial class Form3 : Form
    {
        private string[] tab = new string[] {"Tetris_theme", "Oceanic Breeze", "magical-girl", "hades-house-of-hades", "scattered-and-lost" };
        public int click;
        public string music = "Tetris_theme";
        [DllImport("winmm.dll")]
        public static extern int waveOutGetVolume(IntPtr hwo, out uint dwVolume);

        [DllImport("winmm.dll")]
        public static extern int waveOutSetVolume(IntPtr hwo, uint dwVolume);
        public Form3()
        {
            InitializeComponent();       
            info.Text = tab[0];
            label2.Text = "composer : Hirokazu Tanaka \n from : Tetris gameBoy";
            uint CurrVol = 0;
            waveOutGetVolume(IntPtr.Zero, out CurrVol);
            ushort CalcVol = (ushort)(CurrVol & 0x0000ffff);
            trackBar1.Value = CalcVol / (ushort.MaxValue / 10);
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
            Form1 obj1 = new Form1(music);
            obj1.Show();
            this.Hide();
        }

        private void changeMusic_Click(object sender, EventArgs e)
        {
            click++;
            if (click == tab.Length)
            {
                click = 0;
            }
            info.Text = tab[click];
            music = tab[click];
            switch (click)
            {
                case 0:
                    label2.Text = "composer : Hirokazu Tanaka \n from : Tetris gameBoy";
                    break;
                case 1:
                    label2.Text = "composer : flashygoodness \n cover : PrototypeRaptor - OC ReMix \n remix from : fraymaker \n originaly from : Rivals of Aether";
                    break;
                case 2:
                    label2.Text = "composer : Guitar Vader \n from : Jet Set Radio";
                    break;
                case 3:
                    label2.Text = "composer : Darren Korb \n from : Hades";
                    break;
                case 4:
                    label2.Text = "composer : Lena Raine \n from : celeste";
                    break;
            }
        }

        private void info_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int NewVolume = ((ushort.MaxValue / 10) * trackBar1.Value);
            uint NewVolumeAllChannels = (((uint)NewVolume & 0x0000ffff) | ((uint)NewVolume << 16));
            waveOutSetVolume(IntPtr.Zero, NewVolumeAllChannels);
        }
    }
}
