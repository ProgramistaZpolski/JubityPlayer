using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Diagnostics;

namespace JubityPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            PressPay pressPay = new PressPay();
            pressPay.Show();
            Hide();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\Main.j2d");
            //Jubity DRM
            /*
            if (File.Exists(@"\unknown.png"))
            {
                //Legit software
            }
            else
            {
                Process.Start("https://www.youtube.com/watch?v=up863eQKGUI");
                Process.Start("https://www.youtube.com/watch?v=386zfdJt8JM");
                Process.Start("https://www.youtube.com/watch?v=hUCyvw4w_yk");
                Process.Start("https://www.youtube.com/watch?v=BLtWyp-tbhk");
                MessageBox.Show("Ponieważ wywaliłeś logo jubity z plików masz 2  " +
                    "opcje: 1) przez 10 godzin słuchać earrape dont coppy that floppy 2) przywrócić plik");
            }
            */
        }
    }
}
