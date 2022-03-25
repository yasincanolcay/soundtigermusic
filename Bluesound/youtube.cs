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
using VideoLibrary;
using MediaToolkit;
using System.IO;


namespace Bluesound
{
    public partial class youtube : Form
    {
        public youtube()
        {
            InitializeComponent();
            System.Windows.Forms.Form.CheckForIllegalCrossThreadCalls = false; //thread calısması icin kod

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com");
        }

        private void youtube_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("metro/youtube.png");
            Thread.Sleep(1000);
            metroTile1.TileImage = Image.FromFile("metro/ytback.png");
            Thread.Sleep(100);
            metroTile2.TileImage = Image.FromFile("metro/ytnext.png");
            Thread.Sleep(100);
            pictureBox2.Image = Image.FromFile("metro/reload.png");
            Thread.Sleep(100);
            metroTile3.TileImage = Image.FromFile("metro/ytdownload.png");
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void web_refresh()
        {
            pictureBox2.Image = Image.FromFile("metro/gg.gif");
            Thread.Sleep(2000);
            pictureBox2.Image = Image.FromFile("metro/reload.png");
            webBrowser1.Refresh();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Thread refresh = new Thread(new ThreadStart(web_refresh));
            refresh.Start();
        }

        Boolean format = true;

        private async void metroTile3_Click(object sender, EventArgs e)
        {
            try
            {
                using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "İndirilecek klasör seçiniz" })
                {

                    if (fbd.ShowDialog() == DialogResult.OK)
                    {
                        metroProgressSpinner1.Enabled = true;
                        metroProgressSpinner1.Visible = true;
                        metroLabel3.Text = "İndiriliyor...";
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





                    }
                    else
                    {
                        MessageBox.Show("Lütfen dosya yolu belirtiniz", "uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    metroLabel3.Text = "İndirme başarılı✔";
                    metroProgressSpinner1.Visible = false;
                    metroProgressSpinner1.Enabled = false;

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Geçerli bir video seçiniz", "uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                metroLabel3.Text = "Geçersiz seçim";
                metroProgressSpinner1.Visible = false;
                metroProgressSpinner1.Enabled = false;

            }

        }
    }
}
