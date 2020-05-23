using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetflixGUI
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();

            //loads all of the movie images
            pictureBox1.Image = new Bitmap(Image.FromFile(@"C:\Users\brodi\OneDrive\School\Coding\Images\Endgame.jpg"), new Size(142, 161));
            pictureBox2.Image = new Bitmap(Image.FromFile(@"C:\Users\brodi\OneDrive\School\Coding\Images\Mission Impossible.jpg"), new Size(142, 161));
            pictureBox3.Image = new Bitmap(Image.FromFile(@"C:\Users\brodi\OneDrive\School\Coding\Images\Bourne Identity.jpg"), new Size(142, 161));
            pictureBox4.Image = new Bitmap(Image.FromFile(@"C:\Users\brodi\OneDrive\School\Coding\Images\Jumanji TNL.jpg"), new Size(142, 161));
            pictureBox5.Image = new Bitmap(Image.FromFile(@"C:\Users\brodi\OneDrive\School\Coding\Images\Murder Mystery.jpg"), new Size(142, 161));
            pictureBox6.Image = new Bitmap(Image.FromFile(@"C:\Users\brodi\OneDrive\School\Coding\Images\Fletch.jpg"), new Size(142, 161));
            pictureBox7.Image = new Bitmap(Image.FromFile(@"C:\Users\brodi\OneDrive\School\Coding\Images\Here Comes the Boom.jpg"), new Size(142, 161));
            pictureBox8.Image = new Bitmap(Image.FromFile(@"C:\Users\brodi\OneDrive\School\Coding\Images\Napoleon Dynamite.jpg"), new Size(142, 161));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.ShowDialog();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.ShowDialog();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.ShowDialog();
        }
    }
}
