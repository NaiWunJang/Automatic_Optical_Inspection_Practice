
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
            this.Area_Label = new System.Windows.Forms.Label();
            this.Area_textBox = new System.Windows.Forms.TextBox();
            this.Diameter_Label = new System.Windows.Forms.Label();
            this.Diameter_textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Reading_Button
            // 
            this.Reading_Button.Location = new System.Drawing.Point(437, 148);
            this.Reading_Button.Name = "Reading_Button";
            this.Reading_Button.Size = new System.Drawing.Size(112, 59);
            this.Reading_Button.TabIndex = 0;
            this.Reading_Button.Text = "Reading";
            this.Reading_Button.UseVisualStyleBackColor = true;
            this.Reading_Button.Click += new System.EventHandler(this.ReadingButton_Click);
            // 
            // Finding_Button
            // 
            this.Finding_Button.Location = new System.Drawing.Point(437, 243);
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
            this.pictureBox2.Location = new System.Drawing.Point(570, 52);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(392, 358);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // Area_Label
            // 
            this.Area_Label.AutoSize = true;
            this.Area_Label.Location = new System.Drawing.Point(570, 438);
            this.Area_Label.Name = "Area_Label";
            this.Area_Label.Size = new System.Drawing.Size(36, 15);
            this.Area_Label.TabIndex = 4;
            this.Area_Label.Text = "Area:";
            // 
            // Area_textBox
            // 
            this.Area_textBox.Location = new System.Drawing.Point(570, 456);
            this.Area_textBox.Name = "Area_textBox";
            this.Area_textBox.Size = new System.Drawing.Size(100, 23);
            this.Area_textBox.TabIndex = 5;
            // 
            // Diameter_Label
            // 
            this.Diameter_Label.AutoSize = true;
            this.Diameter_Label.Location = new System.Drawing.Point(570, 502);
            this.Diameter_Label.Name = "Diameter_Label";
            this.Diameter_Label.Size = new System.Drawing.Size(62, 15);
            this.Diameter_Label.TabIndex = 6;
            this.Diameter_Label.Text = "Diameter:";
            // 
            // Diameter_textBox
            // 
            this.Diameter_textBox.Location = new System.Drawing.Point(570, 520);
            this.Diameter_textBox.Name = "Diameter_textBox";
            this.Diameter_textBox.Size = new System.Drawing.Size(100, 23);
            this.Diameter_textBox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 565);
            this.Controls.Add(this.Diameter_textBox);
            this.Controls.Add(this.Diameter_Label);
            this.Controls.Add(this.Area_textBox);
            this.Controls.Add(this.Area_Label);
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
        private System.Windows.Forms.Label Area_Label;
        private System.Windows.Forms.TextBox Area_textBox;
        private System.Windows.Forms.Label Diameter_Label;
        private System.Windows.Forms.TextBox Diameter_textBox;
    }
}

