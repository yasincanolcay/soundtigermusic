using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Threading;
using System.IO;
using System.Runtime.InteropServices;
using VideoLibrary;
using MediaToolkit;
using System.Text.RegularExpressions;
namespace Bluesound
{

    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
            System.Windows.Forms.Form.CheckForIllegalCrossThreadCalls = false;
        }
       
        //------------------------------------------------------------------------
        //database islemleri
        OleDbConnection kategoriler = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|categories.mdb");


        //database baglantısı tum kanallar
        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|allradio.mdb");


        //yerel muzikler icin database kontrolu 
        OleDbConnection localmusic = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|yerelmuzikler.mdb");



        //database verilerini listboxlara yazdır verileri yavaş al
        //tum kanallar kategorisi
        private void verilerigoruntule()
        {
            try
            {
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
                button12.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = false;
                button15.Enabled = false;
                button20.Enabled = false;
                button21.Enabled = false;
                button22.Enabled = false;
                button23.Enabled = false;

                kategoriler.Close();
                baglantı.Open();
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                OleDbCommand komut = new OleDbCommand();
                komut.Connection = baglantı;
                komut.CommandText = ("Select * From allradio");
                OleDbDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {


                    listBox1.Items.Add(oku["kanallar"]);
                    listBox2.Items.Add(oku["urller"]);

                    Thread.Sleep(50);




                }

                baglantı.Close();
                button4.Enabled = true;
                Thread.Sleep(10);
                button5.Enabled = true;
                Thread.Sleep(10);
                button6.Enabled = true;
                Thread.Sleep(10);
                button7.Enabled = true;
                Thread.Sleep(10);
                button8.Enabled = true;
                Thread.Sleep(10);
                button9.Enabled = true;
                Thread.Sleep(10);
                button10.Enabled = true;
                Thread.Sleep(10);
                button11.Enabled = true;
                Thread.Sleep(10);
                button12.Enabled = true;
                Thread.Sleep(10);
                button13.Enabled = true;
                Thread.Sleep(10);
                button14.Enabled = true;
                Thread.Sleep(10);
                button15.Enabled = true;
                Thread.Sleep(10);
                button20.Enabled = true;
                Thread.Sleep(10);
                button21.Enabled = true;
                Thread.Sleep(10);
                button22.Enabled = true;
                Thread.Sleep(10);
                button23.Enabled = true;
            }
            catch (Exception)
            {

                MessageBox.Show("TÜM KANALLAR YÜKLENİRKEN BEKLEYİN\nİŞLEMLER HALA SÜRÜYOR..","YÜKLEME DEVAM EDİYOR..");
            }
    
         
        }

        //akustik kategorisi
        private void akustik()
        {
            try
            {
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
                button12.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = false;
                button15.Enabled = false;
                button20.Enabled = false;
                button21.Enabled = false;
                button22.Enabled = false;
                button23.Enabled = false;
                baglantı.Close();
                kategoriler.Open();
          
                OleDbCommand categori = new OleDbCommand();
                categori.Connection = kategoriler;
                categori.CommandText = ("Select * From akustik");
                OleDbDataReader getir = categori.ExecuteReader();
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                while (getir.Read())
                {


                    listBox1.Items.Add(getir["kanallar"]);
                    listBox2.Items.Add(getir["kanalurl"]);

                    Thread.Sleep(20);
                
                }

                kategoriler.Close();
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
                button10.Enabled = true;
                button11.Enabled = true;
                button12.Enabled = true;
                button13.Enabled = true;
                button14.Enabled = true;
                button15.Enabled = true;
                button20.Enabled = true;
                button21.Enabled = true;
                button22.Enabled = true;
                button23.Enabled = true;

            }
            catch (Exception)
            {

                MessageBox.Show("KANALLAR YÜKLENİRKEN BEKLEYİNİZ\nİŞLEMLER BİTTİKTEN SONRA TEKRAR DENEYİNİZ", "YÜKLEME DEVAM EDİYOR..");
            }

        }

        //havali kategorisi
        private void havali()
        {
            try
            {
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
                button12.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = false;
                button15.Enabled = false;
                button20.Enabled = false;
                button21.Enabled = false;
                button22.Enabled = false;
                button23.Enabled = false;
                baglantı.Close();
                kategoriler.Open();

                OleDbCommand categori = new OleDbCommand();
                categori.Connection = kategoriler;
                categori.CommandText = ("Select * From havali");
                OleDbDataReader getir = categori.ExecuteReader();
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                while (getir.Read())
                {


                    listBox1.Items.Add(getir["kanallar"]);
                    listBox2.Items.Add(getir["kanalurl"]);

                    Thread.Sleep(20);

                }

                kategoriler.Close();
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
                button10.Enabled = true;
                button11.Enabled = true;
                button12.Enabled = true;
                button13.Enabled = true;
                button14.Enabled = true;
                button15.Enabled = true;
                button20.Enabled = true;
                button21.Enabled = true;
                button22.Enabled = true;
                button23.Enabled = true;

            }
            catch (Exception)
            {

                MessageBox.Show("KANALLAR YÜKLENİRKEN BEKLEYİNİZ\nİŞLEMLER BİTTİKTEN SONRA TEKRAR DENEYİNİZ", "YÜKLEME DEVAM EDİYOR..");
            }

        }

        //fitness kategorisi
        private void fitness()
        {
            try
            {
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
                button12.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = false;
                button15.Enabled = false;
                button20.Enabled = false;
                button21.Enabled = false;
                button22.Enabled = false;
                button23.Enabled = false;
                baglantı.Close();
                kategoriler.Open();

                OleDbCommand categori = new OleDbCommand();
                categori.Connection = kategoriler;
                categori.CommandText = ("Select * From fit");
                OleDbDataReader getir = categori.ExecuteReader();
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                while (getir.Read())
                {


                    listBox1.Items.Add(getir["kanallar"]);
                    listBox2.Items.Add(getir["kanalurl"]);

                    Thread.Sleep(20);

                }

                kategoriler.Close();
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
                button10.Enabled = true;
                button11.Enabled = true;
                button12.Enabled = true;
                button13.Enabled = true;
                button14.Enabled = true;
                button15.Enabled = true;
                button20.Enabled = true;
                button21.Enabled = true;
                button22.Enabled = true;
                button23.Enabled = true;

            }
            catch (Exception)
            {

                MessageBox.Show("KANALLAR YÜKLENİRKEN BEKLEYİNİZ\nİŞLEMLER BİTTİKTEN SONRA TEKRAR DENEYİNİZ", "YÜKLEME DEVAM EDİYOR..");
            }

        }

        //yalnız huzur kategorisi
        private void sakin()
        {
            try
            {
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
                button12.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = false;
                button15.Enabled = false;
                button20.Enabled = false;
                button21.Enabled = false;
                button22.Enabled = false;
                button23.Enabled = false;
                baglantı.Close();
                kategoriler.Open();

                OleDbCommand categori = new OleDbCommand();
                categori.Connection = kategoriler;
                categori.CommandText = ("Select * From sakin");
                OleDbDataReader getir = categori.ExecuteReader();
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                while (getir.Read())
                {


                    listBox1.Items.Add(getir["kanallar"]);
                    listBox2.Items.Add(getir["kanalurl"]);

                    Thread.Sleep(20);

                }

                kategoriler.Close();
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
                button10.Enabled = true;
                button11.Enabled = true;
                button12.Enabled = true;
                button13.Enabled = true;
                button14.Enabled = true;
                button15.Enabled = true;
                button20.Enabled = true;
                button21.Enabled = true;
                button22.Enabled = true;
                button23.Enabled = true;

            }
            catch (Exception)
            {

                MessageBox.Show("KANALLAR YÜKLENİRKEN BEKLEYİNİZ\nİŞLEMLER BİTTİKTEN SONRA TEKRAR DENEYİNİZ", "YÜKLEME DEVAM EDİYOR..");
            }

        }

        //hiphop kategorisi
        private void hiphop()
        {
            try
            {
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
                button12.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = false;
                button15.Enabled = false;
                button20.Enabled = false;
                button21.Enabled = false;
                button22.Enabled = false;
                button23.Enabled = false;
                baglantı.Close();
                kategoriler.Open();

                OleDbCommand categori = new OleDbCommand();
                categori.Connection = kategoriler;
                categori.CommandText = ("Select * From hiphop");
                OleDbDataReader getir = categori.ExecuteReader();
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                while (getir.Read())
                {


                    listBox1.Items.Add(getir["kanallar"]);
                    listBox2.Items.Add(getir["kanalurl"]);

                    Thread.Sleep(20);

                }

                kategoriler.Close();
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
                button10.Enabled = true;
                button11.Enabled = true;
                button12.Enabled = true;
                button13.Enabled = true;
                button14.Enabled = true;
                button15.Enabled = true;
                button20.Enabled = true;
                button21.Enabled = true;
                button22.Enabled = true;
                button23.Enabled = true;

            }
            catch (Exception)
            {

                MessageBox.Show("KANALLAR YÜKLENİRKEN BEKLEYİNİZ\nİŞLEMLER BİTTİKTEN SONRA TEKRAR DENEYİNİZ", "YÜKLEME DEVAM EDİYOR..");
            }

        }

        //eglence kategorisi
        private void eglence()
        {
            try
            {
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
                button12.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = false;
                button15.Enabled = false;
                button20.Enabled = false;
                button21.Enabled = false;
                button22.Enabled = false;
                button23.Enabled = false;
                baglantı.Close();
                kategoriler.Open();

                OleDbCommand categori = new OleDbCommand();
                categori.Connection = kategoriler;
                categori.CommandText = ("Select * From eglence");
                OleDbDataReader getir = categori.ExecuteReader();
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                while (getir.Read())
                {


                    listBox1.Items.Add(getir["kanallar"]);
                    listBox2.Items.Add(getir["kanalurl"]);

                    Thread.Sleep(20);

                }

                kategoriler.Close();
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
                button10.Enabled = true;
                button11.Enabled = true;
                button12.Enabled = true;
                button13.Enabled = true;
                button14.Enabled = true;
                button15.Enabled = true;
                button20.Enabled = true;
                button21.Enabled = true;
                button22.Enabled = true;
                button23.Enabled = true;

            }
            catch (Exception)
            {

                MessageBox.Show("KANALLAR YÜKLENİRKEN BEKLEYİNİZ\nİŞLEMLER BİTTİKTEN SONRA TEKRAR DENEYİNİZ", "YÜKLEME DEVAM EDİYOR..");
            }

        }

        private void pop()
        {
            try
            {
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
                button12.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = false;
                button15.Enabled = false;
                button20.Enabled = false;
                button21.Enabled = false;
                button22.Enabled = false;
                button23.Enabled = false;
                baglantı.Close();
                kategoriler.Open();

                OleDbCommand categori = new OleDbCommand();
                categori.Connection = kategoriler;
                categori.CommandText = ("Select * From pop");
                OleDbDataReader getir = categori.ExecuteReader();
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                while (getir.Read())
                {


                    listBox1.Items.Add(getir["kanallar"]);
                    listBox2.Items.Add(getir["kanalurl"]);

                    Thread.Sleep(20);

                }

                kategoriler.Close();
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
                button10.Enabled = true;
                button11.Enabled = true;
                button12.Enabled = true;
                button13.Enabled = true;
                button14.Enabled = true;
                button15.Enabled = true;
                button20.Enabled = true;
                button21.Enabled = true;
                button22.Enabled = true;
                button23.Enabled = true;

            }
            catch (Exception)
            {

                MessageBox.Show("KANALLAR YÜKLENİRKEN BEKLEYİNİZ\nİŞLEMLER BİTTİKTEN SONRA TEKRAR DENEYİNİZ", "YÜKLEME DEVAM EDİYOR..");
            }

        }

        private void arabesk()
        {
            try
            {
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
                button12.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = false;
                button15.Enabled = false;
                button20.Enabled = false;
                button21.Enabled = false;
                button22.Enabled = false;
                button23.Enabled = false;
                baglantı.Close();
                kategoriler.Open();

                OleDbCommand categori = new OleDbCommand();
                categori.Connection = kategoriler;
                categori.CommandText = ("Select * From arabesk");
                OleDbDataReader getir = categori.ExecuteReader();
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                while (getir.Read())
                {


                    listBox1.Items.Add(getir["kanallar"]);
                    listBox2.Items.Add(getir["kanalurl"]);

                    Thread.Sleep(20);

                }

                kategoriler.Close();
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
                button10.Enabled = true;
                button11.Enabled = true;
                button12.Enabled = true;
                button13.Enabled = true;
                button14.Enabled = true;
                button15.Enabled = true;
                button20.Enabled = true;
                button21.Enabled = true;
                button22.Enabled = true;
                button23.Enabled = true;

            }
            catch (Exception)
            {

                MessageBox.Show("KANALLAR YÜKLENİRKEN BEKLEYİNİZ\nİŞLEMLER BİTTİKTEN SONRA TEKRAR DENEYİNİZ", "YÜKLEME DEVAM EDİYOR..");
            }

        }


        private void populer()
        {
            try
            {
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
                button12.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = false;
                button15.Enabled = false;
                button20.Enabled = false;
                button21.Enabled = false;
                button22.Enabled = false;
                button23.Enabled = false;
                baglantı.Close();
                kategoriler.Open();

                OleDbCommand categori = new OleDbCommand();
                categori.Connection = kategoriler;
                categori.CommandText = ("Select * From populer");
                OleDbDataReader getir = categori.ExecuteReader();
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                while (getir.Read())
                {


                    listBox1.Items.Add(getir["kanallar"]);
                    listBox2.Items.Add(getir["kanalurl"]);

                    Thread.Sleep(20);

                }

                kategoriler.Close();
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
                button10.Enabled = true;
                button11.Enabled = true;
                button12.Enabled = true;
                button13.Enabled = true;
                button14.Enabled = true;
                button15.Enabled = true;
                button20.Enabled = true;
                button21.Enabled = true;
                button22.Enabled = true;
                button23.Enabled = true;

            }
            catch (Exception)
            {

                MessageBox.Show("KANALLAR YÜKLENİRKEN BEKLEYİNİZ\nİŞLEMLER BİTTİKTEN SONRA TEKRAR DENEYİNİZ", "YÜKLEME DEVAM EDİYOR..");
            }

        }

        private void sehirler()
        {
            try
            {
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
                button12.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = false;
                button15.Enabled = false;
                button20.Enabled = false;
                button21.Enabled = false;
                button22.Enabled = false;
                button23.Enabled = false;
                baglantı.Close();
                kategoriler.Open();

                OleDbCommand categori = new OleDbCommand();
                categori.Connection = kategoriler;
                categori.CommandText = ("Select * From sehirler");
                OleDbDataReader getir = categori.ExecuteReader();
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                while (getir.Read())
                {


                    listBox1.Items.Add(getir["kanallar"]);
                    listBox2.Items.Add(getir["kanalurl"]);

                    Thread.Sleep(20);

                }

                kategoriler.Close();
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
                button10.Enabled = true;
                button11.Enabled = true;
                button12.Enabled = true;
                button13.Enabled = true;
                button14.Enabled = true;
                button15.Enabled = true;
                button20.Enabled = true;
                button21.Enabled = true;
                button22.Enabled = true;
                button23.Enabled = true;

            }
            catch (Exception)
            {

                MessageBox.Show("KANALLAR YÜKLENİRKEN BEKLEYİNİZ\nİŞLEMLER BİTTİKTEN SONRA TEKRAR DENEYİNİZ", "YÜKLEME DEVAM EDİYOR..");
            }

        }

        private void eskiler()
        {
            try
            {
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
                button12.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = false;
                button15.Enabled = false;
                button20.Enabled = false;
                button21.Enabled = false;
                button22.Enabled = false;
                button23.Enabled = false;
                baglantı.Close();
                kategoriler.Open();

                OleDbCommand categori = new OleDbCommand();
                categori.Connection = kategoriler;
                categori.CommandText = ("Select * From eskiler");
                OleDbDataReader getir = categori.ExecuteReader();
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                while (getir.Read())
                {


                    listBox1.Items.Add(getir["kanallar"]);
                    listBox2.Items.Add(getir["kanalurl"]);

                    Thread.Sleep(20);

                }

                kategoriler.Close();
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
                button10.Enabled = true;
                button11.Enabled = true;
                button12.Enabled = true;
                button13.Enabled = true;
                button14.Enabled = true;
                button15.Enabled = true;
                button20.Enabled = true;
                button21.Enabled = true;
                button22.Enabled = true;
                button23.Enabled = true;

            }
            catch (Exception)
            {

                MessageBox.Show("KANALLAR YÜKLENİRKEN BEKLEYİNİZ\nİŞLEMLER BİTTİKTEN SONRA TEKRAR DENEYİNİZ", "YÜKLEME DEVAM EDİYOR..");
            }

        }
        //---database islemleri sonu
        //---------------------------------------------------------------------------------------------------





        //formu ekranda sürüklemek için
        int x = 0;
        int y = 0;
        bool location = false;

        //sesin seviyesine göre ikonları degiştir
        private void ses_durumu()
        {

            if (axWindowsMediaPlayer1.settings.volume == 0)
            {
                Thread.Sleep(200);
                pictureBox4.Image = null;
                pictureBox4.Image = Image.FromFile("audio/noaudio.png");//ses kapalı iconu
             
            }
            if(axWindowsMediaPlayer1.settings.volume!=0)
            {
                Thread.Sleep(200);
                pictureBox4.Image = null;
                pictureBox4.Image = Image.FromFile("audio/audio.png");//ses acık iconu

            }

        }


        //ses butonlarının yuklenmesi
        private void sound_btn()
        {
            button16.Image = Image.FromFile("audio/play.png");
            Thread.Sleep(150);
            button17.Image = Image.FromFile("audio/pause.png");
            Thread.Sleep(150);
            button18.Image = Image.FromFile("audio/stop.png");


        }


        //buton resimlerini yavaş ekle
        private void btn_load()
        {
            Thread.Sleep(200);
            button4.Image = Image.FromFile("btnpic/image.png");
            Thread.Sleep(200);
            button6.Image = Image.FromFile("btnpic/havali.png");
            Thread.Sleep(200);
            button7.Image = Image.FromFile("btnpic/fit.png");
            Thread.Sleep(200);
            button5.Image = Image.FromFile("btnpic/sakin.png");
            Thread.Sleep(200);
            button8.Image = Image.FromFile("btnpic/hiphop.png");
            Thread.Sleep(200);
            button9.Image = Image.FromFile("btnpic/eglence.png");
            Thread.Sleep(200);
            button10.Image = Image.FromFile("btnpic/pop.png");
            Thread.Sleep(200);
            button11.Image = Image.FromFile("btnpic/arabesk.png");
            Thread.Sleep(200);
            button12.Image = Image.FromFile("btnpic/acustic.png");
            Thread.Sleep(200);
            button13.Image = Image.FromFile("btnpic/populer.png");
            Thread.Sleep(200);
            button14.Image = Image.FromFile("btnpic/city.png");
            Thread.Sleep(200);
            button15.Image = Image.FromFile("btnpic/eskiler.png");
            Thread.Sleep(200);
            button20.Image = Image.FromFile("btnpic/yerel.png");
            Thread.Sleep(200);
            button21.Image = Image.FromFile("btnpic/soundtiger.png");
            Thread.Sleep(200);
            button22.Image = Image.FromFile("btnpic/geribildirim.png");
            Thread.Sleep(200);
            button23.Image = Image.FromFile("btnpic/siir.png");
          
        }

        //her kanal degistiginde resimi yenile ve burdan al
        private void animation()
        {
            Thread.Sleep(250);//hata olmaması için bekle
            pictureBox3.Height = 359;
            pictureBox3.ImageLocation = "animation/pic1.gif";
            Thread.Sleep(150);//bekle ve sonra yazdır - islemlerin bittigine emin ol
            label2.Text = listBox1.Text;

        }

        //listbox1 degerini listbox2ye esitle ve radyoyu çal
        //listbox2 visible false ve url içeriyor - hangi url denk geliyorsa ac
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //bunu dene
            try
            {
                listBox2.SelectedIndex = listBox1.SelectedIndex;
                axWindowsMediaPlayer1.URL = listBox2.SelectedItem.ToString();
                axWindowsMediaPlayer1.Ctlcontrols.play();
                Thread thread2 = new Thread(new ThreadStart(animation));
                thread2.Start(); //resim animasyonu ac
            }
            catch (Exception)  //eger hata olursa mesaj ver 
            {

                MessageBox.Show("VERİLER ALINIRKEN BEKLEYİNİZ.","KANAL LİSTESİ ALINIYOR..");
            }
           
           
        }

        //programı kapat - yukardaki carpı butonu
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //tam ekran ve normal ekran modları
        //yukardaki pencere butonu
        private void button2_Click(object sender, EventArgs e)
        {


            
            if (this.WindowState != System.Windows.Forms.FormWindowState.Maximized)
            {
                this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                splitContainer1.Panel1MinSize = 600;
                listBox4.Height = 630;

            }
            else
            {
                this.WindowState = System.Windows.Forms.FormWindowState.Normal;
                splitContainer1.Panel1MinSize = 100;
                splitContainer1.Panel2MinSize = 270;
                listBox4.Height = 470;
            }


        }



        //ekranı asagıya al
        //yukardaki cizgi butonu
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


        //mouse butonların ustune gelince ve ayrılınca
        private void button4_MouseMove(object sender, MouseEventArgs e)
        {
            //iptal
           // button4.BackColor = SystemColors.ButtonHighlight;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.Transparent;

        }

        private void button11_Click(object sender, EventArgs e)
        {
            //yazılacak
        }

        //form yuklenirken veri tabanını yükle thread ile
        //ve butonları thread ile yavas yukle
        private void Form1_Load(object sender, EventArgs e)
        {
    


            //kanalların yuklenmesi ve veritabanından alınması
            Thread thread1 = new Thread(new ThreadStart(verilerigoruntule));
            thread1.Start();

            //buton resimlerinin yuklenmesi
            Thread thread3 = new Thread(new ThreadStart(btn_load));
            thread3.Start();

            //oynatma durdurma butonlarının resimlerinin yuklenmesi
            Thread thread4 = new Thread(new ThreadStart(sound_btn));
            thread4.Start();

            Thread ses2 = new Thread(new ThreadStart(ses_durumu));
            ses2.Start();

        }

        //mouse ile formu tutup suruklemek icin kodlar
        //formu ekranda surukle
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
            location = true;
        }

        //mouse up olunca formu surukleme
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            location = false;
        }

        //formu ekranda surukle ekrandaki konumunu al
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (location == true)
            {
                this.Location = new Point(Cursor.Position.X - x, Cursor.Position.Y - y);
            }
        }

        //tum kanalları goster - tum kanallar butonu
        private void button4_Click(object sender, EventArgs e)
        {
            
            Thread allchannel = new Thread(new ThreadStart(verilerigoruntule));
            allchannel.Start();
 
        }


        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            //iptal
        }

        //radio oynatma butonu
        private void button16_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        //radio duraklatma butonu
        private void button17_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        //radio tamamen durdurma butonu
        private void button18_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        //ses acma barı
        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = trackBar1.Value;
            //ses durumuna gore resim degissin
            Thread ses = new Thread(new ThreadStart(ses_durumu));
            ses.Start();

        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            button4.BackColor = Color.GhostWhite;
        }

        //akustik butonu - akustik kategorisini yukle
        private void button12_Click(object sender, EventArgs e)
        {
            Thread akustikkanallar = new Thread(new ThreadStart(akustik));
            akustikkanallar.Start();
            button12.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Thread havalikategori = new Thread(new ThreadStart(havali));
            havalikategori.Start();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Thread fitkategori = new Thread(new ThreadStart(fitness));
            fitkategori.Start();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Thread yalnızhuzur = new Thread(new ThreadStart(sakin));
            yalnızhuzur.Start();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Thread hiphopkategori = new Thread(new ThreadStart(hiphop));
            hiphopkategori.Start();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Thread eglencekategorisi = new Thread(new ThreadStart(eglence));
            eglencekategorisi.Start();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Thread popkategorisi = new Thread(new ThreadStart(pop));
            popkategorisi.Start();
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            Thread arabesk_kategorisi = new Thread(new ThreadStart(arabesk));
            arabesk_kategorisi.Start();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Thread populer_kategorisi = new Thread(new ThreadStart(populer));
            populer_kategorisi.Start();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Thread sehirler_kategorisi = new Thread(new ThreadStart(sehirler));
            sehirler_kategorisi.Start();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Thread eskiler_kategorisi = new Thread(new ThreadStart(eskiler));
            eskiler_kategorisi.Start();
        }



        //-----------------------------------------
        //panel4 acar --- cihazdaki muzikler
        //global degisken
        string url = "";
        
        private void audiobtn_load()
        {
            Thread.Sleep(20);
            button25.Image = Image.FromFile("audio/unfavori.png");
            Thread.Sleep(20);
            button26.Image = Image.FromFile("audio/random.png");
            Thread.Sleep(20);
            button27.Image = Image.FromFile("audio/geri.png");
            Thread.Sleep(20);
            button28.Image = Image.FromFile("audio/play2.png");
            Thread.Sleep(20);
            button29.Image = Image.FromFile("audio/forward.png");
            Thread.Sleep(20);
            button30.Image = Image.FromFile("audio/tune.png");
            Thread.Sleep(20);
            pictureBox7.Image = Image.FromFile("audio/audio.png");
            Thread.Sleep(20);
            button31.Image = Image.FromFile("audio/pause2.png");
            Thread.Sleep(20);
            button32.Image = Image.FromFile("audio/favori.png");
            Thread.Sleep(20);
            button33.Image = Image.FromFile("audio/font.png");
            Thread.Sleep(20);
            button34.Image = Image.FromFile("audio/changer.png");
            Thread.Sleep(20);
            button35.Image = Image.FromFile("audio/geribildirim.png");
            Thread.Sleep(200);
            pictureBox9.Image = Image.FromFile("audio/fav.png");
            Thread.Sleep(500);
            pictureBox10.Image = Image.FromFile("audio/closefavori.png");
            

        }


        //---------------------------------------------
        //muzik listesinin toplam count sayısını al ve sinir degiskenine ata
        int sinir = 0;
        private void listcount()
        {
            for (int count = 0; count < listBox4.SelectedItems.Count; count++)
            {
                sinir = count; //toplam muzik sayısı
            }
        }
        //panel4 ac
        private void panel4open()
        {
            //radyo acıksa kapat
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            Thread.Sleep(200);
            //sunları dene
            try
            {
                //veri tabanını ac ve oku
                localmusic.Open();

                OleDbCommand local = new OleDbCommand();
                local.Connection = localmusic;
                local.CommandText = ("Select * From yerelyol");//muzik konumu barındırır
                OleDbDataReader getir = local.ExecuteReader();
                while (getir.Read())//okudugu surece calıstır
                {
                    url = getir["sarkiurl"].ToString();//global degiskene bunu ata
                    if (url != "")
                    {
                        break;//eger url bos degilse islemi sonlandır
                    }
                }

                localmusic.Close();//veri tabanını kapat
                Thread.Sleep(1000);


            }
            catch (Exception)
            {

                MessageBox.Show("Bir hata oluştu");//hata olusursa bildir
            }

            //eger veritabanında muzik konumu zaten eklenmisse muzikleri listele
            if (url != "")
            {

                
                button20.Visible = false;
                button21.Visible = false;
                button22.Visible = false;
                button23.Visible = false;
                splitContainer1.Enabled = false;
                splitContainer1.Visible = false;
                listBox3.Visible = false;
                Thread.Sleep(500);
                button24.Visible = false;  //butonları listboxları vs ac
                button24.Enabled = false;
                panel4.Visible = true;
                panel4.Enabled = true;
                //panel5.Visible = true;
                Thread.Sleep(500);
                button19.Image = Image.FromFile("localmusicbtn/back.png");
                Thread.Sleep(1000);

                //veri tabanını oku ve muzik konumunu al
                localmusic.Open();
                OleDbCommand local = new OleDbCommand();
                local.Connection = localmusic;
                local.CommandText = ("Select * From yerelyol");
                OleDbDataReader getir = local.ExecuteReader();
                //okudu surece calıstır
                while (getir.Read())
                {
                    url = getir["sarkiurl"].ToString();//global degiskene url at
                  
                }


                //GetFiles metodu dosyaları temsil eder. Belirtilen Dizindeki Dosyaları Dizi olarak döndürür
                string[] uzanti = { "*.mp3", "*.m4a", "*.avi", "*.mov" };//ses dosyaları icin filtre
                for(int u = 0; u < uzanti.Length; u++)//uzanti uzunlugu kadar calıstır
                {
                    //sadece ses dosyalarını al
                    string[] dosyalar = System.IO.Directory.GetFiles(url,uzanti[u], SearchOption.AllDirectories);//global degiskendeki urlyi al buraya ver

                    for (int j = 0; j < dosyalar.Length; j++)
                    {
                        listBox3.Items.Add(dosyalar[j]); //o konumda bulunan tum muziklerin konumunu tek tek al
                                                         //listbox3 e ekle
                    }
                    //sonra hepsinin isimlerini tek tek al
                    DirectoryInfo fileinfo = new DirectoryInfo(@url);
                    foreach (FileInfo e2 in fileinfo.GetFiles(uzanti[u], SearchOption.AllDirectories))
                    {
                        listBox4.Items.Add(e2.Name); //listview kısmına at
                    }
                }
           
                localmusic.Close();
                //veri tabanını kapat
                listBox4.Enabled = false;
                pictureBox5.Visible = true;
                pictureBox6.Visible = true;
                Thread.Sleep(500);
                label14.Visible = true;
                Thread.Sleep(10);
                label15.Visible = true;
                Thread.Sleep(10);
                label16.Visible = true;
                Thread.Sleep(10);
                label17.Visible = true;
                Thread.Sleep(10);
                label18.Visible = true;
                Thread.Sleep(10);
                label19.Visible = true;
                Thread.Sleep(10);
                label20.Visible = true;
                Thread.Sleep(10);
                label21.Visible = true;
                Thread.Sleep(10);
                label22.Visible = true;
                Thread audiobtnload = new Thread(new ThreadStart(audiobtn_load));
                audiobtnload.Start();
                //muzik listesinin toplam count degerini alan fonksiyonu calistir
                Thread listcountdegeri = new Thread(new ThreadStart(listcount));
                listcountdegeri.Start();
                listBox4.Enabled = true;
             
               

            }
            //eger veritabanında muzik yolu yoksa kullanıcıya muzik eklemesini soyle
            if (url == "")
            {

                splitContainer1.Enabled = false;
                splitContainer1.Visible = false;
                listBox4.Visible = false;
                listBox4.Enabled = false;
                listBox3.Visible = false;
                listBox3.Enabled = false;
                panel4.Visible = true;
                panel4.Enabled = true;
                panel7.Visible = false;
                panel8.Visible = false;
                panel9.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                trackBar2.Visible = false;
                metroTrackBar1.Visible = false;
                label9.Visible = false;
                label11.Visible = false;
                label13.Visible = false;
                button25.Visible = false;
                button26.Visible = false;
                button27.Visible = false;
                button28.Visible = false;
                button29.Visible = false;
                button30.Visible = false;
                Thread.Sleep(500);
                button24.Image = Image.FromFile("localmusicbtn/add.png");
                button19.Image = Image.FromFile("localmusicbtn/back.png");
                button24.Visible = true;
                button24.Enabled = true;
                axWindowsMediaPlayer2.Visible = false;
                label7.Visible = true;
                Thread.Sleep(500);
                label7.Text = "Oppss...Burada hiç müzik yok\nbize müzigi nerede arayacagımızı göster.";
            }

           
        
        }
        //cihazdaki muzikler butonu
        private void button20_Click(object sender, EventArgs e)
        {
            Thread panel4_open = new Thread(new ThreadStart(panel4open));//panel4 thread calıstır
            panel4_open.Start();
            pictureBox5.Enabled = true;
            pictureBox6.Enabled = true;
            pictureBox3.Enabled = false;
        }
        //----------------------------------------


        private void label6_Click(object sender, EventArgs e)
        {
            //iptal
        }




        //---------------------------------------------------------------

        //butonların ustune gelince title goster
        private void button20_MouseHover(object sender, EventArgs e)
        {
            label3.Visible = true;
        }

        
        private void button20_MouseLeave(object sender, EventArgs e)
        {
            label3.Visible = false;
        }

        private void button21_MouseHover(object sender, EventArgs e)
        {
            label4.Visible = true;
        }

        private void button21_MouseLeave(object sender, EventArgs e)
        {
            label4.Visible = false;
        }

        private void button22_MouseHover(object sender, EventArgs e)
        {
            label5.Visible = true;
        }

        private void button22_MouseLeave(object sender, EventArgs e)
        {
            label5.Visible = false;
        }

        private void button23_MouseHover(object sender, EventArgs e)
        {
            label6.Visible = true;
        }

        private void button23_MouseLeave(object sender, EventArgs e)
        {
            label6.Visible = false;
        }
        //title
        //--------------------------------------------------



        //--------------------------------
        //-------anapaneli ac -- cihazdaki muziklerden geri don
        // kullanıcı geri butonuna basınca ac
        private void anapanel_ac()
        {
            axWindowsMediaPlayer2.Ctlcontrols.stop();
            button31.PerformClick();
            listBox4.Items.Clear();
            listBox3.Items.Clear();
            panel4.Visible = false;
            panel4.Enabled = false;
            Thread.Sleep(500);
            splitContainer1.Visible = true;
            splitContainer1.Enabled = true;
            Thread.Sleep(500);
            button20.Visible = true;
            Thread.Sleep(50);
            button21.Visible = true;
            Thread.Sleep(50);
            button22.Visible = true;
            Thread.Sleep(50);
            button23.Visible = true;
            //Thread.Sleep(500);
            pictureBox3.Enabled = true;
        }
        //geri butonu
        private void button19_Click(object sender, EventArgs e)
        {
            Thread anapanel = new Thread(new ThreadStart(anapanel_ac));
            anapanel.Start();
            pictureBox5.Enabled = false;
            pictureBox6.Enabled = false;
        }


        //----------------------------------------------------------
        // eger hic muzik eklenmemisse kullanıcı ekleye basınca veritabanına yolu yazdır
        private void button24_Click(object sender, EventArgs e)
        {
            //openFileDialog1.ShowDialog();
            folderBrowserDialog1.ShowDialog();
            //GetFiles metodu dosyaları temsil eder. Belirtilen Dizindeki Dosyaları Dizi olarak döndürür
            string[] dosyalar = System.IO.Directory.GetFiles(folderBrowserDialog1.SelectedPath);
            for (int j = 0; j < 1; j++)
            {
                //sarkilarin konumunu veritabanina yazdir
                localmusic.Open();
                OleDbCommand ekle = new OleDbCommand("insert into yerelyol(sarkiurl) values ('" + folderBrowserDialog1.SelectedPath + "')", localmusic);
                ekle.ExecuteNonQuery();
                localmusic.Close();
            }

            //prognessbarı doldur fonksiyonu
            Thread prognes = new Thread(new ThreadStart(prognesvalue));
            prognes.Start();

        }
        //muzikler eklenince barı doldur ve yeniden başlatma iste
        private void prognesvalue()
        {
            Thread.Sleep(1000);
            progressBar1.Visible = true;
            for(int prognesv = 0; prognesv <= 100; prognesv++)
            {
                progressBar1.Value = prognesv;
            }
            label12.Visible = true;
            Thread.Sleep(1000);
            progressBar1.Visible = false;
        }
        //--------------------------------------------------------------------------------------------------

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

         //iptal
        }

        //seçili çalan muzigin bilgilerini yazdırır
        private void muzikbilgileri()
        {
            Thread.Sleep(500);
            try
            {
                //taglibsharp dll dosyasını referans alır
                string yol = listBox3.SelectedItem.ToString();
                TagLib.File mp3 = TagLib.File.Create(yol);
                label9.Text = mp3.Tag.Title;
                label18.Text = mp3.Tag.Album;
                label19.Text = GetAllStringsFromArrary(mp3.Tag.AlbumArtists, ",");
                label20.Text = GetAllStringsFromArrary(mp3.Tag.Genres, ",");
                label22.Text = label11.Text;
              
               

            }
            catch (Exception)
            {

                label9.Text = "Bu dosya desteklenmiyor";
                label22.Text = "yok";
            }
            Thread.Sleep(2000);
            if (label9.Text == "")
            {
                label9.Text = "Bilinmiyor";
            }
            if (label18.Text == "")
            {
                label18.Text = "Bilinmiyor";
            }
            if (label19.Text == "")
            {
                label19.Text = "Bilinmiyor";
            }
            if (label20.Text == "")
            {
                label20.Text = "Bilinmiyor";
            }

        }

        //müziklistesinde liste index değiştikçe bu kodlar çalışır
        private void resimleri_yukle()
        {
            pictureBox5.Image = null;
            pictureBox6.Image = null;
            Thread.Sleep(600);
            pictureBox5.Image = Image.FromFile("localmusicbtn/sound.gif");
            Thread.Sleep(600);
            pictureBox6.Image = Image.FromFile("localmusicbtn/Wave.gif");

        }

        string favoriler = "";
        private void favorilersearch()
        {

            try
            {
                Thread.Sleep(1000);
                //veri tabanını ac ve oku
                localmusic.Open();
                OleDbCommand local = new OleDbCommand();
                local.Connection = localmusic;
                local.CommandText = ("Select * From yerelmuzikler");//muzik konumu barındırır
                OleDbDataReader sor = local.ExecuteReader();
                while (sor.Read())//okudugu surece calıstır
                {
                    favoriler = sor["sarkiismi"].ToString();
                    if (listBox4.Text == favoriler)
                    {
                        sor.Close();
                        button25.Visible = false;
                        button32.Visible = true;
                        break;
                    }
                    else
                    {
                        button25.Visible = true;
                        button32.Visible = false;
                    }

                }
                localmusic.Close();//veri tabanını kapat
            }
            catch (Exception)
            {

                localmusic.Close();
            }
        
        }
        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

            button28.Visible = false;
            button28.Enabled = false;
            button31.Visible = true;
            button31.Enabled = true;
            listBox3.SelectedIndex = listBox4.SelectedIndex;

            try
            {
                axWindowsMediaPlayer2.URL = listBox3.SelectedItem.ToString();
                axWindowsMediaPlayer2.Ctlcontrols.play(); //secili muzigi cal
              

                //müzik bilgileri icin foksiyonu thread ile çalıştır
                Thread muzikbilgi = new Thread(new ThreadStart(muzikbilgileri));
                muzikbilgi.Start();
                timer1.Enabled = true;
                timer1.Start();
                Thread resimleriyukle = new Thread(new ThreadStart(resimleri_yukle));
                resimleriyukle.Start();
            }
            catch (Exception)
            {

                label9.Text = "SoundTiger";
            }
            button25.Enabled = true;
            Thread favoricontroll = new Thread(new ThreadStart(favorilersearch));
            favoricontroll.Start();
            button34.Enabled = true;
            if (pictureBox5.Enabled == false)
            {
                pictureBox5.Enabled = true;
                pictureBox6.Enabled = true;
            }

        }
        //muzik bilgilerini alan fonksiyon için bazı methotlar - gerekli!!
        public string GetAllStringsFromArrary(string[] strArray, string strDelimeter)
        {
            string strFinal = string.Empty;

            for (int i = 0; i < strArray.Length; i++)
            {
                strFinal += strArray[i];

                if (i != strArray.Length - 1)
                {
                    strFinal += strDelimeter;
                }
            }
            return strFinal;


        }

        //cihazdaki muzikler kısmı trackbar ses kısma ve arttırma islemi
        private void sesdurumu2_durum() //ses durumuna göre ses iconu degissin
        {
            if (axWindowsMediaPlayer2.settings.volume == 0)
            {
                Thread.Sleep(200);
                pictureBox7.Image = null;
                pictureBox7.Image = Image.FromFile("audio/noaudio.png");//ses kapalı iconu

            }
            if (axWindowsMediaPlayer2.settings.volume != 0)
            {
                Thread.Sleep(200);
                pictureBox7.Image = null;
                pictureBox7.Image = Image.FromFile("audio/audio.png");//ses acık iconu

            }
        }
        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            axWindowsMediaPlayer2.settings.volume = trackBar2.Value;
            Thread sesdurumu2 = new Thread(new ThreadStart(sesdurumu2_durum));
            sesdurumu2.Start();
        }


        string karistir = "";
       
        //trackbar3 valuesini anlık olarak müzik saniyesine eşitle
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                string süre = axWindowsMediaPlayer2.currentMedia.duration.ToString();
                int süreint = Convert.ToInt32(axWindowsMediaPlayer2.currentMedia.duration - (axWindowsMediaPlayer2.currentMedia.duration % 1));

                string süre1 = axWindowsMediaPlayer2.Ctlcontrols.currentPosition.ToString();
                int süreint1 = Convert.ToInt32(axWindowsMediaPlayer2.Ctlcontrols.currentPosition - (axWindowsMediaPlayer2.Ctlcontrols.currentPosition % 1));
                int mSayısı = listBox4.Items.Count;
                label11.Text = axWindowsMediaPlayer2.currentMedia.durationString;
                label13.Text = axWindowsMediaPlayer2.Ctlcontrols.currentPositionString;

                if (label11.Text != "0.00")
                {
                    metroTrackBar1.Maximum = süreint;
                    metroTrackBar1.Value = süreint1;

                }
                //tekrarlama ve karıştırma işlemleri

                if (metroTrackBar1.Value==süreint)//müzik bittiginde sunları kontrolet
                {
                    if (karistir == "karistir")//karistir acıksa rastgele sarki ac
                    {
                        
                        Random rnd = new Random();
                        int i = rnd.Next(0, listBox4.Items.Count);
                        listBox4.SelectedIndex = i;
                        button28.PerformClick();
                    }
                    if (karistir == "")//karistir kapalıysa bir sonraki sarkiya gec
                    {

                        button29.PerformClick();
                    }
                  

                }



            }
            catch (Exception)
            {

                label9.Text = "Bekleniyor...";
               
            }
     
        }

      

        //----------------------------------------
        //-------mouse olayları - butonların uzerine gelince ve ayrılınca gerceklesecek olaylar
        private void button29_MouseHover(object sender, EventArgs e)
        {
            button29.BackColor = Color.Indigo;
        }

        private void button29_MouseLeave(object sender, EventArgs e)
        {
            button29.BackColor = Color.Transparent;
        }

        private void button29_MouseMove(object sender, MouseEventArgs e)
        {
            button29.BackColor = Color.Indigo;

        }

        private void button28_MouseMove(object sender, MouseEventArgs e)
        {
            button28.BackColor = Color.Indigo;

        }

        private void button28_MouseLeave(object sender, EventArgs e)
        {
            button28.BackColor = Color.Transparent;

        }

        private void button27_MouseMove(object sender, MouseEventArgs e)
        {
            button27.BackColor = Color.Indigo;

        }

        private void button27_MouseLeave(object sender, EventArgs e)
        {
            button27.BackColor = Color.Transparent;

        }

        private void button30_MouseMove(object sender, MouseEventArgs e)
        {
            button30.BackColor = Color.Indigo;
           

        }

        private void button30_MouseLeave(object sender, EventArgs e)
        {
            button30.BackColor = Color.Transparent;

        }

        private void button26_MouseMove(object sender, MouseEventArgs e)
        {
            button26.BackColor = Color.Indigo;

        }

        private void button26_MouseLeave(object sender, EventArgs e)
        {
            button26.BackColor = Color.Transparent;

        }

        private void button25_MouseMove(object sender, MouseEventArgs e)
        {
            button25.BackColor = Color.Indigo;
            label33.Visible = true;
            label33.Text = "Favorilere ekle";

        }

        private void button25_MouseLeave(object sender, EventArgs e)
        {
            button25.BackColor = Color.Transparent;
            label33.Visible = false;
            label33.Text = "Favorilere ekle";
        }
        private void button31_MouseMove(object sender, MouseEventArgs e)
        {
            button31.BackColor = Color.Indigo;
        }
        private void button31_MouseLeave(object sender, EventArgs e)
        {
            button31.BackColor = Color.Transparent;
        }
        //mouse olayları sonu
        //----------------------------------------------------------

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            trackBar2.Value = 0;
            axWindowsMediaPlayer2.settings.volume = 0;
            Thread sesikapat = new Thread(new ThreadStart(sesdurumu2_durum));
            sesikapat.Start();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            
            
            button28.Visible = false;
            button28.Enabled = false;
            button31.Visible = true;
            button31.Enabled = true;
            axWindowsMediaPlayer2.Ctlcontrols.play();
            pictureBox5.Enabled = true;
            pictureBox6.Enabled = true;
            button34.Enabled = true;




        }

        private void button31_Click(object sender, EventArgs e)
        {
           
            
            button31.Visible = false;
            button31.Enabled = false;
            button28.Visible = true;
            button28.Enabled = true;
            axWindowsMediaPlayer2.Ctlcontrols.pause();
            pictureBox5.Enabled = false;
            pictureBox6.Enabled = false;



        }
        
        
        private void button29_Click(object sender, EventArgs e)
        {

            try
            {
                
                
                listBox4.SelectedIndex++;
            }
            catch (Exception)
            {

                listBox4.SelectedIndex = 0;
            }
            

        }

      
        private void button27_Click(object sender, EventArgs e)
        {
            try
            {
                
               
                listBox4.SelectedIndex--;
            }
            catch (Exception)
            {

                label9.Text = "En başa ulaştınız..";
            }
        }
        
        

        private void button26_Click(object sender, EventArgs e)
        {
            
            if (karistir == "")
            {
                karistir = "karistir";
                button26.Image = Image.FromFile("audio/randomon.png");
            }
            else if (karistir != "")
            {
                karistir = "";
                button26.Image = Image.FromFile("audio/random.png");

            }

        }


        //ses ayarları cıkıs iconunu yukle
        private void cancel_settings()
        {
            Thread.Sleep(500);
            pictureBox8.Image = Image.FromFile("audio/cancel.png");
        }
        //cihazdaki muzikler ses ayarları panelini ac

        private void button30_Click(object sender, EventArgs e)
        {
            panel10.Visible = true;
            panel10.Width = 170;
            Thread cancel = new Thread(new ThreadStart(cancel_settings));
            cancel.Start();

        }


        //--------------------------------------------------------------------//

        //volumeset sınıfını cagırdım ve pl adı ile atadım
        volumeset pl = new volumeset();//bu sınıf ses ayarları icin

        //burada sınıfın icinden sol hoparlor ses ayarına trackbar4 valuesini yolladım
        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            pl.Solses = trackBar4.Value;
        }

        //burada sınıfın icinden sag hoparlor ses ayarına trackbar5 valuesini yolladım
        private void trackBar5_Scroll(object sender, EventArgs e)
        {
            pl.Sagses = trackBar5.Value;
           


        }

        //burada sınıfın icinden hoparlor bass ayarına trackbar6 valuesini yolladım
        private void trackBar6_Scroll(object sender, EventArgs e)
        {
            pl.Bass = trackBar6.Value;
        }

        //burada sınıfın icinden hoparlor tiz ayarına trackbar7 valuesini yolladım
        private void trackBar7_Scroll(object sender, EventArgs e)
        {
            pl.Tiz = trackBar7.Value;
          
        }
        //ses ayarlar panelini kapatmak icin close iconu ve olaylar
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            panel10.Width = 0;
            panel10.Visible = false;
            
        }

        //favorilere ekle - cihazdaki muzikler
        private void button25_Click(object sender, EventArgs e)
        {

            for (int fav = 0; fav < 1; fav++)
            {
                //sarkilarin konumunu veritabanina yazdir
                localmusic.Open();
                OleDbCommand ekle = new OleDbCommand("insert into yerelmuzikler(sarkiismi) values ('" +listBox4.Text + "')", localmusic);
                OleDbCommand ekle2 = new OleDbCommand("insert into favoriyol(sarkiyolu) values ('" +listBox3.Text + "')", localmusic);
                ekle.ExecuteNonQuery();
                ekle2.ExecuteNonQuery();

                localmusic.Close();
            }
            button25.Visible = false;
            button32.Visible = true;
          
        }

        //favorilerden kaldırma butonu
        OleDbCommand kaldir = new OleDbCommand();
        OleDbCommand kaldir2 = new OleDbCommand();

        private void button32_Click(object sender, EventArgs e)
        {
            //favoriden kaldır butonu
            //buraya kodlar yazılacak
            //veritabanından silecek
            button32.Visible = false;
            localmusic.Open();
            kaldir.Connection = localmusic;
            kaldir.CommandText = "delete from yerelmuzikler where sarkiismi='"+listBox4.Text+"'";
            kaldir.ExecuteNonQuery();
            localmusic.Close();
            Thread.Sleep(200); 
            localmusic.Open();
            kaldir2.Connection = localmusic;
            kaldir2.CommandText = "delete from favoriyol where sarkiyolu='" + listBox3.Text + "'";
            kaldir2.ExecuteNonQuery();
            localmusic.Close();
            button25.Visible = true;
            if (pictureBox10.Visible == true)
            {
                listBox3.Items.Remove(listBox3.SelectedItem);
                listBox4.Items.Remove(listBox4.SelectedItem);
            }

        }

        //Favoriler picturebox mouse uzerine geldiginde title goster - label32
        private void pictureBox9_MouseMove(object sender, MouseEventArgs e)
        {
            //iptal
        }

        private void label32_MouseLeave(object sender, EventArgs e)
        {
            //iptall
           

        }

        //favoriler title
        private void pictureBox9_MouseHover(object sender, EventArgs e)
        {
            label32.Visible = true;
            label32.Text = "Favoriler";

        }

        private void pictureBox9_MouseLeave(object sender, EventArgs e)
        {
            label32.Visible = false;
        }

        //favori kaldır butonu title ve color
        private void button32_MouseMove(object sender, MouseEventArgs e)
        {
            button32.BackColor = Color.Indigo;
            label33.Visible = true;
            label33.Text = "Favorilerden kaldır";
        }

        private void button32_MouseLeave(object sender, EventArgs e)
        {
            button32.BackColor = Color.Transparent;
            label33.Visible = false;
            label33.Text = "Favorilerden kaldır";
        }
        //------------------------------------------
        //Favori muzikleri listele
        private void pictureBox9_Click(object sender, EventArgs e)
        {

            pictureBox9.Visible = false;
            listBox4.Items.Clear();
            listBox3.Items.Clear();
            Thread.Sleep(1000);
            localmusic.Open();
            OleDbCommand favori = new OleDbCommand();
            favori.Connection = localmusic;
            favori.CommandText = ("Select * From yerelmuzikler");
            OleDbDataReader favoriisim = favori.ExecuteReader();

            OleDbCommand favoriyol = new OleDbCommand();
            favoriyol.Connection = localmusic;
            favoriyol.CommandText = ("Select * From favoriyol");
            OleDbDataReader favoriyolu = favoriyol.ExecuteReader();
            while (favoriisim.Read())
            {


                listBox4.Items.Add(favoriisim["sarkiismi"]);
              
     

            }
            while (favoriyolu.Read())
            {


                listBox3.Items.Add(favoriyolu["sarkiyolu"]);



            }
            localmusic.Close();
            Thread.Sleep(500);
            pictureBox10.Visible = true;
            label8.Text = "FAVORI MÜZIKLER";



        }

        //kullanıcı favorilerden cıkıs yapınca tekrar local muzikleri getir
        private void pictureBox10_Click(object sender, EventArgs e)
        {
            pictureBox10.Visible = false;//close iconu olan picturebox10 false yap
            //listboxları temizle
            listBox4.Items.Clear();
            listBox3.Items.Clear();
            Thread.Sleep(1000);//bekle

            //veri tabanını ac
            localmusic.Open();
            OleDbCommand local = new OleDbCommand();
            local.Connection = localmusic;
            local.CommandText = ("Select * From yerelyol");
            OleDbDataReader getir = local.ExecuteReader();
            //okudu surece calıstır
            while (getir.Read())
            {
                url = getir["sarkiurl"].ToString();//global degiskene url at

            }


            //GetFiles metodu dosyaları temsil eder. Belirtilen Dizindeki Dosyaları Dizi olarak döndürür
            string[] uzanti = { "*.mp3", "*.m4a", "*.avi", "*.mov" };//ses dosyaları icin filtre
            for (int u = 0; u < uzanti.Length; u++)//uzanti uzunlugu kadar calıstır
            {
                //sadece ses dosyalarını al
                string[] dosyalar = System.IO.Directory.GetFiles(url, uzanti[u], SearchOption.AllDirectories);//global degiskendeki urlyi al buraya ver

                for (int j = 0; j < dosyalar.Length; j++)
                {
                    listBox3.Items.Add(dosyalar[j]); //o konumda bulunan tum muziklerin konumunu tek tek al
                                                     //listbox3 e ekle
                }
                //sonra hepsinin isimlerini tek tek al
                DirectoryInfo fileinfo = new DirectoryInfo(@url);
                foreach (FileInfo e2 in fileinfo.GetFiles(uzanti[u], SearchOption.AllDirectories))
                {
                    listBox4.Items.Add(e2.Name); //listboox kısmına at
                }
            }

            localmusic.Close();//veri tabanını kapat
            Thread.Sleep(500);
            pictureBox9.Visible = true;
            label8.Text = "ŞARKILAR"; // sarkılar kısmına yazdir

        }

        //favorilerden cıkıs için title
        private void pictureBox10_MouseMove(object sender, MouseEventArgs e)
        {
            label32.Visible = true;
            label32.Text = "Favorileri kapat";
        }

        private void pictureBox10_MouseLeave(object sender, EventArgs e)
        {
            label32.Visible = false;
            label32.Text = "Favorileri kapat";
            
        }
        //-----------------------------------//
        //cihazdaki muzikler - fontu buyut
        private void button33_Click(object sender, EventArgs e)
        {
            listBox4.Font = new Font("Arial Rounded MT", 14);
            label14.Font = new Font("Malgun Gothic", 12);
            label15.Font = new Font("Malgun Gothic", 12);
            label16.Font = new Font("Malgun Gothic", 12);
            label17.Font = new Font("Malgun Gothic", 12);
            label18.Font = new Font("Malgun Gothic", 12);
            label19.Font = new Font("Malgun Gothic", 12);
            label20.Font = new Font("Malgun Gothic", 12);
            label22.Font = new Font("Malgun Gothic", 12);


          

        }

        private void button33_MouseMove(object sender, MouseEventArgs e)
        {
            button33.BackColor = Color.Indigo;
        }

        private void button33_MouseLeave(object sender, EventArgs e)
        {
            button33.BackColor = Color.Transparent;

        }


        //ortadaki animasyon resmini degistir
        //cihazdaki muzikler bolumu
        private void new_animation()
        {
            Thread.Sleep(500);
            string[] yol = { "localmusicbtn/brand.gif", "localmusicbtn/darkness.gif", "localmusicbtn/particle.gif" };
            Random changeanimation = new Random();
            int newanimation = changeanimation.Next(0, yol.Length);
            pictureBox6.Image = Image.FromFile(yol[newanimation]);
        }
        private void button34_Click(object sender, EventArgs e)
        {
            Thread animationchanger = new Thread(new ThreadStart(new_animation));
            animationchanger.Start();
        }

        private void button34_MouseMove(object sender, MouseEventArgs e)
        {
            button34.BackColor = Color.Indigo;
        }

        private void button34_MouseLeave(object sender, EventArgs e)
        {
            button34.BackColor = Color.Transparent;
        }

        private void button35_Click(object sender, EventArgs e)
        {
            //geri bildirim paneli acılacak
            //buraya kodlar yazılacak
            
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
            
        }

        private void button35_MouseMove(object sender, MouseEventArgs e)
        {
            button35.BackColor = Color.Indigo;
        }

        private void button35_MouseLeave(object sender, EventArgs e)
        {
            button35.BackColor = Color.Transparent;
        }

        private void metroTrackBar1_Scroll(object sender, ScrollEventArgs e)
        {
            axWindowsMediaPlayer2.Ctlcontrols.currentPosition = metroTrackBar1.Value;

        }
       // OleDbConnection soundtiger = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|soundtiger.mdb");

        //metro panelin acılması ve yuklenmesi
        private void yukle_metro()
        {
            //icon ve fotografların yuklenmesi
            Thread.Sleep(1000);
            metroPanel6.BackgroundImage = Image.FromFile("metro/tiger.png");
            Thread.Sleep(500);
            metroPanel5.BackgroundImage = Image.FromFile("metro/reklam.png");
            Thread.Sleep(20);
            metroTile1.TileImage = Image.FromFile("metro/soundtiger.png");
            Thread.Sleep(20);
            metroTile21.TileImage = Image.FromFile("metro/exit.png");
            Thread.Sleep(20);
            metroTile22.TileImage = Image.FromFile("metro/likedsongs.png");
            Thread.Sleep(20);
            metroTile23.TileImage = Image.FromFile("metro/download.png");
            Thread.Sleep(20);
            metroLink1.Image = Image.FromFile("metro/help.png");
            Thread.Sleep(20);
            pictureBox15.Image = Image.FromFile("metro/search.png");
            Thread.Sleep(100);
            metroPanel7.BackgroundImage = Image.FromFile("metro/reklam2.png");
            Thread.Sleep(100);
            metroTile25.TileImage = Image.FromFile("metro/backweb.png");
            metroTile26.TileImage = Image.FromFile("metro/forward.png");
            pictureBox11.Image = Image.FromFile("metro/tiger.png");
            webControl1.WebView.Url = "https://vimeo.com/watch";

            //motivasyon bolumu icin populer video yerlestirmesi
            _yUrl = "https://youtu.be/LkIijPd7CZY";
            webBrowser1.DocumentText = String.Format("<meta http-equiv='X-UA-Compatible' content='IE=Edge'/><iframe width='99%' height='200'" +
                " src='https://www.youtube.com/embed/{0}?autoplay=1' frameborder='0' allow='accelerometer;" +
                " encrypted-media; gyroscope; picture-in-picture' allowfullscreen></iframe>", VideoID);
            SendKeys.SendWait("a");
            Thread.Sleep(10);
            //motivasyon sozunu yazdir
            metroLabel3.Text = "“Karanlıktan korkan bir çocuğu kolayca affedebiliriz.\n Hayatın gerçek trajedisi büyükler ışıktan korktuğunda başlar.”\n -Plato \n Motivasyonun hiç bitmesin ";
            Thread.Sleep(2000);
            //motivasyon videolarına git
            webBrowser2.Navigate("https://www.youtube.com/c/MotivasyonVideolar%C4%B1/videos");//motivasyon bolumu
            Thread.Sleep(100);
            //kontrol butonlarını yukle
            metroTile27.TileImage = Image.FromFile("metro/ytback.png");
            metroTile28.TileImage = Image.FromFile("metro/ytnext.png");
            pictureBox12.Image = Image.FromFile("metro/reload.png");
            Thread.Sleep(100);
            pictureBox13.Image = Image.FromFile("metro/tiger.png");
            pictureBox14.Image = Image.FromFile("metro/tigertext.png");
            webControl2.WebView.Url = "https://podcasts.google.com/";
        }
        //global url
        string _yUrl;
        //iframe icin regex kodu
        //motivasyon baslangic video yerlestirme - iframe regex cozumu
        public string VideoID
        {
            get
            {
                var yMatch = new Regex(@"http(?:s?)://(?:www\.)?youtu(?:be\.com/watch\?v=|\.be/)([\w\-]+)(&(amp;)?[\w\?=]*)?").Match(_yUrl);
                return yMatch.Success ? yMatch.Groups[1].Value : string.Empty;
            }
        }
       
      

        //metro panel acılması icin tetiklenecek buton
        private void button21_Click(object sender, EventArgs e)
        {
            metroPanel1.Visible = true;
            Thread metroyukle = new Thread(new ThreadStart(yukle_metro));
            metroyukle.Start();

           


        }

        private void button22_Click(object sender, EventArgs e)
        {
            geribildirim.Show();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            //düzenlenecek
        }

        private void metroTile21_Click(object sender, EventArgs e)
        {
            metroPanel1.Visible = false;
        }

        youtube ytform = new youtube();
        private void metroTile23_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = false;
            metroPanel5.Dock = DockStyle.Fill;
            ytform.TopLevel = false;
            metroPanel5.Controls.Add(ytform);
            ytform.Show();
            ytform.Dock = DockStyle.Fill;
            ytform.BringToFront();
            ytform.webBrowser1.Navigate("https://www.youtube.com");
            metroTile24.TileImage = Image.FromFile("metro/exit.png");
            metroTile24.Visible = true;
            metroTile23.Enabled = false;
            pictureBox15.Enabled = false;
            metroTextBox1.Enabled = false;
        }
        Form2 geribildirim = new Form2();
        Form2 geribildirim2 = new Form2();
        Form2 geribildirim3 = new Form2();


        private void metroLink1_Click(object sender, EventArgs e)
        {
            geribildirim2.Show();
           
        }

        //izleme paneli - yeni formu cagır

        music ms = new music();

        //kategorilere tıklayınca hangi url acacagını belirleme islemleri
        //soundtiger karısık mix
        private void metroTile1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = false;
            metroPanel5.Dock = DockStyle.Fill;
            ms.TopLevel = false;
            metroPanel5.Controls.Add(ms);
            ms.Show();
            ms.Dock = DockStyle.Fill;
            ms.webBrowser1.Navigate("https://www.youtube.com/watch?v=Z84K6F-WMnQ&list=RDZ84K6F-WMnQ&start_radio=1");
            ms.BringToFront();
            ms.metroLabel2.Text = metroTile1.Text + "\n" + "Soundtiger karışık mix";
            ms.metroPanel6.BackgroundImage = Image.FromFile("metro/dj.png");
            metroTile24.TileImage = Image.FromFile("metro/exit.png");
            metroTile24.Visible = true;
        }

        //izleme panelinden cıkıs ve kategori panelini yukleme islemleri
        public void geriyukle()
        {
            metroPanel5.Dock = DockStyle.Top;
            flowLayoutPanel1.Visible = true;
        }
        //izleme panelinden cıkıs ve kategori panelini yukleme islemleri
        private void metroTile24_Click(object sender, EventArgs e)
        {
            ms.Hide();
            istek.Hide();
            ytform.Hide();
            geriyukle();
            metroTile24.Visible = false;
            metroTile23.Enabled = true;
         
            metroTextBox1.Enabled = true;
        }

        //turkce pop
        private void metroTile2_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = false;
            metroPanel5.Dock = DockStyle.Fill;
            ms.TopLevel = false;
            metroPanel5.Controls.Add(ms);
            ms.Show();
            ms.Dock = DockStyle.Fill;
            ms.BringToFront();
            ms.webBrowser1.Navigate("https://www.youtube.com/watch?v=nQCupNMe8R8&list=PLRYrvC4-qoFzBHLXQCrei5x-dirL31sls");
            ms.metroLabel2.Text = metroTile2.Text + "\n" + "Türkçe pop müzik";
            ms.metroPanel6.BackgroundImage = Image.FromFile("metro/reklam3.png");
            metroTile24.TileImage = Image.FromFile("metro/exit.png");
            metroTile24.Visible = true;
        }

        //rnb -hip-hop
        private void metroTile3_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = false;
            metroPanel5.Dock = DockStyle.Fill;
            ms.TopLevel = false;
            metroPanel5.Controls.Add(ms);
            ms.Show();
            ms.Dock = DockStyle.Fill;
            ms.BringToFront();
            ms.webBrowser1.Navigate("https://www.youtube.com/c/Trillion8DMusic/videos");
            ms.metroLabel2.Text = metroTile3.Text + "\n" + "Rnb-hiphop müzik";
            ms.metroPanel6.BackgroundImage = Image.FromFile("metro/reklam3.png");
            metroTile24.TileImage = Image.FromFile("metro/exit.png");
            metroTile24.Visible = true;
        }

        //turkuler
        private void metroTile4_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = false;
            metroPanel5.Dock = DockStyle.Fill;
            ms.TopLevel = false;
            metroPanel5.Controls.Add(ms);
            ms.Show();
            ms.Dock = DockStyle.Fill;
            ms.BringToFront();
            ms.webBrowser1.Navigate("https://www.youtube.com/c/kalanmusicofficial/videos");
            ms.metroLabel2.Text = metroTile4.Text + "\n" + "En sevilen türkülerimiz";
            ms.metroPanel6.BackgroundImage = Image.FromFile("metro/reklam3.png");
            metroTile24.TileImage = Image.FromFile("metro/exit.png");
            metroTile24.Visible = true;
        }

        //fitness motivasyon
        private void metroTile5_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = false;
            metroPanel5.Dock = DockStyle.Fill;
            ms.TopLevel = false;
            metroPanel5.Controls.Add(ms);
            ms.Show();
            ms.Dock = DockStyle.Fill;
            ms.BringToFront();
            ms.webBrowser1.Navigate("https://www.youtube.com/c/WorkoutMusic6789/videos");
            ms.metroLabel2.Text = metroTile5.Text + "\n" + "Fitness motivasyonun hiç bitmesin";
            ms.metroPanel6.BackgroundImage = Image.FromFile("metro/reklam3.png");
            metroTile24.TileImage = Image.FromFile("metro/exit.png");
            metroTile24.Visible = true;
        }

        //parti - eglence
        private void metroTile6_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = false;
            metroPanel5.Dock = DockStyle.Fill;
            ms.TopLevel = false;
            metroPanel5.Controls.Add(ms);
            ms.Show();
            ms.Dock = DockStyle.Fill;
            ms.BringToFront();
            ms.webBrowser1.Navigate("https://www.youtube.com/channel/UC_MRLN4C-I0sApga0TrH7Sw/videos");
            ms.metroLabel2.Text = metroTile6.Text + "\n" + "Arkadaşlarla partiye ne dersin?";
            ms.metroPanel6.BackgroundImage = Image.FromFile("metro/reklam3.png");
            metroTile24.TileImage = Image.FromFile("metro/exit.png");
            metroTile24.Visible = true;
        }
        //yalnız huzur
        private void metroTile7_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = false;
            metroPanel5.Dock = DockStyle.Fill;
            ms.TopLevel = false;
            metroPanel5.Controls.Add(ms);
            ms.Show();
            ms.Dock = DockStyle.Fill;
            ms.BringToFront();
            ms.webBrowser1.Navigate("https://www.youtube.com/c/MeditasyonRahatlamaM%C3%BCzikleri/videos");
            ms.metroLabel2.Text = metroTile7.Text + "\n" + "Kendinle başbaşa huzurlu bir gün geçir";
            ms.metroPanel6.BackgroundImage = Image.FromFile("metro/reklam3.png");
            metroTile24.TileImage = Image.FromFile("metro/exit.png");
            metroTile24.Visible = true;
        }

        //ofis
        private void metroTile8_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = false;
            metroPanel5.Dock = DockStyle.Fill;
            ms.TopLevel = false;
            metroPanel5.Controls.Add(ms);
            ms.Show();
            ms.Dock = DockStyle.Fill;
            ms.BringToFront();
            ms.webBrowser1.Navigate("https://www.youtube.com/watch?v=bP72JXmq60U&list=OLAK5uy_l5aXN5OMA6m_6zEDsnCtfWf6sNQMHKoIo");
            ms.metroLabel2.Text = metroTile8.Text + "\n" + "ofis stresinden uzaklaşmak isteyenler için";
            ms.metroPanel6.BackgroundImage = Image.FromFile("metro/reklam3.png");
            metroTile24.TileImage = Image.FromFile("metro/exit.png");
            metroTile24.Visible = true;
        }

        //gizem - emontial - dark music
        private void metroTile9_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = false;
            metroPanel5.Dock = DockStyle.Fill;
            ms.TopLevel = false;
            metroPanel5.Controls.Add(ms);
            ms.Show();
            ms.Dock = DockStyle.Fill;
            ms.BringToFront();
            ms.webBrowser1.Navigate("https://www.youtube.com/c/23Alchemist23/videos");
            ms.metroLabel2.Text = metroTile9.Text + "\n" + "Biraz gizem, biraz karanlık istermisin, burası sana göre";
            ms.metroPanel6.BackgroundImage = Image.FromFile("metro/reklam3.png");
            metroTile24.TileImage = Image.FromFile("metro/exit.png");
            metroTile24.Visible = true;
        }

        //piano music
        private void metroTile10_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = false;
            metroPanel5.Dock = DockStyle.Fill;
            ms.TopLevel = false;
            metroPanel5.Controls.Add(ms);
            ms.Show();
            ms.Dock = DockStyle.Fill;
            ms.BringToFront();
            ms.webBrowser1.Navigate("https://www.youtube.com/c/JacobsPiano/videos");
            ms.metroLabel2.Text = metroTile10.Text + "\n" + "Pianonun rahatlatıcı etkisi olduğunu biliyor muydun?";
            ms.metroPanel6.BackgroundImage = Image.FromFile("metro/reklam3.png");
            metroTile24.TileImage = Image.FromFile("metro/exit.png");
            metroTile24.Visible = true;
        }
        //rock music
        private void metroTile11_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = false;
            metroPanel5.Dock = DockStyle.Fill;
            ms.TopLevel = false;
            metroPanel5.Controls.Add(ms);
            ms.Show();
            ms.Dock = DockStyle.Fill;
            ms.BringToFront();
            ms.webBrowser1.Navigate("https://www.youtube.com/channel/UCx3wWEVu34XfhYAPIzCy7Ew/videos");
            ms.metroLabel2.Text = metroTile11.Text + "\n" + "Bir bira aç ve çılgınca eğlenmene bak";
            ms.metroPanel6.BackgroundImage = Image.FromFile("metro/reklam3.png");
            metroTile24.TileImage = Image.FromFile("metro/exit.png");
            metroTile24.Visible = true;
        }

        //amator music
        private void metroTile12_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = false;
            metroPanel5.Dock = DockStyle.Fill;
            ms.TopLevel = false;
            metroPanel5.Controls.Add(ms);
            ms.Show();
            ms.Dock = DockStyle.Fill;
            ms.BringToFront();
            ms.webBrowser1.Navigate("https://www.youtube.com/c/dogaicincal/videos");
            ms.metroLabel2.Text = metroTile12.Text + "\n" + "Amatör yeteneklere bir şans ver";
            ms.metroPanel6.BackgroundImage = Image.FromFile("metro/reklam3.png");
            metroTile24.TileImage = Image.FromFile("metro/exit.png");
            metroTile24.Visible = true;
        }

        //arabesk music
        private void metroTile13_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = false;
            metroPanel5.Dock = DockStyle.Fill;
            ms.TopLevel = false;
            metroPanel5.Controls.Add(ms);
            ms.Show();
            ms.Dock = DockStyle.Fill;
            ms.BringToFront();
            ms.webBrowser1.Navigate("https://www.youtube.com/channel/UCWKsMoAJrZl9pDUyNRTcQQg/videos");
            ms.metroLabel2.Text = metroTile13.Text + "\n" + "Arabesk müziğin kalbi burada atıyor";
            ms.metroPanel6.BackgroundImage = Image.FromFile("metro/reklam3.png");
            metroTile24.TileImage = Image.FromFile("metro/exit.png");
            metroTile24.Visible = true;
        }

        //mutlu
        private void metroTile14_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = false;
            metroPanel5.Dock = DockStyle.Fill;
            ms.TopLevel = false;
            metroPanel5.Controls.Add(ms);
            ms.Show();
            ms.Dock = DockStyle.Fill;
            ms.BringToFront();
            ms.webBrowser1.Navigate("https://www.youtube.com/watch?v=q66KuJfPT_Y&list=PLkPLz99FWW3ZYEu_RYt4TcE5WIhZIMcYu");
            ms.metroLabel2.Text = metroTile14.Text + "\n" + "Herşeyi boşver ve herzaman mutlu hisset";
            ms.metroPanel6.BackgroundImage = Image.FromFile("metro/reklam3.png");
            metroTile24.TileImage = Image.FromFile("metro/exit.png");
            metroTile24.Visible = true;
        }

        //enerjik
        private void metroTile15_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = false;
            metroPanel5.Dock = DockStyle.Fill;
            ms.TopLevel = false;
            metroPanel5.Controls.Add(ms);
            ms.Show();
            ms.Dock = DockStyle.Fill;
            ms.BringToFront();
            ms.webBrowser1.Navigate("https://www.youtube.com/c/NoCopyrightSounds/videos");
            ms.metroLabel2.Text = metroTile15.Text + "\n" + "Enerjini topla ve sahalara geri dön";
            ms.metroPanel6.BackgroundImage = Image.FromFile("metro/reklam3.png");
            metroTile24.TileImage = Image.FromFile("metro/exit.png");
            metroTile24.Visible = true;
        }

        //sakin
        private void metroTile16_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = false;
            metroPanel5.Dock = DockStyle.Fill;
            ms.TopLevel = false;
            metroPanel5.Controls.Add(ms);
            ms.Show();
            ms.Dock = DockStyle.Fill;
            ms.BringToFront();
            ms.webBrowser1.Navigate("https://www.youtube.com/c/SoothingRelaxation/videos");
            ms.metroLabel2.Text = metroTile16.Text + "\n" + "Bir tutam adaçayı ve sessizlik, \nyağmur damlaları şıpırdıyor pencereden";
            ms.metroPanel6.BackgroundImage = Image.FromFile("metro/reklam3.png");
            metroTile24.TileImage = Image.FromFile("metro/exit.png");
            metroTile24.Visible = true;
        }

        //uyku
        private void metroTile17_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = false;
            metroPanel5.Dock = DockStyle.Fill;
            ms.TopLevel = false;
            metroPanel5.Controls.Add(ms);
            ms.Show();
            ms.Dock = DockStyle.Fill;
            ms.BringToFront();
            ms.webBrowser1.Navigate("https://www.youtube.com/c/KumoSleepMusic/videos");
            ms.metroLabel2.Text = metroTile17.Text + "\n" + "Günün yorgunluğunu at, biraz rahatla ve uykuya dal";
            ms.metroPanel6.BackgroundImage = Image.FromFile("metro/reklam3.png");
            metroTile24.TileImage = Image.FromFile("metro/exit.png");
            metroTile24.Visible = true;
        }

        //kahve - coffee music
        private void metroTile18_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = false;
            metroPanel5.Dock = DockStyle.Fill;
            ms.TopLevel = false;
            metroPanel5.Controls.Add(ms);
            ms.Show();
            ms.Dock = DockStyle.Fill;
            ms.BringToFront();
            ms.webBrowser1.Navigate("https://www.youtube.com/c/cafemusicbgmchannel/videos");
            ms.metroLabel2.Text = metroTile18.Text + "\n" + "Hangi tür kahveyi seversen sev, duygular hep aynı, \nyanında müziksiz olur mu?";
            ms.metroPanel6.BackgroundImage = Image.FromFile("metro/reklam3.png");
            metroTile24.TileImage = Image.FromFile("metro/exit.png");
            metroTile24.Visible = true;
        }

        //romantik
        private void metroTile19_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = false;
            metroPanel5.Dock = DockStyle.Fill;
            ms.TopLevel = false;
            metroPanel5.Controls.Add(ms);
            ms.Show();
            ms.Dock = DockStyle.Fill;
            ms.BringToFront();
            ms.webBrowser1.Navigate("https://www.youtube.com/channel/UCGUy4HMHxCj33V2R7Rqr2zQ/videos");
            ms.metroLabel2.Text = metroTile19.Text + "\n" + "Bir kadeh kırmızı şarap, şarap olmasada olur, müzik olsun";
            ms.metroPanel6.BackgroundImage = Image.FromFile("metro/reklam3.png");
            metroTile24.TileImage = Image.FromFile("metro/exit.png");
            metroTile24.Visible = true;
        }

        //cocuklar
        private void metroTile20_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = false;
            metroPanel5.Dock = DockStyle.Fill;
            ms.TopLevel = false;
            metroPanel5.Controls.Add(ms);
            ms.Show();
            ms.Dock = DockStyle.Fill;
            ms.BringToFront();
            ms.webBrowser1.Navigate("https://www.youtube.com/c/Farmees/videos");
            ms.metroLabel2.Text = metroTile20.Text + "\n" + "Çocuklar bizim geleceğimiz, eğlenmek onlarında hakkı.";
            ms.metroPanel6.BackgroundImage = Image.FromFile("metro/reklam3.png");
            metroTile24.TileImage = Image.FromFile("metro/exit.png");
            metroTile24.Visible = true;
        }
        //---------------------------//
        //geri git vimeo
        private void metroTile25_Click(object sender, EventArgs e)
        {
            webControl1.WebView.GoBack();
           
        }
        //ileri git vimeo
        private void metroTile26_Click(object sender, EventArgs e)
        {
            webControl1.WebView.GoForward();
        }
        //motivasyon bolumu geri git butonu
        private void metroTile27_Click(object sender, EventArgs e)
        {
            webBrowser2.GoBack();
        }
        //motivasyon bolumu ileri butonu
        private void metroTile28_Click(object sender, EventArgs e)
        {
            webBrowser2.GoForward();
        }
        //motivasyon bolumu sayfayı yenile butonu
        private void refresh()
        {
            pictureBox12.Image = Image.FromFile("metro/gg.gif");
            Thread.Sleep(2000);
            pictureBox12.Image = Image.FromFile("metro/reload.png");
            webBrowser2.Refresh();
        }
        //sayfayı yenile butonu - ustekini tetikler
        private void pictureBox12_Click(object sender, EventArgs e)
        {
            Thread motive_refresh = new Thread(new ThreadStart(refresh));
            motive_refresh.Start();
        }
        isteklistesi istek = new isteklistesi();

        private void metroTile22_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = false;
            metroPanel5.Dock = DockStyle.Fill;
            istek.TopLevel = false;
            metroPanel5.Controls.Add(istek);
            istek.Show();
            istek.Dock = DockStyle.Fill;
            istek.BringToFront();
            metroTile24.TileImage = Image.FromFile("metro/exit.png");
            metroTile24.Visible = true;

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = false;
            metroPanel5.Dock = DockStyle.Fill;
            ytform.TopLevel = false;
            metroPanel5.Controls.Add(ytform);
            ytform.Show();
            ytform.webBrowser1.Navigate("https://www.youtube.com/results?search_query="+metroTextBox1.Text);
            ytform.Dock = DockStyle.Fill;
            ytform.BringToFront();
            metroTile24.TileImage = Image.FromFile("metro/exit.png");
            metroTile24.Visible = true;
            metroTile23.Enabled = false;
            metroTextBox1.Enabled = false;
            pictureBox15.Enabled = false;

        }

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            pictureBox15.Enabled = true;
        }

        private void metroLink2_Click(object sender, EventArgs e)
        {
            geribildirim3.Show();
        }

        private void metroLink3_Click(object sender, EventArgs e)
        {
            geribildirim.Show();
        }





        //-----------------------------------------------//

    }
}





//listBox1.Items.Clear();
////GetFiles metodu dosyaları temsil eder. Belirtilen Dizindeki Dosyaları Dizi olarak döndürür
//string[] dosyalar = System.IO.Directory.GetFiles("C:/Users/YASİN CAN/Music");
//for (int j = 0; j < dosyalar.Length; j++)
//{
//    listBox1.Items.Add(dosyalar[j]);
//}
//DirectoryInfo fileinfo = new DirectoryInfo(@"C:/Users/YASİN CAN/Music");
//foreach (FileInfo e2 in fileinfo.GetFiles())
//{
//    listBox2.Items.Add(e2.Name);
//}




//for (int j = 0; j < openFileDialog1.SafeFileNames.Length; j++)
//{
//    localmusic.Open();
//    OleDbCommand ekle = new OleDbCommand("insert into yerelyol(sarkiurl) values ('" + openFileDialog1.FileNames[j] + "')", localmusic);
//    ekle.ExecuteNonQuery();
//    localmusic.Close();

//}