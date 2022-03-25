using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net.Mail;
using System.Net;

namespace Bluesound
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            System.Windows.Forms.Form.CheckForIllegalCrossThreadCalls = false;

        }
        int x = 0;
        int y = 0;
        bool location = false;
       
        private void Form2_Load(object sender, EventArgs e)
        {
            button1.BackgroundImage = Image.FromFile("geribildirim/close.png");
            this.BackgroundImage = Image.FromFile("geribildirim/back.jpg");
            pictureBox1.Image = Image.FromFile("geribildirim/tiger.png");
            pictureBox2.Image = Image.FromFile("geribildirim/soundtiger.png");
            button2.Image = Image.FromFile("geribildirim/send.png");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
            location = true;
        }

        private void Form2_MouseUp(object sender, MouseEventArgs e)
        {
            location = false;
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            if (location == true)
            {
                this.Location = new Point(Cursor.Position.X - x, Cursor.Position.Y - y);
            }
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            button2.BackColor = Color.Indigo;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.Transparent;
        }


        private void prognessbar()
        {
            try
            {
                //gönderme islemini yapacak
                progressBar1.Visible = true;
                progressBar1.Value = 80;
                Thread.Sleep(200);
                progressBar1.Value = 100;
                Thread.Sleep(500);
                progressBar1.Visible = false;
                label6.Text = "Geri bildirim gönderildi";
                TelegramSendMessage();
                Thread.Sleep(3000);
                label6.Text = "";
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen ağ bağlantınızı kontrol ediniz\nsorun hala devam ediyorsa windows ağ teşhirlerini çalıştırınız");
            }
   

        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("LÜTFEN TÜM ALANLARI DOLDURUNUZ", "BOŞ ALANLAR VAR", MessageBoxButtons.OK);
            }
            else
            {
                Thread progness = new Thread(new ThreadStart(prognessbar));
                progness.Start();
            }
          

        }

        string apilToken = "2054371522:AAFkP4gpLHo3tcY2XH-qZ3PfqIe0BU7MQkc";
        string destID = "2077055690";
        
        public string TelegramSendMessage()
        {

            string text = "isim: " + textBox2.Text + " " + "Eposta: " + textBox3.Text + "\n" + "Konu: " + comboBox1.Text + "\n" + "Açıklama: " + textBox1.Text;
            string urlString = $"https://api.telegram.org/bot{apilToken}/sendMessage?chat_id={destID}&text={text}";

            WebClient webclient = new WebClient();
            return webclient.DownloadString(urlString);



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button2.Enabled = true;
        }
    }
}
