using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KMO
{
    public partial class NasilOynanir : Form
    {
        bool tema = Properties.Settings.Default.tema;
        public NasilOynanir()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile(images[currentIndex]);
        }
        private string[] images = { "OyunDosyaları/resim/1.png", "OyunDosyaları/resim/2.png", "OyunDosyaları/resim/3.png" };
        private int currentIndex = 0;
        Point lastPoint;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AnaMenu anaMenu = new AnaMenu();
            anaMenu.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Geri_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                pictureBox1.Image = Image.FromFile(images[currentIndex]);
            }
        }

        private void ileri_Click(object sender, EventArgs e)
        {
            if (currentIndex < images.Length - 1)
            {
                currentIndex++;
                pictureBox1.Image = Image.FromFile(images[currentIndex]);
            }
        }

        private void NasilOynanir_Load(object sender, EventArgs e)
        {
            if (false == tema)
            {
                BackColor = Color.Black;
            }
            else
            {
                BackColor = Color.White;
            }
        }
    }
}
