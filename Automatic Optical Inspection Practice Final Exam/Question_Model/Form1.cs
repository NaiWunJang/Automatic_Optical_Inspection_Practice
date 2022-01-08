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

        private void readingButton_Click(object sender, EventArgs e)
        {
            src_img = ImageDecoder.DecodeFromFile("Bolt_0.bmp");
            pictureBox1.Image = src_img;
            prc_img = new Bitmap(src_img);

        }

        private void findingButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
