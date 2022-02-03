using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            SoundPlayer NOST = new SoundPlayer(@"c:\Users\louis\tetris_cs\music\Tetris_theme.ogg);
            NOST.Play();
        }

        private void insideOption_Click(object sender, EventArgs e)
        {

        }
    }
}
