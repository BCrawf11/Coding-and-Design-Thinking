using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace KobeYeet
{
    public partial class Form1 : Form
    {
        int seed = 0;

        public Form1()
        {
            InitializeComponent();
            Button_Kobe_Yeet.MouseEnter += (o, e) => ChangeColor(Color.Cyan);
            Button_Kobe_Yeet.MouseLeave += ChangeColor;
        }

        public void ChangeColor(Color c)
        {
            Button_Kobe_Yeet.BackColor = c;
        }

        public void ChangeColor(object o, EventArgs e)
        {
            Button_Kobe_Yeet.BackColor = Color.Green;
        }

        private void Button_Kobe_Yeet_Click(object sender, EventArgs e)
        {

            if (CheckBox_FailSafe.Checked && KobeDate.Value < DateTime.Now)
            {
                Environment.Exit(0);
            }
            else
            {
                Bitmap b = new Bitmap(Picture_Box.Width, Picture_Box.Height);
                //Random rand = new Random();

                switch (seed)
                {
                    case 0:

                        for (int x = 0; x < Picture_Box.Width; x += 1)
                        {
                            for (int y = 0; y < Picture_Box.Height; y += 1)
                            {
                                b.SetPixel(x, y, ((x - y) % 10) == 0 ? Color.Green : ((x + y) % 10) == 0 ? Color.Green : Color.Cyan);
                            }
                        }

                        Picture_Box.Image = b;
                        seed = 1;
                        break;

                    case 1:

                        for (int x = 0; x < Picture_Box.Width; x += 1)
                        {
                            for (int y = 0; y < Picture_Box.Height; y += 1)
                            {
                                b.SetPixel(x, y, ((x - y) % 12) == 0 ? Color.Green : ((x + y) % 12) == 0 ? Color.Green : Color.Cyan);
                            }
                        }

                        Picture_Box.Image = b;
                        seed = 2;
                        break;

                    case 2:

                        for (int x = 0; x < Picture_Box.Width; x += 1)
                        {
                            for (int y = 0; y < Picture_Box.Height; y += 1)
                            {
                                b.SetPixel(x, y, ((x - y) % 14) == 0 ? Color.Green : ((x + y) % 14) == 0 ? Color.Green : Color.Cyan);
                            }
                        }

                        Picture_Box.Image = b;
                        seed = 3;
                        break;

                    case 3:

                        for (int x = 0; x < Picture_Box.Width; x += 1)
                        {
                            for (int y = 0; y < Picture_Box.Height; y += 1)
                            {
                                b.SetPixel(x, y, ((x - y) % 16) == 0 ? Color.Green : ((x + y) % 16) == 0 ? Color.Green : Color.Cyan);
                            }
                        }

                        Picture_Box.Image = b;
                        seed = 4;
                        break;

                    case 4:

                        for (int x = 0; x < Picture_Box.Width; x += 1)
                        {
                            for (int y = 0; y < Picture_Box.Height; y += 1)
                            {
                                b.SetPixel(x, y, ((x - y) % 18) == 0 ? Color.Green : ((x + y) % 18) == 0 ? Color.Green : Color.Cyan);
                            }
                        }

                        Picture_Box.Image = b;
                        seed = 5;
                        break;

                    case 5:

                        for (int x = 0; x < Picture_Box.Width; x += 1)
                        {
                            for (int y = 0; y < Picture_Box.Height; y += 1)
                            {
                                b.SetPixel(x, y, ((x - y) % 20) == 0 ? Color.Green : ((x + y) % 20) == 0 ? Color.Green : Color.Cyan);
                            }
                        }

                        Picture_Box.Image = b;
                        seed = 6;
                        break;

                    case 6:

                        for (int x = 0; x < Picture_Box.Width; x += 1)
                        {
                            for (int y = 0; y < Picture_Box.Height; y += 1)
                            {
                                b.SetPixel(x, y, ((x - y) % 22) == 0 ? Color.Green : ((x + y) % 22) == 0 ? Color.Green : Color.Cyan);
                            }
                        }

                        Picture_Box.Image = b;
                        seed = 7;
                        break;

                    case 7:

                        for (int x = 0; x < Picture_Box.Width; x += 1)
                        {
                            for (int y = 0; y < Picture_Box.Height; y += 1)
                            {
                                b.SetPixel(x, y, ((x - y) % 24) == 0 ? Color.Green : ((x + y) % 24) == 0 ? Color.Green : Color.Cyan);
                            }
                        }

                        Picture_Box.Image = b;
                        seed = 8;
                        break;

                    case 8:

                        for (int x = 0; x < Picture_Box.Width; x += 1)
                        {
                            for (int y = 0; y < Picture_Box.Height; y += 1)
                            {
                                b.SetPixel(x, y, ((x - y) % 26) == 0 ? Color.Green : ((x + y) % 26) == 0 ? Color.Green : Color.Cyan);
                            }
                        }

                        Picture_Box.Image = b;
                        seed = 0;
                        break;

                }
            }
        }

        private void CheckBox_FailSafe_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (Its_Free_Text.Text == "Quit Program")
            {
                Thread.Sleep(2000);
                Environment.Exit(0);
            }
        }
    }
}
