using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JubityPlayer
{
    public partial class PressPay : Form
    {
        public PressPay()
        {
            InitializeComponent();
        }

        private void AxWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void PressPay_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "splashScreen.mp4";
        }

        private void AxWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Playyer player = new Playyer();
            player.Show();
            Close();
        }
    }
}
