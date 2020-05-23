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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();

            pictureBox1.Image = new Bitmap(Image.FromFile(@"C:\Users\brodi\OneDrive\School\Coding\Images\Jumanji TNL.jpg"), new Size(142, 161));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
