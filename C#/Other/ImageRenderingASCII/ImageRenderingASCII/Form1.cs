﻿using System;
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
        static Bitmap b;
        public Form1()
        {
            InitializeComponent();
        }

        private void ModifyPBoxSize(Bitmap b)
        {
            Size s = new Size(b.Width, b.Height);
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            path = textBox1.Text;
        }
        private void Show_Reg_Image_Click(object sender, EventArgs e)
        {
            //error checking
            if (path == "")
            {
                textBox1.Text = "Please enter a file path first.";
            }
            else
            {
                b = new Bitmap(@"" + path);
                ModifyPBoxSize(b);
                Picture_Box.Image = b;
            }

            //sets the ASCII text box back to its original bounds and hides it behind the picture box
            ASCII.SetBounds(174, 55, b.Width, b.Height);
            ASCII.SendToBack();
        }

        private void Show_Full_Inv_Image_Click(object sender, EventArgs e)
        {
            //error checking
            if (path == "")
            {
                textBox1.Text = "Please enter a file path first.";
            }
            else
            {
                b = new Bitmap(@"" + path);
                ModifyPBoxSize(b);

                Color c;

                for (int i = 0; i < Picture_Box.Width; i++)
                {
                    for (int j = 0; j < Picture_Box.Height; j++)
                    {
                        c = b.GetPixel(i, j);
                        b.SetPixel(i, j, findInverseColor(c));
                    }
                }

                Picture_Box.Image = b;
            }

            //sets the ASCII text box back to its original bounds and hides it behind the picture box
            ASCII.SetBounds(174, 55, b.Width, b.Height);
            ASCII.SendToBack();
        }

        private void Show_Half_Inv_Image_Click(object sender, EventArgs e)
        {
            //error checking
            if (path == "")
            {
                textBox1.Text = "Please enter a file path first.";
            }
            else
            {
                b = new Bitmap(@"" + path);
                ModifyPBoxSize(b);

                Color c;

                for (int i = 0; i < Picture_Box.Width; i++)
                {
                    for (int j = 0; j < Picture_Box.Height; j++)
                    {
                        if ((i % 2 == 1 && j % 2 == 0) || (i % 2 == 0 && j % 2 == 1))
                        {
                            c = b.GetPixel(i, j);
                            b.SetPixel(i, j, findInverseColor(c));
                        }
                    }
                }

                Picture_Box.Image = b;
            }

            //sets the ASCII text box back to its original bounds and hides it behind the picture box
            ASCII.SetBounds(174, 55, b.Width , b.Height);
            ASCII.SendToBack();
        }

        private void Show_ASCII_Image_Click(object sender, EventArgs e)
        {
            //error checking
            if (path == "")
            {
                textBox1.Text = "Please enter a file path first.";
            }
            else
            {
                ASCII.Clear();
                Color c1, c2, c3;
                b = new Bitmap(@"" + path);

                string text = "";
                string s = "$@B%8&WM#*oahkbdpqwmZO0QLCJUYXzcvunxrjft/\\|()1{}[]?-_+~<>i!lI;:,\"^`'. ";
                int brightness;
                int MAX_HEIGHT = b.Height - 3;

                ASCII.Font = new Font("Courier New", 1f, FontStyle.Regular);
                ASCII.SetBounds(174, 55, b.Width + 7, b.Height);
                ASCII_Progress.Minimum = 0;
                ASCII_Progress.Maximum = MAX_HEIGHT;

                for (int i = 0; i < MAX_HEIGHT; i += 3)
                {
                    for (int j = 0; j < b.Width; j++)
                    {
                        c1 = b.GetPixel(j, i);
                        c2 = b.GetPixel(j, i + 1);
                        c3 = b.GetPixel(j, i + 2);

                        //averages the brightness per 3 pixels vertically due to sizing issues
                        brightness = ((int)Math.Round(c1.GetBrightness() * 69) + (int)Math.Round(c2.GetBrightness() * 69) +
                            (int)Math.Round(c3.GetBrightness() * 69)) / 3;

                        //adds it to a text string
                        text += s[brightness];
                    }

                    ASCII_Progress.Value = i;

                    //adds a new line, appends it to the text box and then clears it (loads more efficient)
                    text += "\n";
                    ASCII.AppendText(text);
                    text = "";
                }

                //adds the final text to the text box and hides the picture box from view
                Picture_Box.Image = null;
                Picture_Box.SendToBack();
            }
        }

        private void Show_Inv_ASCII_Image_Click(object sender, EventArgs e)
        {
            //error checking
            if (path == "")
            {
                textBox1.Text = "Please enter a file path first.";
            }
            else
            {
                ASCII.Clear();
                Color c1, c2, c3;
                b = new Bitmap(@"" + path);

                string text = "";
                string s = "$@B%8&WM#*oahkbdpqwmZO0QLCJUYXzcvunxrjft/||()1{}[]?-_+~<>i!lI;:,\"^`'. ";
                string brightChars = "";
                int brightness;
                int MAX_HEIGHT = b.Height - 3;

                for (int i = s.Length - 1; i >= 0; i--)
                {
                    brightChars += s[i];
                }

                ASCII.Font = new Font("Courier New", 1f, FontStyle.Regular);
                ASCII.SetBounds(174, 55, b.Width + 7, b.Height);
                Inv_ASCII_Progress.Minimum = 0;
                Inv_ASCII_Progress.Maximum = MAX_HEIGHT;

                for (int i = 0; i < MAX_HEIGHT; i += 3)
                {
                    for (int j = 0; j < b.Width; j++)
                    {
                        c1 = b.GetPixel(j, i);
                        c2 = b.GetPixel(j, i + 1);
                        c3 = b.GetPixel(j, i + 2);

                        //averages the brightness per 3 pixels vertically due to sizing issues
                        brightness = ((int)Math.Round(c1.GetBrightness() * 69) + (int)Math.Round(c2.GetBrightness() * 69) +
                            (int)Math.Round(c3.GetBrightness() * 69)) / 3;

                        //adds it to a text string
                        text += brightChars[brightness];
                    }

                    Inv_ASCII_Progress.Value = i;

                    //adds a new line, appends it to the text box and then clears it (loads more efficient)
                    text += "\n";
                    ASCII.AppendText(text);
                    text = "";
                }

                //adds the final text to the text box and hides the picture box from view
                Picture_Box.Image = null;
                Picture_Box.SendToBack();
            }
        }

        ///<summary>
        ///next projects:
        ///-Inverse ASCII (light is dark, dark is light)
        ///-Half Inverse ASCII (checkerboard inverse, not sure if visible)

        ///<summary>
        ///file paths:
        ///@"C:\Users\brodi\OneDrive\Desktop\PrisonMikeHeadBMP.bmp";
        ///@"C:\Users\brodi\OneDrive\Desktop\FamilyPhotoHawaii.bmp";
        ///@"C:\Users\brodi\OneDrive\Desktop\DecalDwight.bmp";
        ///@"C:\Users\brodi\OneDrive\Desktop\GraysenBMP.bmp";
        ///@"C:\Users\brodi\OneDrive\Desktop\FireBMP.bmp";
    }
}