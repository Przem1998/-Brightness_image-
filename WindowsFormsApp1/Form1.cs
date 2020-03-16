using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeBackgroundWorker();
        }
        private Bitmap orBitmap;
        private Bitmap tempBitmap;
        Color color;
        int r = 0, g = 0, b = 0;
        private void InitializeBackgroundWorker()
          {
              bw.DoWork += new DoWorkEventHandler(bw_DoWork);
          
              bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_RunWorkerCompleted);
          }

      

        private void otwórzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openImage = new OpenFileDialog())
            {
                openImage.InitialDirectory = "c:\\";
                openImage.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
                openImage.FilterIndex = 2;
                openImage.RestoreDirectory = true;

                if (openImage.ShowDialog() == DialogResult.OK)
                {
                 

                    orBitmap = new Bitmap(openImage.OpenFile());

                    picture.Image = orBitmap;

                }
        
                
            }
        }

        private void brightnessScale_Scroll(object sender, EventArgs e)
        {
            percent.Text = brightnessScale.Value + "%";
            if (bw.IsBusy != true)
                bw.RunWorkerAsync(brightnessScale.Value);
        
        }
        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            e.Result = brightnessImage((int)e.Argument);
        }
        private void bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
         //   progressBar.Value = e.ProgressPercentage;
        }

        private void anulujToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (tempBitmap != null)
            {
                picture.Image = orBitmap;
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void zapiszToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (orBitmap != null)
            {
                using (SaveFileDialog saveImage = new SaveFileDialog())
                {
                    saveImage.InitialDirectory = "c:\\";
                    saveImage.Filter = "Image (*.jpeg) |*.jpeg; |Image (*.png)|*.png";
                    saveImage.FilterIndex = 2;
                    saveImage.RestoreDirectory = true;

                    if (saveImage.ShowDialog() == DialogResult.OK)
                    {
                        if (saveImage.FilterIndex == 1)
                        {
                            picture.Image.Save(saveImage.FileName, ImageFormat.Jpeg);
                        }
                        else picture.Image.Save(saveImage.FileName, ImageFormat.Png);
                    }
                }
            }
            else MessageBox.Show("Brak otworzonego pliku");
        }

        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            picture.Image = (Bitmap)e.Result;
        }

        Bitmap brightnessImage(int br)
        {
           tempBitmap = (Bitmap)orBitmap.Clone();
           // int index = 1;
            int width = orBitmap.Width;
            int height = orBitmap.Height;
            //   int multiple = width * height;
            int value;
            if (br == 0 || br == 1) value = 1;
            else value = br + 100;
                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        r = (orBitmap.GetPixel(x, y).R + value) > 255 ? r = 255 : r = orBitmap.GetPixel(x, y).R + value;
                        g = (orBitmap.GetPixel(x, y).G + value) > 255 ? g = 255 : g = orBitmap.GetPixel(x, y).G + value;
                        b = (orBitmap.GetPixel(x, y).B +value) > 255 ? b = 255 : b = orBitmap.GetPixel(x, y).B + value;

                        color = Color.FromArgb(r, g, b);
                        if (color == Color.FromArgb(255, 0, 0)) MessageBox.Show("błąd");
                        tempBitmap.SetPixel(x, y, color);
               
                    }

                }

            return tempBitmap;
        }
    }
    }
