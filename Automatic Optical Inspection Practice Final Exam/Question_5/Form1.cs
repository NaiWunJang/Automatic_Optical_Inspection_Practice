using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AForge;
using AForge.Math;
using AForge.Imaging;
using AForge.Imaging.Filters;
using AForge.Imaging.Formats;

using Tesseract;


namespace Finals
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Bitmap src_img, prc_img;

        private void ReadingButton_Click(object sender, EventArgs e)
        {
            src_img = ImageDecoder.DecodeFromFile("Ocr_004.bmp");
            pictureBox1.Image = src_img;
            prc_img = new Bitmap(src_img);

            Grayscale filter1 = new Grayscale(0.2125, 0.7154, 0.0721);
            prc_img = filter1.Apply(prc_img);
            OtsuThreshold filter2 = new OtsuThreshold();
            filter2.ApplyInPlace(prc_img);
            Invert filter3 = new Invert();
            filter3.ApplyInPlace(prc_img);

            pictureBox2.Image = prc_img;
        }

        private void FindingButton_Click(object sender, EventArgs e)
        {
         
            TesseractEngine engine = new TesseractEngine(@"./tessdata", "eng", EngineMode.Default);
            var page = engine.Process(prc_img, PageSegMode.Auto);
            ReadingResult_textBox.Text = page.GetText();

        }
    }
}
