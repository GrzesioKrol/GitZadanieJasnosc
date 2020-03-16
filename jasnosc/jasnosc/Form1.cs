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

namespace jasnosc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Image image;
        Bitmap bm;
        float progress;
        float b;
        Color color;
        private void Wstaw_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Image Files(*.png; *.jpg;)|*.png; *.jpg;";
            if (op.ShowDialog() == DialogResult.OK)
            {
                obrazek.Image = new Bitmap(op.FileName);
            }
            image = obrazek.Image;           
        }

        private void Bar_Scroll(object sender, EventArgs e)
        {
            Label.Text = Bar.Value.ToString();
            progress = Bar.Value;
        }     
        private void jasnosc_Click(object sender, EventArgs e)
        {            
            bw.RunWorkerAsync();            
        }

        private void Zapis_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string sciezka= fbd.SelectedPath + "/obrazek.png";
                bm.Save(sciezka);
            }
        }

        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            b = (float)progress / 255.0f;
            bm = new Bitmap(image);
            double report2 = 0.1;
            double report = Math.Abs(100.0 / bm.Height);
            int stop = 0;
            for (int y = 0; y < bm.Height; y++)
            {
                if (bw.CancellationPending)
                {
                    e.Cancel = true;
                }
                else
                {
                    for (int x = 0; x < bm.Width; x++)
                    {
                        color = bm.GetPixel(x, y);
                        color = ChangeColorBrightness(color, b);
                        bm.SetPixel(x, y, color);
                    }
                    obrazek.Image = bm;
                    System.Threading.Thread.Sleep(15);
                    report2 += report;
                    bw.ReportProgress((int)report2);
                }
            }
        }
        
        private void bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {            
             progressBar.Value = e.ProgressPercentage;
        }

        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            obrazek.Image = bm;
        }
        private void anuluj_Click(object sender, EventArgs e)
        {
            bw.CancelAsync();        
        }

        private Color ChangeColorBrightness(Color color, float correctionFactor)
        {
            float red = (float)color.R;
            float green = (float)color.G;
            float blue = (float)color.B;

            if (correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }
            else
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }

            return Color.FromArgb(color.A, (int)red, (int)green, (int)blue);
        }
    }
}
