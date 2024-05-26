using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace KMO
{
    public partial class Oyun : Form
    {
        public Oyun()
        {
            InitializeComponent();
        }

        Point lastPoint;

        private void Oyun_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        private void Oyun_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void sorulabel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void sorulabel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }






        private static int sure = 30;
        private int ii = sure;
        private void timer1_Tick(object sender, EventArgs e)
        {
            ii--;
            if (ii == -1)
            {
                Yanlis_cevap();
                timer1.Stop();
                timer1.Enabled = false;
            }
            else
            {
                label2GeriSY.Text = ii.ToString();
            }

        }

        string sorutxt = Properties.Settings.Default.sorutxt;
        bool tema = Properties.Settings.Default.tema;
        private void Oyun_Load(object sender, EventArgs e)
        {
            if (false == tema)
            {
                BackColor = Color.Black;
            }
            else
            {
                BackColor = Color.White;
            }
            timer1.Interval = 1000;
            ii = sure;
            label2GeriSY.Text = sure.ToString();
            timer1.Enabled = true;
            timer1.Start();
            sorular();
        }
        Menu Form1 = new Menu();
        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = "DOGRU BİLDİN Kerata";
            DiyerSoru.Text = "DIYER SORU ";
            i = 1;
            timer1.Stop();
            timer1.Enabled = false;
            ii = sure;
            label2GeriSY.Text = sure.ToString();
            this.Hide();
            Form1.Show();
        }

        List<string> sorularlist = new List<string>();
        private static String cevap = "";


        public void sorular()
        {
            string metin = System.IO.File.ReadAllText(sorutxt);
            string bol = "££££";
            string[] s = metin.Split(new string[] { bol }, StringSplitOptions.None);
            foreach (var i in s)
            {
                sorularlist.Add(i);
            }
            soru();
        }

        private WaveOutEvent outputDevice;
        private AudioFileReader audioFile;
        private bool play = true;
        public void Play(string yol)
        {
            outputDevice = new WaveOutEvent();
            audioFile = new AudioFileReader(yol);
            outputDevice.Init(audioFile);
            outputDevice.Play();
        }
        public void PlayStop()
        {
            play = false;
            outputDevice.Stop();
        }



        public void Yanlısses()
        {
            string[] d = Directory.GetFileSystemEntries("OyunDosyaları/Yanlış/");
            int sayı = d.Length;

            Random random = new Random();
            int randomsayı = random.Next(0, sayı + 1);
            Play("OyunDosyaları/Yanlış/" + randomsayı.ToString() + ".mp3");
        }
        public void DogruSes()
        {
            string[] d = Directory.GetFileSystemEntries("OyunDosyaları/Doğru/");
            int sayı = d.Length;

            Random random = new Random();
            int randomsayı = random.Next(0, sayı);
            Play("OyunDosyaları/Doğru/" + randomsayı.ToString() + ".mp3");
        }



        public static int i = 1;
        public void soru()
        {
            List<string> sorulist = new List<string>();
            string bol = "£££";
            string[] s = sorularlist[i].Split(new string[] {bol}, StringSplitOptions.None);
            foreach (var ii in s)
            {
                sorulist.Add(ii);
            }
            sorulabel1.Text = sorulist[0];
            A.Text = sorulist[1];
            B.Text = sorulist[2];
            C.Text = sorulist[3];
            D.Text = sorulist[4];
            cevap = sorulist[5];
        }



        private int labelIndex = 1;
        public void asama()
        {
            if (labelIndex <= 13)
            {
                string labelName = "b" + labelIndex;
                Control[] matches = this.Controls.Find(labelName, true);

                if (matches.Length > 0 && matches[0] is Label)
                {
                    Label currentLabel = (Label)matches[0];
                    currentLabel.ForeColor = Color.Gold;
                }

                labelIndex++;
            }
        }



        private bool Kazandin = false;
        private bool elendin = false;
        private bool gec = false;
        private void DiyerSoru_Click(object sender, EventArgs e)
        {
            A.Enabled = true;
            B.Enabled = true;
            D.Enabled = true;
            C.Enabled = true;
            PlayStop();
            ii = sure;
            label2GeriSY.Text = sure.ToString();
            if (elendin == false && Kazandin == false)
            {
                timer1.Enabled = true;
                timer1.Start();
                gec = false;
                soru();
                Buttonlar.Visible = true;
                sorulabel1.Visible = true;
            }
            else if (Kazandin == true)
            {
                i = 1;
                timer1.Enabled = false;
                timer1.Stop();
                this.Hide();
                Form1.Show();
            }
            else
            {
                timer1.Stop();
                timer1.Enabled = false;
                i = 1;
                this.Hide();
                Menu Form1 = new Menu();
                Form1.Show();
            }
        }




        public void Dogru_cevap()
        {
            Buttonlar.Visible = false;
            sorulabel1.Visible = false;
            if (gec == false)
            {

                timer1.Stop();
                timer1.Enabled = false;
                label2GeriSY.Text = sure.ToString();
                ii = sure;
                Play("OyunDosyaları/DoğruCevapSesi/1.mp3");
                DogruSes();
                if (i != 13)
                {
                    label1.Text = "Soru Sayısı 13/" + i.ToString();
                    i++;
                    gec = true;
                }
                else
                {
                    Kazandin = true; ;
                    label3.Text = "Kazandın 5.000.000 TL bravo zeki çoçuk";
                    DiyerSoru.Text = "Menu ye Dön";
                }
                asama();
            }
        }
        public void Yanlis_cevap()
        {
            timer1.Stop();
            timer1.Enabled = false;
            elendin = true;
            sorulabel1.Visible = false;
            Buttonlar.Visible = false;
            PuanTablo.Visible = false;
            DiyerSoru.Text = "Menu";
            label3.Text = "Elendin ! \n Üzülme Birdahakinde yaparsın";

            if (gec == false)
            {
                Yanlısses();
                label2.Text = "Yanlış";
            }
        }



        private void A_Click(object sender, EventArgs e)
        {
            if (cevap.Contains("A"))
            {
                Dogru_cevap();
            }
            else
            {
                Yanlis_cevap();
            }
        }
        private void B_Click(object sender, EventArgs e)
        {
            if (cevap.Contains("B"))
            {
                Dogru_cevap();
            }
            else
            {
                Yanlis_cevap();
            }
        }

        private void C_Click(object sender, EventArgs e)
        {
            if (cevap.Contains("C"))
            {
                Dogru_cevap();
            }
            else
            {
                Yanlis_cevap();
            }
        }

        private void D_Click(object sender, EventArgs e)
        {
            if (cevap.Contains("D"))
            {
                Dogru_cevap();
            }
            else
            {
                Yanlis_cevap();
            }
        }

        private void AramaJoker_Click(object sender, EventArgs e)
        {
            Telefon joker = new Telefon();
            joker.Show();
            AramaJoker.Enabled = false;
        }

        private void eliye50joker_Click(object sender, EventArgs e)
        {
            string elenen = "";
            string bos = string.Join("", cevap.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries));
            List<string> secenekler = new List<string> { "A", "B", "C", "D" };
            secenekler.Remove(bos);
            Random random = new Random();
            for (int i = 0; i < secenekler.Count; i++)
            {
                int r = random.Next(i, secenekler.Count);
                string temp = secenekler[r];
                secenekler[r] = secenekler[i];
                secenekler[i] = temp;
            }

            string s1 = secenekler[0]; // First unique letter
            string s2 = secenekler[1]; // Second unique letter
            elenen = s1 + s2;

            A.Enabled = !elenen.Contains("A");
            B.Enabled = !elenen.Contains("B");
            C.Enabled = !elenen.Contains("C");
            D.Enabled = !elenen.Contains("D");
            eliye50joker.Enabled = false;
        }

        private async void seyircibutton_Click(object sender, EventArgs e)
        {
            seyirci.Visible = true;
            Random random = new Random();
            int sinir = 100;
            int ss = sinir;
            int a = random.Next(0, ss + 1);
            ss -= a;
            int b = random.Next(0, ss + 1);
            ss -= b;
            int c = random.Next(0, ss + 1);
            ss -= c;
            int d = ss;

            string A = "A şıkkı " + a + "%";
            string B = "B şıkkı " + b + "%";
            string C = "C şıkkı " + c + "%";
            string D = "D şıkkı " + d + "%";
            seyirci.Text = $"{A} \n{B} \n{C} \n{D}";
            seyircibutton.Enabled = false;
            await Task.Delay(4000);
            seyirci.Visible = false;
        }
    }
}
