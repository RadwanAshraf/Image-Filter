namespace Image_Filter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.OpenB = new System.Windows.Forms.Button();
            this.grayB = new System.Windows.Forms.Button();
            this.RandomB = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.negativeB = new System.Windows.Forms.Button();
            this.saveB = new System.Windows.Forms.Button();
            this.sobelB = new System.Windows.Forms.Button();
            this.refillColorsConvert = new System.Windows.Forms.Button();
            this.redB = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // OpenB
            // 
            this.OpenB.Location = new System.Drawing.Point(949, 48);
            this.OpenB.Name = "OpenB";
            this.OpenB.Size = new System.Drawing.Size(117, 23);
            this.OpenB.TabIndex = 0;
            this.OpenB.Text = "Open";
            this.OpenB.UseVisualStyleBackColor = true;
            this.OpenB.Click += new System.EventHandler(this.OpenB_Click);
            // 
            // grayB
            // 
            this.grayB.Location = new System.Drawing.Point(948, 330);
            this.grayB.Name = "grayB";
            this.grayB.Size = new System.Drawing.Size(117, 23);
            this.grayB.TabIndex = 1;
            this.grayB.Text = "RGB Mask";
            this.grayB.UseVisualStyleBackColor = true;
            this.grayB.Click += new System.EventHandler(this.grayB_Click);
            // 
            // RandomB
            // 
            this.RandomB.Location = new System.Drawing.Point(949, 534);
            this.RandomB.Name = "RandomB";
            this.RandomB.Size = new System.Drawing.Size(117, 24);
            this.RandomB.TabIndex = 2;
            this.RandomB.Text = "Before/After";
            this.RandomB.UseVisualStyleBackColor = true;
            this.RandomB.Click += new System.EventHandler(this.RandomB_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(949, 212);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(35, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "0.299";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(990, 212);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(35, 20);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "0.287";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(1031, 212);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(35, 20);
            this.textBox3.TabIndex = 7;
            this.textBox3.Text = "0.114";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(944, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "      R          G           B";
            // 
            // negativeB
            // 
            this.negativeB.Location = new System.Drawing.Point(948, 370);
            this.negativeB.Name = "negativeB";
            this.negativeB.Size = new System.Drawing.Size(116, 25);
            this.negativeB.TabIndex = 9;
            this.negativeB.Text = "Negative";
            this.negativeB.UseVisualStyleBackColor = true;
            this.negativeB.Click += new System.EventHandler(this.negativeB_Click);
            // 
            // saveB
            // 
            this.saveB.Location = new System.Drawing.Point(949, 565);
            this.saveB.Name = "saveB";
            this.saveB.Size = new System.Drawing.Size(117, 23);
            this.saveB.TabIndex = 10;
            this.saveB.Text = "Save";
            this.saveB.UseVisualStyleBackColor = true;
            this.saveB.Click += new System.EventHandler(this.saveB_Click);
            // 
            // sobelB
            // 
            this.sobelB.Location = new System.Drawing.Point(948, 441);
            this.sobelB.Name = "sobelB";
            this.sobelB.Size = new System.Drawing.Size(117, 23);
            this.sobelB.TabIndex = 11;
            this.sobelB.Text = "Sobel Edge";
            this.sobelB.UseVisualStyleBackColor = true;
            this.sobelB.Click += new System.EventHandler(this.sopelB_Click);
            // 
            // refillColorsConvert
            // 
            this.refillColorsConvert.Location = new System.Drawing.Point(947, 467);
            this.refillColorsConvert.Name = "refillColorsConvert";
            this.refillColorsConvert.Size = new System.Drawing.Size(117, 23);
            this.refillColorsConvert.TabIndex = 12;
            this.refillColorsConvert.Text = "ReFillColors";
            this.refillColorsConvert.UseVisualStyleBackColor = true;
            this.refillColorsConvert.Click += new System.EventHandler(this.refillColorsConvert_Click);
            // 
            // redB
            // 
            this.redB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.redB.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.redB.FlatAppearance.BorderSize = 0;
            this.redB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.redB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redB.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.redB.Location = new System.Drawing.Point(947, 158);
            this.redB.Name = "redB";
            this.redB.Size = new System.Drawing.Size(119, 35);
            this.redB.TabIndex = 13;
            this.redB.Text = "ShowColor";
            this.redB.UseVisualStyleBackColor = false;
            this.redB.Click += new System.EventHandler(this.redB_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(914, 664);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(12, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(914, 664);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1117, 705);
            this.Controls.Add(this.redB);
            this.Controls.Add(this.refillColorsConvert);
            this.Controls.Add(this.sobelB);
            this.Controls.Add(this.saveB);
            this.Controls.Add(this.negativeB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.RandomB);
            this.Controls.Add(this.grayB);
            this.Controls.Add(this.OpenB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenB;
        private System.Windows.Forms.Button grayB;
        private System.Windows.Forms.Button RandomB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button negativeB;
        private System.Windows.Forms.Button saveB;
        private System.Windows.Forms.Button sobelB;
        private System.Windows.Forms.Button refillColorsConvert;
        private System.Windows.Forms.Button redB;
    }
}


