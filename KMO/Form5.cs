using NAudio.Wave;
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
    public partial class Telefon : Form
    {
        public Telefon()
        {
            InitializeComponent();
        }
        Point lastPoint;
        private void Form5_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        private void Form5_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }


        private WaveOutEvent outputDevice;
        private AudioFileReader audioFile;
        private bool play = false;
        private int i = 0;
        public void Play(string yol)
        {
            outputDevice = new WaveOutEvent();
            audioFile = new AudioFileReader(yol);
            outputDevice.Init(audioFile);
            outputDevice.PlaybackStopped += (sender, e) =>
            {
                if (play == false)
                {
                    play = true;
                    label1.Text = "Murat Demir";
                    Random random = new Random();
                    int randomsayı = random.Next(1, 8);
                    Play("OyunDosyaları/Arama/" + randomsayı.ToString() + ".mp3");
                }
                else
                {
                    this.Hide();
                }
            };
            outputDevice.Play();
        }
        bool tema = Properties.Settings.Default.tema;
        private void Telefon_Load(object sender, EventArgs e)
        {
            if (false == tema)
            {
                BackColor = Color.Black;
            }
            else
            {
                BackColor = Color.White;
            }
            Play("OyunDosyaları/Arama/arama.mp3");
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
    }
}
