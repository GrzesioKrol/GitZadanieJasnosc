using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
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

        private void Wstaw_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Image Files(*.png; *.jpeg;)|*.png; *.jpeg;";
            if (op.ShowDialog() == DialogResult.OK)
            {
                obrazek.Image = new Bitmap(op.FileName);
            }
            image = obrazek.Image;
        }

        private void Bar_Scroll(object sender, EventArgs e)
        {
            Label.Text = Bar.Value.ToString();
        }     
        private void jasnosc_Click(object sender, EventArgs e)
        {            
            float b = (float)Bar.Value / 255.0f;
            ColorMatrix cm = new ColorMatrix(new float[][]
                {
                new float[] {1, 0, 0, 0, 0},
                new float[] {0, 1, 0, 0, 0},
                new float[] {0, 0, 1, 0, 0},
                new float[] {0, 0, 0, 1, 0},
                new float[] {b, b, b, 1, 1},
                });
            ImageAttributes attributes = new ImageAttributes();
            attributes.SetColorMatrix(cm);
            Point[] points =
                {
                new Point(0, 0),
                new Point(image.Width, 0),
                new Point(0, image.Height),
                };
            Rectangle rect = new Rectangle(0, 0, image.Width, image.Height);
            bm = new Bitmap(image.Width, image.Height);
            using (Graphics gr = Graphics.FromImage(bm))
            {
                gr.DrawImage(image, points, rect,
                    GraphicsUnit.Pixel, attributes);
            }           
            obrazek.Image = bm;           
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
    }
}
