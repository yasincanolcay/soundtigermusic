using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bluesound
{
    public partial class welcome : Form
    {
        public welcome()
        {
            InitializeComponent();
        }

        int x = 0;
        int y = 0;
        bool location = false;
        private void welcome_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "about/jah.mp3";
            axWindowsMediaPlayer1.settings.volume = 20;
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            Form1 anaform = new Form1();
            anaform.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            this.Close();
                
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void welcome_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
            location = true;
        }

        private void welcome_MouseUp(object sender, MouseEventArgs e)
        {
            location = false;

        }

        private void welcome_MouseMove(object sender, MouseEventArgs e)
        {
            if (location == true)
            {
                this.Location = new Point(Cursor.Position.X - x, Cursor.Position.Y - y);
            }
        }
    }
}
