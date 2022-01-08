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
            src_img = ImageDecoder.DecodeFromFile("Nut_0.bmp");
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
            Reading_Button.PerformClick();

            ExtractBiggestBlob filter1 = new ExtractBiggestBlob();
            Bitmap blob_img = filter1.Apply(prc_img);
            Invert filter2 = new Invert();
            filter2.ApplyInPlace(blob_img);
            blob_img = filter1.Apply(blob_img);
            
            BlobCounterBase bc = new BlobCounter();
            bc.FilterBlobs = true;
            bc.MinWidth = 5;
            bc.MinHeight = 5;
            bc.ObjectsOrder = ObjectsOrder.Area;
            bc.ProcessImage(blob_img);

            Blob[] blobs = bc.GetObjectsInformation();

            pictureBox2.Image = blob_img;
            Area_textBox.Text = blobs[0].Area.ToString();
            Diameter_textBox.Text = blob_img.Width.ToString();
            
        }
    }
}
