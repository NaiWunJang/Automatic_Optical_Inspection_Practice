
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
            this.ReadingResult_textBox = new System.Windows.Forms.TextBox();
            this.ReadingResult_Label = new System.Windows.Forms.Label();
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
            // ReadingResult_textBox
            // 
            this.ReadingResult_textBox.Location = new System.Drawing.Point(570, 472);
            this.ReadingResult_textBox.Name = "ReadingResult_textBox";
            this.ReadingResult_textBox.Size = new System.Drawing.Size(171, 23);
            this.ReadingResult_textBox.TabIndex = 4;
            // 
            // ReadingResult_Label
            // 
            this.ReadingResult_Label.AutoSize = true;
            this.ReadingResult_Label.Location = new System.Drawing.Point(570, 451);
            this.ReadingResult_Label.Name = "ReadingResult_Label";
            this.ReadingResult_Label.Size = new System.Drawing.Size(100, 15);
            this.ReadingResult_Label.TabIndex = 5;
            this.ReadingResult_Label.Text = "Reading Results:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 565);
            this.Controls.Add(this.ReadingResult_Label);
            this.Controls.Add(this.ReadingResult_textBox);
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
        private System.Windows.Forms.TextBox ReadingResult_textBox;
        private System.Windows.Forms.Label ReadingResult_Label;
    }
}

