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
            int positionDeviation = 10;

            for (int x = 0; x < prc_blob_img.Width; x++)
            {

                Color pixelColor = prc_blob_img.GetPixel(x, Maximum_Y);
                    
                if (pixelColor.R == 255)
                {
                    RedLinePositionX_textBox.Text = (x - 1).ToString();
                    break;
                }
                
            }

            for (int y = prc_blob_img.Height - 1; y > 0; y--)
            {
                int index_X = Int16.Parse(RedLinePositionX_textBox.Text);
                Color pixelColor = prc_blob_img.GetPixel(index_X / 2, y);

                if (pixelColor.R == 255) {
                    
                    using (Graphics g = Graphics.FromImage(prc_blob_img))
                    {
                        g.DrawLine(new Pen(Color.Red), (index_X - positionDeviation), Maximum_Y, (index_X - positionDeviation), y + 1);
                    }
                    RedLinePositionY_textBox.Text = (y + 1).ToString();
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
            int X = Int16.Parse(RedLinePositionX_textBox.Text);
            int Y = Int16.Parse(RedLinePositionY_textBox.Text);

            bool countflag = false;
            int maximum_teethdistance = 5;
            int count = 0;
            int whitePixelNumber = 0;
            int blackPixelNumber = 0;
            int surplus = 0;
            int y = Y;

            for (; y <= Maximum_Y; y++) {
                
                Color pixelColor = blob_img.GetPixel(X, y);

                switch (pixelColor.R) 
                {
                    case 255 :
                        whitePixelNumber++;
                        
                        if (!countflag)
                        {
                            count++;
                            countflag = true;
                        }

                        continue;
                    
                    default :
                        
                        countflag = false;
                        
                        if (count == 0 || count == maximum_teethdistance) 
                        {
                            surplus++;
                        }
                        else
                        {
                            blackPixelNumber++;
                        }

                        continue;
                }
            }
            

            Number_textBox.Text = count.ToString();
            TeethDistance_textBox.Text = ((Maximum_Y - surplus - whitePixelNumber) / (count - 1)).ToString();

        }

        private void Clear_allTextBox()
        {
            RedLinePositionX_textBox.Text = "";
            RedLinePositionY_textBox.Text = "";
            Number_textBox.Text = "";
            TeethDistance_textBox.Text = "";
        }
    }
}
