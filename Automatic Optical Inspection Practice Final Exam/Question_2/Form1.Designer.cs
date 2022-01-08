
namespace Finals
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Reading_Button = new System.Windows.Forms.Button();
            this.Finding_Button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.RedLineOriginX_Label = new System.Windows.Forms.Label();
            this.RedLinePositionX_textBox = new System.Windows.Forms.TextBox();
            this.RedLineOriginY_Label = new System.Windows.Forms.Label();
            this.RedLinePositionY_textBox = new System.Windows.Forms.TextBox();
            this.Counting_Button = new System.Windows.Forms.Button();
            this.number_Label = new System.Windows.Forms.Label();
            this.Number_textBox = new System.Windows.Forms.TextBox();
            this.TeethDistance_Label = new System.Windows.Forms.Label();
            this.TeethDistance_textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Reading_Button
            // 
            this.Reading_Button.Location = new System.Drawing.Point(437, 92);
            this.Reading_Button.Name = "Reading_Button";
            this.Reading_Button.Size = new System.Drawing.Size(112, 59);
            this.Reading_Button.TabIndex = 0;
            this.Reading_Button.Text = "Reading";
            this.Reading_Button.UseVisualStyleBackColor = true;
            this.Reading_Button.Click += new System.EventHandler(this.ReadingButton_Click);
            // 
            // Finding_Button
            // 
            this.Finding_Button.Location = new System.Drawing.Point(437, 187);
            this.Finding_Button.Name = "Finding_Button";
            this.Finding_Button.Size = new System.Drawing.Size(112, 59);
            this.Finding_Button.TabIndex = 1;
            this.Finding_Button.Text = "Finding";
            this.Finding_Button.UseVisualStyleBackColor = true;
            this.Finding_Button.Click += new System.EventHandler(this.FindingButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(21, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(392, 358);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(574, 52);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(392, 358);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // RedLineOriginX_Label
            // 
            this.RedLineOriginX_Label.AutoSize = true;
            this.RedLineOriginX_Label.Location = new System.Drawing.Point(21, 457);
            this.RedLineOriginX_Label.Name = "RedLineOriginX_Label";
            this.RedLineOriginX_Label.Size = new System.Drawing.Size(104, 15);
            this.RedLineOriginX_Label.TabIndex = 4;
            this.RedLineOriginX_Label.Text = "Origin X Position:";
            // 
            // RedLinePositionX_textBox
            // 
            this.RedLinePositionX_textBox.Location = new System.Drawing.Point(21, 475);
            this.RedLinePositionX_textBox.Name = "RedLinePositionX_textBox";
            this.RedLinePositionX_textBox.Size = new System.Drawing.Size(198, 23);
            this.RedLinePositionX_textBox.TabIndex = 5;
            // 
            // RedLineOriginY_Label
            // 
            this.RedLineOriginY_Label.AutoSize = true;
            this.RedLineOriginY_Label.Location = new System.Drawing.Point(21, 526);
            this.RedLineOriginY_Label.Name = "RedLineOriginY_Label";
            this.RedLineOriginY_Label.Size = new System.Drawing.Size(103, 15);
            this.RedLineOriginY_Label.TabIndex = 6;
            this.RedLineOriginY_Label.Text = "Origin Y Position:";
            // 
            // RedLinePositionY_textBox
            // 
            this.RedLinePositionY_textBox.Location = new System.Drawing.Point(21, 544);
            this.RedLinePositionY_textBox.Name = "RedLinePositionY_textBox";
            this.RedLinePositionY_textBox.Size = new System.Drawing.Size(198, 23);
            this.RedLinePositionY_textBox.TabIndex = 7;
            // 
            // Counting_Button
            // 
            this.Counting_Button.Location = new System.Drawing.Point(437, 280);
            this.Counting_Button.Name = "Counting_Button";
            this.Counting_Button.Size = new System.Drawing.Size(112, 59);
            this.Counting_Button.TabIndex = 8;
            this.Counting_Button.Text = "Counting";
            this.Counting_Button.UseVisualStyleBackColor = true;
            this.Counting_Button.Click += new System.EventHandler(this.CountingButton_Click);
            // 
            // number_Label
            // 
            this.number_Label.AutoSize = true;
            this.number_Label.Location = new System.Drawing.Point(574, 457);
            this.number_Label.Name = "number_Label";
            this.number_Label.Size = new System.Drawing.Size(57, 15);
            this.number_Label.TabIndex = 9;
            this.number_Label.Text = "Number:";
            // 
            // Number_textBox
            // 
            this.Number_textBox.Location = new System.Drawing.Point(574, 474);
            this.Number_textBox.Name = "Number_textBox";
            this.Number_textBox.Size = new System.Drawing.Size(100, 23);
            this.Number_textBox.TabIndex = 10;
            // 
            // TeethDistance_Label
            // 
            this.TeethDistance_Label.AutoSize = true;
            this.TeethDistance_Label.Location = new System.Drawing.Point(574, 525);
            this.TeethDistance_Label.Name = "TeethDistance_Label";
            this.TeethDistance_Label.Size = new System.Drawing.Size(89, 15);
            this.TeethDistance_Label.TabIndex = 11;
            this.TeethDistance_Label.Text = "teeth distance:";
            // 
            // TeethDistance_textBox
            // 
            this.TeethDistance_textBox.Location = new System.Drawing.Point(574, 544);
            this.TeethDistance_textBox.Name = "TeethDistance_textBox";
            this.TeethDistance_textBox.Size = new System.Drawing.Size(100, 23);
            this.TeethDistance_textBox.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 656);
            this.Controls.Add(this.TeethDistance_textBox);
            this.Controls.Add(this.TeethDistance_Label);
            this.Controls.Add(this.Number_textBox);
            this.Controls.Add(this.number_Label);
            this.Controls.Add(this.Counting_Button);
            this.Controls.Add(this.RedLinePositionY_textBox);
            this.Controls.Add(this.RedLineOriginY_Label);
            this.Controls.Add(this.RedLinePositionX_textBox);
            this.Controls.Add(this.RedLineOriginX_Label);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Finding_Button);
            this.Controls.Add(this.Reading_Button);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Reading_Button;
        private System.Windows.Forms.Button Finding_Button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label RedLineOriginX_Label;
        private System.Windows.Forms.TextBox RedLinePositionX_textBox;
        private System.Windows.Forms.Label RedLineOriginY_Label;
        private System.Windows.Forms.TextBox RedLinePositionY_textBox;
        private System.Windows.Forms.Button Counting_Button;
        private System.Windows.Forms.Label number_Label;
        private System.Windows.Forms.TextBox Number_textBox;
        private System.Windows.Forms.Label TeethDistance_Label;
        private System.Windows.Forms.TextBox TeethDistance_textBox;
    }
}

