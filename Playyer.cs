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
    
    public partial class Playyer : Form
    {
        public byte speeeeeeeeed;
        public Playyer()
        {
            InitializeComponent();
        }

        private void Playyer_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\level0.j2d");
            pictureBox2.ImageLocation = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\sharedassets.j2d");
            speeeeeeeeed = Convert.ToByte(File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\speed.j2d"));
        }

        private void Playyer_KeyDown(object sender, KeyEventArgs e)
        {
            int x = pictureBox2.Location.X;
            int y = pictureBox2.Location.Y;

            if (e.KeyCode == Keys.Right) x += speeeeeeeeed;
            else if (e.KeyCode == Keys.Left) x -= speeeeeeeeed;
            else if (e.KeyCode == Keys.Up) y -= speeeeeeeeed;
            else if (e.KeyCode == Keys.Down) y += speeeeeeeeed;

            pictureBox2.Location = new Point(x, y);
        }
    }
}
