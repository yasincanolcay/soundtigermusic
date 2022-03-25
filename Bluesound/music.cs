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
using System.IO;
using System.Data.OleDb;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using VideoLibrary;
using MediaToolkit;
using MediaToolkit.Model;

namespace Bluesound
{
    public partial class music : Form
    {
        
        
       
       
        
        public music()
        {
            InitializeComponent();
            System.Windows.Forms.Form.CheckForIllegalCrossThreadCalls = false; //thread calısması icin kod

        }

        Boolean format = true;

        //iconların yuklenmesi
        private void load_elements()
        {
            metroTile1.TileImage = Image.FromFile("metro/indir.png");
            Thread.Sleep(20);
            metroTile2.TileImage = Image.FromFile("metro/musices.png");
            Thread.Sleep(20);
            metroTile3.TileImage = Image.FromFile("metro/ytback.png");
            Thread.Sleep(20);
            metroTile4.TileImage = Image.FromFile("metro/ytnext.png");
            Thread.Sleep(20);
            pictureBox1.Image = Image.FromFile("metro/reload.png");



        }
        private void music_Load(object sender, EventArgs e)
        {
            Thread load = new Thread(new ThreadStart(load_elements));
            load.Start();
        }
       
        

        //indirme islemi
        private async void metroTile1_Click(object sender, EventArgs e)
        {

            using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "İndirilecek klasör seçiniz" })
            {

                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    metroLabel3.Visible = false;
                    metroProgressSpinner1.Visible = true;
                    metroProgressSpinner1.Enabled = true;
                    var yt = YouTube.Default;
                    var videos = await yt.GetVideoAsync(webBrowser1.Url.ToString());
                    File.WriteAllBytes(fbd.SelectedPath + @"\" + videos.FullName, await videos.GetBytesAsync());
                    var inputfile = new MediaToolkit.Model.MediaFile { Filename = fbd.SelectedPath + @"\" + videos.FullName };
                    var outputfile = new MediaToolkit.Model.MediaFile { Filename = $"{fbd.SelectedPath + @"\" + videos.FullName}.mp3" };

                    using (var engine = new Engine())
                    {

                        engine.GetMetadata(inputfile);
                        engine.Convert(inputfile, outputfile);


                    }
                    if (format == true)
                    {
                        File.Delete(fbd.SelectedPath + @"\" + videos.FullName);
                    }
                    else
                    {
                        File.Delete($"{fbd.SelectedPath + @"\" + videos.FullName}.mp3");
                    }

                    Thread.Sleep(1000);
                  
                    metroLabel3.Visible = true;
                    metroProgressSpinner1.Visible = false;
                    metroProgressSpinner1.Enabled = false;
                


                }
                else
                {
                    MessageBox.Show("Lütfen dosya yolu belirtiniz", "uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }


        }
        OleDbConnection soundtiger = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|soundtiger.mdb");

        private void metroTile2_Click(object sender, EventArgs e)
        {
            
            
            //sarkilarin konumunu veritabanina yazdir
            soundtiger.Open();
            OleDbCommand ekle = new OleDbCommand("insert into istek(istekurl) values ('" + webBrowser1.Url.ToString() + "')", soundtiger);
                
            ekle.ExecuteNonQuery();
            soundtiger.Close();
            
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            

          
  
         

        }

        private void metroTile3_Click_1(object sender, EventArgs e)
        {
            webBrowser1.GoBack(); //geri git butonu
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward(); //ileri git butonu
        }

        private void anan()
        {
            pictureBox1.Image = Image.FromFile("metro/gg.gif");
            Thread.Sleep(2000);
            pictureBox1.Image = Image.FromFile("metro/reload.png");
            webBrowser1.Refresh();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Thread allahbelanıversin = new Thread(new ThreadStart(anan));
            allahbelanıversin.Start();
           
          
        }

   
    }
}





