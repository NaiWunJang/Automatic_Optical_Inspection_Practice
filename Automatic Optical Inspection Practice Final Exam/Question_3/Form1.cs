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

        Bitmap src_img, prc_img, blob_img;
        int Maximum_Y;

        private void ReadingButton_Click(object sender, EventArgs e)
        {
            Clear_allTextBox();

            src_img = ImageDecoder.DecodeFromFile("Bolt_0.bmp");
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
            Clear_allTextBox();
            Reading_Button.PerformClick();
                
            ExtractBiggestBlob filter = new ExtractBiggestBlob();
            blob_img = filter.Apply(prc_img);
            
            Bitmap prc_blob_img = new Bitmap(blob_img);
            
            Maximum_Y = prc_blob_img.Height - 1;
            int positionDeviation = 5;

            for (int y = Maximum_Y; y > 0; y--)
            {
                Color pixelColor = prc_blob_img.GetPixel(0, y);

                if (pixelColor.R == 255)
                { 
                    RedLinePositionY_textBox.Text = (y + 1 + positionDeviation).ToString();
                    break;
                }

            }

            for (int x = 0; x < prc_blob_img.Width; x++)
            {
                int index_Y = Int16.Parse(RedLinePositionY_textBox.Text) ;
                Color pixelColor = prc_blob_img.GetPixel(x, index_Y);
                    
                if (pixelColor.R == 255)
                {
                    using (Graphics g = Graphics.FromImage(prc_blob_img))
                    {
                        g.DrawLine(new Pen(Color.Red), 0, index_Y, x - 1, index_Y);
                    }

                    RedLinePositionX_textBox.Text = (x - 1).ToString();
                    break;
                }
                
            }

            pictureBox1.Image = blob_img;
            pictureBox2.Image = prc_blob_img;
            
        }

        private void CountingButton_Click(object sender, EventArgs e)
        {
            Reading_Button.PerformClick();
            Finding_Button.PerformClick();
            //Touch off the click event of Reading_Button and Finding_Button.

            int X = Int16.Parse(RedLinePositionX_textBox.Text);
            int Y = Int16.Parse(RedLinePositionY_textBox.Text);
            
            int x = X;
            int y = Y;
            int positionDeriation = 5;
            int count = 0;

            for (; y <= Maximum_Y; y++)
            {

                Color pixelColor = blob_img.GetPixel(X, y);

                if (pixelColor.R == 255)
                {
                    for (; x > 0; x--)
                    {
                        pixelColor = blob_img.GetPixel(x, y + positionDeriation);
                        count++;

                        if (pixelColor.R != 255)
                        {
                            break;
                        }
                    }
                    break;
                }
            }

            ToothDepth_textBox.Text = count.ToString();
        }

        private void Clear_allTextBox()
        {
            RedLinePositionX_textBox.Text = "";
            RedLinePositionY_textBox.Text = "";
            ToothDepth_textBox.Text = "";
        }
    }
}
