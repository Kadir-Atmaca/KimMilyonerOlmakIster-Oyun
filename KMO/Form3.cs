using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KMO
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        bool tema = Properties.Settings.Default.tema;
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnaMenu Form1 = new AnaMenu();
            Form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        Point lastPoint;
        private void Menu_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Menu_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void basla(object sender, EventArgs e)
        {
            dosyaal();
            if (File.Exists(Properties.Settings.Default.sorutxt))
            {
                if (Properties.Settings.Default.sorutxt != "")
                {
                    this.Hide();
                    Oyun form = new Oyun();
                    form.Show();
                }
                else
                {
                    MessageBox.Show("Hata lütfen bir Test seçin");
                }
            }
            else
            {

                MessageBox.Show("Lütfen sorular klösörüne birdaha bakın");
            }
        }
        int dosyasayısı = 0;
        private void dosyaal()
        {
            dosyasayısı = 0;
            sorusayısı.Text = "0";
            combobox1.Items.Clear();
            string[] h = Directory.GetFiles("sorular/");
            foreach (string i in h)
            {
                dosyasayısı++;
                sorusayısı.Text = dosyasayısı.ToString();
                combobox1.Items.Add(i);
            }
        }
        private void Menu_Load(object sender, EventArgs e)
        {
            if (false == tema)
            {
                BackColor = Color.Black;
            }
            else
            {
                BackColor = Color.White;
            }
            dosyaal();
        }
        string yol = Properties.Settings.Default.sorutxt;

        private void combobox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = combobox1.SelectedItem.ToString();
            Properties.Settings.Default.sorutxt = selectedValue;
            Properties.Settings.Default.Save();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            dosyaal();
        }
    }
}
