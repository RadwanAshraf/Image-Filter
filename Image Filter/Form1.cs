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

namespace Image_Filter
{
    public partial class Form1 : Form
    {
        bool f = true;
        public Form1()
        {
            InitializeComponent();

        }
        public Bitmap grayConvert(Bitmap b)
        {
            for (int i = 0; i < b.Width; i++)
                for (int j = 0; j < b.Height; j++)
                {

                    Color c1 = b.GetPixel(i, j);

                    int r1 = c1.R;
                    int g1 = c1.G;
                    int b1 = c1.B;

                    int gray = (byte)(
                        System.Convert.ToDouble(textBox1.Text) * r1 +
                        System.Convert.ToDouble(textBox2.Text) * g1 +
                        System.Convert.ToDouble(textBox3.Text) * b1);

                    r1 = gray;
                    g1 = gray;
                    b1 = gray;


                    b.SetPixel(i, j, Color.FromArgb(r1, g1, b1));

                }
            return b;
        }
        public Bitmap negativeConvert(Bitmap b)
        {
            for (int i = 0; i < b.Width; i++)
                for (int j = 0; j < b.Height; j++)
                {

                    Color c1 = b.GetPixel(i, j);


                    int a = c1.A;
                    int r1 = c1.R;
                    int g1 = c1.G;
                    int b1 = c1.B;

                    r1 = 255 - r1;
                    g1 = 255 - g1;
                    b1 = 255 - b1;


                    b.SetPixel(i, j, Color.FromArgb(a, r1, g1, b1));

                }
            return b;
        }

        public Bitmap edgeConvert(Bitmap b)
        {

            int x = 0, y = 0;
            int valxR = 0, valyR = 0, valxG = 0, valyG = 0, gradiant1, gradiant2, gradiant3;
            Bitmap temp = new Bitmap(b.Width, b.Height);
            Color c = Color.FromArgb(0, 0, 0);

            for (int i = 0; i < b.Height; i++)
                for (int j = 0; j < b.Width; j++)
                {

                    //for x axis
                    int[,] gx = new int[3, 3];
                    int[,] gy = new int[3, 3];

                    gx[0, 0] = -1; gx[0, 1] = 0; gx[0, 2] = 1;
                    gx[1, 0] = -2; gx[1, 1] = 0; gx[1, 2] = 2;
                    gx[2, 0] = -1; gx[2, 1] = 0; gx[2, 2] = 1;

                    //////y
                    gy[0, 0] = -1; gy[0, 1] = -2; gy[0, 2] = -1;
                    gy[1, 0] = 0; gy[1, 1] = 0; gy[1, 2] = 0;
                    gy[2, 0] = 1; gy[2, 1] = 2; gy[2, 2] = 1;



                    if ((i == 0) || i == (b.Height - 1) || (j == 0) || j == (b.Width - 1))
                    {
                        c = Color.FromArgb(255, 255, 255);
                        temp.SetPixel(j, i, c);
                        valxR = valyR = valxG = valyG = 0;

                    }
                    else
                    {
                        /*  valxG =(b.GetPixel(j - 1, i - 1).G * gx[0, 0])
                              + (b.GetPixel(j+ 1, i- 1).G * gx[0, 2])
                              + (b.GetPixel(j - 1, i).G * gx[1, 0])
                              + (b.GetPixel(j+1, i).G * gx[1, 2])
                              + (b.GetPixel(j - 1, i + 1).G * gx[2, 0])
                              + (b.GetPixel(j + 1, i + 1).G * gx[2, 2]);



                          valyG =(b.GetPixel(j - 1, i - 1).G * gy[0, 0])
                              + (b.GetPixel(j, i-1).G *  gy[0, 1])
                              + (b.GetPixel(j+ 1, i- 1).G * gy[0, 2])
                              + (b.GetPixel(j - 1, i + 1).G * gy[2, 0])
                              + (b.GetPixel(j, i+1).G *  gy[2, 1])
                              + (b.GetPixel(j + 1, i + 1).G * gy[2, 2]);

                          */
                        valxR = (b.GetPixel(j - 1, i - 1).R * gx[0, 0])
                            + (b.GetPixel(j + 1, i - 1).R * gx[0, 2])
                            + (b.GetPixel(j - 1, i).R * gx[1, 0])
                            + (b.GetPixel(j + 1, i).R * gx[1, 2])
                            + (b.GetPixel(j - 1, i + 1).R * gx[2, 0])
                            + (b.GetPixel(j + 1, i + 1).R * gx[2, 2]);



                        valyR = (b.GetPixel(j - 1, i - 1).R * gy[0, 0])
                            + (b.GetPixel(j, i - 1).R * gy[0, 1])
                            + (b.GetPixel(j + 1, i - 1).R * gy[0, 2])
                            + (b.GetPixel(j - 1, i + 1).R * gy[2, 0])
                            + (b.GetPixel(j, i + 1).R * gy[2, 1])
                            + (b.GetPixel(j + 1, i + 1).R * gy[2, 2]);



                        gradiant1 = (int)Math.Sqrt((valxR * valxR) + (valyR * valyR));
                        //     gradiant1 = (int)Math.Sqrt(gradiant1);
                        gradiant2 = gradiant1;
                        if (valxR != 0)
                            gradiant2 = (int)Math.Abs(Math.Atan(valyR / valxR) * 180);
                        //                        gradiant1 = (int)Math.Abs(Math.Max(valxG,valxR)) + Math.Abs(Math.Max(valyG, valyR));
                        // gradiant2 = (int)Math.Abs(Math.Min(valxG, valxR)) + Math.Abs(Math.Min(valyG, valyR));


                        // gradiant3 = (int)Math.Abs(Math.Max(valxG, valyG)) + Math.Abs(Math.Max(valyR, valxR));

                        //  gradiant=(int)Math.Sqrt((valx*valx)+(valy*valy));

                        if (gradiant1 < 0)
                        {
                            gradiant1 = 0;
                            //  gradiant2 = 0;

                        }

                        if (gradiant1 > 255)
                        {
                            gradiant1 = 255;
                            // gradiant2 = 255;
                            /*
                            Color c1 = b.GetPixel(j, i);

                            int r1 =  c1.R;
                            int g1 =  c1.G;
                            int b1 =  c1.B;

                            */
                            c = Color.FromArgb(gradiant1, gradiant1, gradiant1);
                            if (gradiant2 <= 30)
                                c = Color.FromArgb(250, 80, 20);
                            else if (gradiant2 <= 60)
                                c = Color.FromArgb(250, 0, 0);
                            if (gradiant2 <= 60)
                                c = Color.FromArgb(250, 0, 0);
                            else if (gradiant2 <= 120)
                                c = Color.FromArgb(0, 250, 0);
                            else if (gradiant2 <= 180)
                                c = Color.FromArgb(0, 0, 250);
                            else if (gradiant2 <= 270)
                                c = Color.FromArgb(250, 250, 0);
                            else if (gradiant2 <= 270)
                                c = Color.FromArgb(0, 250, 250);
                            else if (gradiant2 <= 360)
                                c = Color.FromArgb(250, 0, 250);


                            temp.SetPixel(j, i, c);

                            continue;
                        }
                        // gradiant1 = 0;
                        c = Color.FromArgb(gradiant1, gradiant1, gradiant1);

                        //  c = Color.FromArgb(gradiant2, gradiant2, gradiant2);

                        temp.SetPixel(j, i, c);

                    }


                }
            return temp;
        }

        public Bitmap reColorConvert(Bitmap b)
        {
            for (int i = 0; i < b.Width; i++)
                for (int j = 0; j < b.Height; j++)
                {

                    Color c1 = b.GetPixel(i, j);
                    if (c1.R > 200)

                    {
                        int r1 = System.Convert.ToInt16(textBox1.Text);
                        int g1 = System.Convert.ToInt16(textBox2.Text);
                        int b1 = System.Convert.ToInt16(textBox3.Text);

                        b.SetPixel(i, j, Color.FromArgb(r1, g1, b1));
                    }
                }
            return b;
        }



        private void OpenB_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofile = new OpenFileDialog();
            ofile.Filter = "Image File (*.bmp,*.jpg)|*.bmp;*.jpg";
            if (DialogResult.OK == ofile.ShowDialog())
            {
                this.pictureBox1.Image = new Bitmap(ofile.FileName);
            }

            pictureBox1.BringToFront();
            pictureBox1.Visible = true;
        }


        private void grayB_Click(object sender, EventArgs e)
        {

            Bitmap copy = new Bitmap(this.pictureBox1.Image);
            this.pictureBox2.Image = grayConvert(copy);

            pictureBox2.BringToFront();
            pictureBox2.Visible = true;

        }

        private void RandomB_Click(object sender, EventArgs e)
        {
            if (f)
            {
                pictureBox1.BringToFront();
                pictureBox1.Visible = true;
                f = false;
            }
            else
            {
                pictureBox2.BringToFront();
                pictureBox2.Visible = true;
                f = true;
            }
        }

        private void negativeB_Click(object sender, EventArgs e)
        {
            Bitmap copy = new Bitmap(this.pictureBox1.Image);
            this.pictureBox2.Image = negativeConvert(copy);

            pictureBox2.BringToFront();
            pictureBox2.Visible = true;
        }

        private void saveB_Click(object sender, EventArgs e)
        {
            SaveFileDialog safd = new SaveFileDialog();
            safd.Filter = "Image File (*.bmp,*.jpg)|*.bmp;*.jpg";
            if (safd.ShowDialog() == DialogResult.OK)
            {
                this.pictureBox2.Image.Save(safd.FileName, ImageFormat.Jpeg);
            }
        }

        private void sopelB_Click(object sender, EventArgs e)
        {

            Bitmap copy = new Bitmap(this.pictureBox1.Image);
            this.pictureBox2.Image = edgeConvert(copy);

            pictureBox2.BringToFront();
            pictureBox2.Visible = true;

        }

        private void refillColorsConvert_Click(object sender, EventArgs e)
        {
            Bitmap copy = new Bitmap(this.pictureBox1.Image);
            this.pictureBox2.Image = reColorConvert(copy);

            pictureBox2.BringToFront();
            pictureBox2.Visible = true;
        }

        private void redB_Click(object sender, EventArgs e)
        {
            int r1 = System.Convert.ToInt16(textBox1.Text);
            int g1 = System.Convert.ToInt16(textBox2.Text);
            int b1 = System.Convert.ToInt16(textBox3.Text);
            this.redB.BackColor = Color.FromArgb(r1, g1, b1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}

