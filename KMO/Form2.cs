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
    public partial class Hakinda : Form
    {
        public Hakinda()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnaMenu form2 = new AnaMenu();
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        Point lastPoint;
        private void Hakinda_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Hakinda_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        bool tema = Properties.Settings.Default.tema;
        private void Hakinda_Load(object sender, EventArgs e)
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
