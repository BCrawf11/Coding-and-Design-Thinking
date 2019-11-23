using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageRenderingASCII
{
    public partial class Form1 : Form
    {
        public static string path = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            path = textBox1.Text;
        }
        private void Show_Reg_Image_Click(object sender, EventArgs e)
        {
            if (path == "")
            {
                textBox1.Text = "Please enter a file path first.";
            }
            else
            {
                //@"C:\Users\brodi\OneDrive\Desktop\PrisonMikeHeadBMP.bmp";

                Bitmap b = new Bitmap(@"" + path);

                ModifySize(b);
                Picture_Box.Image = b;
            }
        }

        private void Show_Inv_Image_Click(object sender, EventArgs e)
        {
            if (path == "")
            {
                textBox1.Text = "Please enter a file path first.";
            }
            else
            {
                Bitmap b = new Bitmap(@"" + path);

                Color c;

                for (int i = 0; i < Picture_Box.Width; i++)
                {
                    for (int j = 0; j < Picture_Box.Height; j++)
                    {
                        c = b.GetPixel(i, j);
                        b.SetPixel(i, j, findInverseColor(c));
                    }
                }

                ModifySize(b);
                Picture_Box.Image = b;
            }
        }

        private void ModifySize(Bitmap b)
        {
            Size s = new Size(b.Size.Width, b.Size.Height);
            Picture_Box.Size = s;
        }

        private Color findInverseColor(Color c)
        {
            int r = c.R;
            int g = c.G;
            int b = c.B;

            c = Color.FromArgb(255 - r, 255 - g, 255 - b);
            return c;
        }
    }
}
