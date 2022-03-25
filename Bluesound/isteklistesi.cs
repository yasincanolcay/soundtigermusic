using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoLibrary;
using MediaToolkit;
using MediaToolkit.Model;
using System.IO;

namespace Bluesound
{
    public partial class isteklistesi : Form
    {
        public isteklistesi()
        {
            InitializeComponent();
        }
        OleDbConnection soundtiger = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|soundtiger.mdb");
        Boolean format = true;

        private void metroListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void isteklistesi_Load(object sender, EventArgs e)
        {
            metroTile1.Enabled = false;
            metroTile2.Enabled = false;
            soundtiger.Open();

            OleDbCommand istek = new OleDbCommand();
            istek.Connection = soundtiger;
            istek.CommandText = ("Select * From istek");
            OleDbDataReader getir = istek.ExecuteReader();
            listBox1.Items.Clear();
            while (getir.Read())
            {


                listBox1.Items.Add((string)getir["istekurl"]);
               

                

            }

            soundtiger.Close();


        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private async void metroTile1_Click(object sender, EventArgs e)
        {
            metroProgressBar1.Visible = true;
            metroProgressBar1.Value = 5;
            metroLabel1.Text = "İndiriliyor...";
            using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "İndirilecek klasör seçiniz" })
            {

                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    metroProgressBar1.Value = 10;

                    var yt = YouTube.Default;
                    var videos = await yt.GetVideoAsync(listBox1.Text);
                    File.WriteAllBytes(fbd.SelectedPath + @"\" + videos.FullName, await videos.GetBytesAsync());
                    var inputfile = new MediaToolkit.Model.MediaFile { Filename = fbd.SelectedPath + @"\" + videos.FullName };
                    var outputfile = new MediaToolkit.Model.MediaFile { Filename = $"{fbd.SelectedPath + @"\" + videos.FullName}.mp3" };
                    metroProgressBar1.Value = 50;

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

                
                }
                else
                {
                    MessageBox.Show("Lütfen dosya yolu belirtiniz", "uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                metroProgressBar1.Value = 100;
                metroProgressBar1.Visible = false;
                metroProgressBar1.Value = 0;
                metroLabel1.Text = "İndirme başarılı ✔";

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            metroTile1.Enabled = true;
            metroTile2.Enabled = true;
        }
        OleDbCommand kaldir = new OleDbCommand();

        private void metroTile2_Click(object sender, EventArgs e)
        {
            soundtiger.Open();
            kaldir.Connection = soundtiger;
            kaldir.CommandText = "delete from istek where istekurl='" + listBox1.Text + "'";
            kaldir.ExecuteNonQuery();
            soundtiger.Close();

            listBox1.Items.Remove(listBox1.SelectedItem);

        }
    }
}
