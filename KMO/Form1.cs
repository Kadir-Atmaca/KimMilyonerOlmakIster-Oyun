using NAudio.Wave;
using System;
using System.Drawing;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;


namespace KMO
{
    public partial class AnaMenu : Form
    {

        public AnaMenu()
        {
            InitializeComponent();
        }
        bool tema = Properties.Settings.Default.tema;
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
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }


        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menu_Click(object sender, EventArgs e)
        {
            stop();
             this.Hide();
             Menu form3 = new Menu();
             form3.Show();
        }

        private void Hakinda_Click(object sender, EventArgs e)
        {
            stop();
            this.Hide();
            Hakinda hakinda = new Hakinda();
            hakinda.Show();
        }

        private void nasiloynanır_Click(object sender, EventArgs e)
        {
            stop();
            this.Hide();
            NasilOynanir anaMenu = new NasilOynanir();
            anaMenu.Show();
        }

        WaveOutEvent outputDevice;
        AudioFileReader audioFile;
        private bool play = false;
        public void Play(string yol)
        {
            outputDevice = new WaveOutEvent();
            audioFile = new AudioFileReader(yol);
            outputDevice.Init(audioFile);
            outputDevice.PlaybackStopped += (sender, e) =>
            {
                if (play == false)
                {
                    Play("OyunDosyaları/Arka/1.mp3");
                }

            };
            outputDevice.Play();
        }
        public void stop()
        {
            play = true;
            outputDevice.Stop();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            if (false == tema)
            {
                pictureBox2Hial.Visible = false;
                pictureBox3dolu.Visible = true;
                BackColor = Color.Black;
            }
            else
            {
                pictureBox3dolu.Visible = false;
                pictureBox2Hial.Visible = true;
                BackColor = Color.White;
            }
            Play("OyunDosyaları/Arka/1.mp3");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void renk_Click_1(object sender, EventArgs e)
        {
            if (BackColor == Color.White)
            {
                pictureBox2Hial.Visible = false;
                pictureBox3dolu.Visible = true;
                BackColor = Color.Black;
                Properties.Settings.Default.tema = false;
            }
            else
            {
                pictureBox3dolu.Visible = false;
                pictureBox2Hial.Visible = true;
                BackColor = Color.White;
                Properties.Settings.Default.tema = true;
            }
            Properties.Settings.Default.Save();

        }
    }
}
