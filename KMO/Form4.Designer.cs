using System.Drawing;
using System.Windows.Forms;

namespace KMO
{
    partial class Oyun
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Oyun));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.C = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.B = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.A = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.D = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.sorulabel1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2GeriSY = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PuanTablo = new Guna.UI2.WinForms.Guna2Panel();
            this.b2 = new System.Windows.Forms.Label();
            this.b3 = new System.Windows.Forms.Label();
            this.b4 = new System.Windows.Forms.Label();
            this.b5 = new System.Windows.Forms.Label();
            this.b10 = new System.Windows.Forms.Label();
            this.b9 = new System.Windows.Forms.Label();
            this.b7 = new System.Windows.Forms.Label();
            this.b6 = new System.Windows.Forms.Label();
            this.b13 = new System.Windows.Forms.Label();
            this.b12 = new System.Windows.Forms.Label();
            this.b11 = new System.Windows.Forms.Label();
            this.b8 = new System.Windows.Forms.Label();
            this.b1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DiyerSoru = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.label3 = new System.Windows.Forms.Label();
            this.Buttonlar = new Guna.UI2.WinForms.Guna2Panel();
            this.seyircibutton = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.eliye50joker = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.AramaJoker = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.seyirci = new System.Windows.Forms.Label();
            this.PuanTablo.SuspendLayout();
            this.Buttonlar.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Showcard Gothic", 7.2F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(1124, 1);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Stencil", 10F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(1030, 1);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "---";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // C
            // 
            this.C.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.C.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.C.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.C.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.C.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.C.FillColor = System.Drawing.Color.Red;
            this.C.FillColor2 = System.Drawing.Color.Yellow;
            this.C.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.C.ForeColor = System.Drawing.Color.Black;
            this.C.Location = new System.Drawing.Point(15, 114);
            this.C.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(404, 42);
            this.C.TabIndex = 8;
            this.C.Text = "C";
            this.C.Click += new System.EventHandler(this.C_Click);
            // 
            // B
            // 
            this.B.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.B.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.B.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.B.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.B.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.B.FillColor = System.Drawing.Color.Red;
            this.B.FillColor2 = System.Drawing.Color.Yellow;
            this.B.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.B.ForeColor = System.Drawing.Color.Black;
            this.B.Location = new System.Drawing.Point(485, 55);
            this.B.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(404, 42);
            this.B.TabIndex = 9;
            this.B.Text = "B";
            this.B.Click += new System.EventHandler(this.B_Click);
            // 
            // A
            // 
            this.A.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.A.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.A.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.A.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.A.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.A.FillColor = System.Drawing.Color.Red;
            this.A.FillColor2 = System.Drawing.Color.Yellow;
            this.A.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.A.ForeColor = System.Drawing.Color.Black;
            this.A.Location = new System.Drawing.Point(15, 55);
            this.A.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(404, 42);
            this.A.TabIndex = 10;
            this.A.Text = "A";
            this.A.Click += new System.EventHandler(this.A_Click);
            // 
            // D
            // 
            this.D.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.D.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.D.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.D.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.D.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.D.FillColor = System.Drawing.Color.Red;
            this.D.FillColor2 = System.Drawing.Color.Yellow;
            this.D.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.D.ForeColor = System.Drawing.Color.Black;
            this.D.Location = new System.Drawing.Point(485, 114);
            this.D.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(404, 42);
            this.D.TabIndex = 11;
            this.D.Text = "D";
            this.D.Click += new System.EventHandler(this.D_Click);
            // 
            // sorulabel1
            // 
            this.sorulabel1.BackColor = System.Drawing.Color.Transparent;
            this.sorulabel1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sorulabel1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sorulabel1.ForeColor = System.Drawing.Color.Red;
            this.sorulabel1.Location = new System.Drawing.Point(12, 29);
            this.sorulabel1.Name = "sorulabel1";
            this.sorulabel1.Size = new System.Drawing.Size(915, 305);
            this.sorulabel1.TabIndex = 12;
            this.sorulabel1.Text = "Soru";
            this.sorulabel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.sorulabel1_MouseDown);
            this.sorulabel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.sorulabel1_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(83, 448);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Soru Sayısı : 13/0";
            // 
            // label2GeriSY
            // 
            this.label2GeriSY.AutoSize = true;
            this.label2GeriSY.BackColor = System.Drawing.Color.Transparent;
            this.label2GeriSY.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label2GeriSY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2GeriSY.Location = new System.Drawing.Point(808, 14);
            this.label2GeriSY.Name = "label2GeriSY";
            this.label2GeriSY.Size = new System.Drawing.Size(49, 37);
            this.label2GeriSY.TabIndex = 33;
            this.label2GeriSY.Text = "10";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PuanTablo
            // 
            this.PuanTablo.BackColor = System.Drawing.Color.Transparent;
            this.PuanTablo.Controls.Add(this.b2);
            this.PuanTablo.Controls.Add(this.b3);
            this.PuanTablo.Controls.Add(this.b4);
            this.PuanTablo.Controls.Add(this.b5);
            this.PuanTablo.Controls.Add(this.b10);
            this.PuanTablo.Controls.Add(this.b9);
            this.PuanTablo.Controls.Add(this.b7);
            this.PuanTablo.Controls.Add(this.b6);
            this.PuanTablo.Controls.Add(this.b13);
            this.PuanTablo.Controls.Add(this.b12);
            this.PuanTablo.Controls.Add(this.b11);
            this.PuanTablo.Controls.Add(this.b8);
            this.PuanTablo.Controls.Add(this.b1);
            this.PuanTablo.Controls.Add(this.label1);
            this.PuanTablo.Location = new System.Drawing.Point(933, 29);
            this.PuanTablo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PuanTablo.Name = "PuanTablo";
            this.PuanTablo.Size = new System.Drawing.Size(285, 480);
            this.PuanTablo.TabIndex = 34;
            this.PuanTablo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Oyun_MouseDown);
            this.PuanTablo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Oyun_MouseMove);
            // 
            // b2
            // 
            this.b2.AutoSize = true;
            this.b2.BackColor = System.Drawing.Color.Transparent;
            this.b2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b2.ForeColor = System.Drawing.Color.Red;
            this.b2.Location = new System.Drawing.Point(83, 338);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(130, 31);
            this.b2.TabIndex = 27;
            this.b2.Text = "2) 5.000 TL";
            // 
            // b3
            // 
            this.b3.AutoSize = true;
            this.b3.BackColor = System.Drawing.Color.Transparent;
            this.b3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b3.ForeColor = System.Drawing.Color.Red;
            this.b3.Location = new System.Drawing.Point(83, 310);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(130, 31);
            this.b3.TabIndex = 26;
            this.b3.Text = "3) 7.500 TL";
            // 
            // b4
            // 
            this.b4.AutoSize = true;
            this.b4.BackColor = System.Drawing.Color.Transparent;
            this.b4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b4.ForeColor = System.Drawing.Color.Red;
            this.b4.Location = new System.Drawing.Point(77, 280);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(143, 31);
            this.b4.TabIndex = 25;
            this.b4.Text = "4) 10.000 TL";
            // 
            // b5
            // 
            this.b5.AutoSize = true;
            this.b5.BackColor = System.Drawing.Color.Transparent;
            this.b5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b5.ForeColor = System.Drawing.Color.Cyan;
            this.b5.Location = new System.Drawing.Point(77, 250);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(143, 31);
            this.b5.TabIndex = 24;
            this.b5.Text = "5) 20.000 TL";
            // 
            // b10
            // 
            this.b10.AutoSize = true;
            this.b10.BackColor = System.Drawing.Color.Transparent;
            this.b10.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b10.ForeColor = System.Drawing.Color.Red;
            this.b10.Location = new System.Drawing.Point(64, 112);
            this.b10.Name = "b10";
            this.b10.Size = new System.Drawing.Size(169, 31);
            this.b10.TabIndex = 23;
            this.b10.Text = "10) 300.000 TL";
            // 
            // b9
            // 
            this.b9.AutoSize = true;
            this.b9.BackColor = System.Drawing.Color.Transparent;
            this.b9.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b9.ForeColor = System.Drawing.Color.Red;
            this.b9.Location = new System.Drawing.Point(70, 139);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(156, 31);
            this.b9.TabIndex = 22;
            this.b9.Text = "9) 200.000 TL";
            // 
            // b7
            // 
            this.b7.AutoSize = true;
            this.b7.BackColor = System.Drawing.Color.Transparent;
            this.b7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b7.ForeColor = System.Drawing.Color.Red;
            this.b7.Location = new System.Drawing.Point(77, 198);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(143, 31);
            this.b7.TabIndex = 21;
            this.b7.Text = "7) 50.000 TL";
            // 
            // b6
            // 
            this.b6.AutoSize = true;
            this.b6.BackColor = System.Drawing.Color.Transparent;
            this.b6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b6.ForeColor = System.Drawing.Color.Red;
            this.b6.Location = new System.Drawing.Point(77, 224);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(143, 31);
            this.b6.TabIndex = 20;
            this.b6.Text = "6) 30.000 TL";
            // 
            // b13
            // 
            this.b13.AutoSize = true;
            this.b13.BackColor = System.Drawing.Color.Transparent;
            this.b13.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b13.ForeColor = System.Drawing.Color.Blue;
            this.b13.Location = new System.Drawing.Point(54, 22);
            this.b13.Name = "b13";
            this.b13.Size = new System.Drawing.Size(188, 31);
            this.b13.TabIndex = 19;
            this.b13.Text = "13) 5.000.000 TL";
            // 
            // b12
            // 
            this.b12.AutoSize = true;
            this.b12.BackColor = System.Drawing.Color.Transparent;
            this.b12.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b12.ForeColor = System.Drawing.Color.Red;
            this.b12.Location = new System.Drawing.Point(54, 53);
            this.b12.Name = "b12";
            this.b12.Size = new System.Drawing.Size(188, 31);
            this.b12.TabIndex = 18;
            this.b12.Text = "12) 1.000.000 TL";
            // 
            // b11
            // 
            this.b11.AutoSize = true;
            this.b11.BackColor = System.Drawing.Color.Transparent;
            this.b11.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b11.ForeColor = System.Drawing.Color.Red;
            this.b11.Location = new System.Drawing.Point(64, 83);
            this.b11.Name = "b11";
            this.b11.Size = new System.Drawing.Size(169, 31);
            this.b11.TabIndex = 17;
            this.b11.Text = "11) 500.000 TL";
            // 
            // b8
            // 
            this.b8.AutoSize = true;
            this.b8.BackColor = System.Drawing.Color.Transparent;
            this.b8.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b8.ForeColor = System.Drawing.Color.Red;
            this.b8.Location = new System.Drawing.Point(70, 169);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(156, 31);
            this.b8.TabIndex = 16;
            this.b8.Text = "8) 100.000 TL";
            // 
            // b1
            // 
            this.b1.AutoSize = true;
            this.b1.BackColor = System.Drawing.Color.Transparent;
            this.b1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b1.ForeColor = System.Drawing.Color.Red;
            this.b1.Location = new System.Drawing.Point(80, 364);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(136, 31);
            this.b1.TabIndex = 15;
            this.b1.Text = "1)  2.000 TL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(732, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 37);
            this.label2.TabIndex = 35;
            this.label2.Text = "Süre :";
            // 
            // DiyerSoru
            // 
            this.DiyerSoru.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DiyerSoru.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DiyerSoru.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DiyerSoru.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DiyerSoru.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DiyerSoru.FillColor = System.Drawing.Color.Cyan;
            this.DiyerSoru.FillColor2 = System.Drawing.Color.Lime;
            this.DiyerSoru.Font = new System.Drawing.Font("Showcard Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiyerSoru.ForeColor = System.Drawing.Color.Black;
            this.DiyerSoru.Location = new System.Drawing.Point(12, 467);
            this.DiyerSoru.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DiyerSoru.Name = "DiyerSoru";
            this.DiyerSoru.PressedColor = System.Drawing.Color.Gold;
            this.DiyerSoru.Size = new System.Drawing.Size(467, 42);
            this.DiyerSoru.TabIndex = 36;
            this.DiyerSoru.Text = "dIYER sORU ";
            this.DiyerSoru.Click += new System.EventHandler(this.DiyerSoru_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(11, 409);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(467, 56);
            this.label3.TabIndex = 37;
            this.label3.Text = "DOGRU BİLDİN Kerata";
            // 
            // Buttonlar
            // 
            this.Buttonlar.Controls.Add(this.seyircibutton);
            this.Buttonlar.Controls.Add(this.eliye50joker);
            this.Buttonlar.Controls.Add(this.AramaJoker);
            this.Buttonlar.Controls.Add(this.A);
            this.Buttonlar.Controls.Add(this.B);
            this.Buttonlar.Controls.Add(this.label2GeriSY);
            this.Buttonlar.Controls.Add(this.label2);
            this.Buttonlar.Controls.Add(this.D);
            this.Buttonlar.Controls.Add(this.C);
            this.Buttonlar.Location = new System.Drawing.Point(12, 339);
            this.Buttonlar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Buttonlar.Name = "Buttonlar";
            this.Buttonlar.Size = new System.Drawing.Size(915, 170);
            this.Buttonlar.TabIndex = 38;
            // 
            // seyircibutton
            // 
            this.seyircibutton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.seyircibutton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.seyircibutton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.seyircibutton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.seyircibutton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.seyircibutton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.seyircibutton.FillColor2 = System.Drawing.Color.Blue;
            this.seyircibutton.Font = new System.Drawing.Font("Snap ITC", 17.8F, System.Drawing.FontStyle.Bold);
            this.seyircibutton.ForeColor = System.Drawing.Color.Black;
            this.seyircibutton.Location = new System.Drawing.Point(334, 9);
            this.seyircibutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.seyircibutton.Name = "seyircibutton";
            this.seyircibutton.Size = new System.Drawing.Size(202, 42);
            this.seyircibutton.TabIndex = 41;
            this.seyircibutton.Text = "seyirci";
            this.seyircibutton.Click += new System.EventHandler(this.seyircibutton_Click);
            // 
            // eliye50joker
            // 
            this.eliye50joker.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.eliye50joker.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.eliye50joker.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.eliye50joker.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.eliye50joker.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.eliye50joker.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.eliye50joker.FillColor2 = System.Drawing.Color.Blue;
            this.eliye50joker.Font = new System.Drawing.Font("Snap ITC", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliye50joker.ForeColor = System.Drawing.Color.Black;
            this.eliye50joker.Location = new System.Drawing.Point(116, 9);
            this.eliye50joker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.eliye50joker.Name = "eliye50joker";
            this.eliye50joker.Size = new System.Drawing.Size(212, 42);
            this.eliye50joker.TabIndex = 40;
            this.eliye50joker.Text = "50:50";
            this.eliye50joker.Click += new System.EventHandler(this.eliye50joker_Click);
            // 
            // AramaJoker
            // 
            this.AramaJoker.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AramaJoker.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AramaJoker.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AramaJoker.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AramaJoker.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AramaJoker.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AramaJoker.FillColor2 = System.Drawing.Color.Blue;
            this.AramaJoker.Font = new System.Drawing.Font("Wingdings", 19.8F, System.Drawing.FontStyle.Bold);
            this.AramaJoker.ForeColor = System.Drawing.Color.Black;
            this.AramaJoker.Location = new System.Drawing.Point(15, 9);
            this.AramaJoker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AramaJoker.Name = "AramaJoker";
            this.AramaJoker.Size = new System.Drawing.Size(95, 42);
            this.AramaJoker.TabIndex = 39;
            this.AramaJoker.Text = "(";
            this.AramaJoker.Click += new System.EventHandler(this.AramaJoker_Click);
            // 
            // seyirci
            // 
            this.seyirci.BackColor = System.Drawing.Color.Transparent;
            this.seyirci.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.seyirci.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.seyirci.ForeColor = System.Drawing.Color.Red;
            this.seyirci.Location = new System.Drawing.Point(654, 29);
            this.seyirci.Name = "seyirci";
            this.seyirci.Size = new System.Drawing.Size(273, 305);
            this.seyirci.TabIndex = 39;
            this.seyirci.Text = "Seyirci :";
            this.seyirci.Visible = false;
            this.seyirci.MouseDown += new System.Windows.Forms.MouseEventHandler(this.sorulabel1_MouseDown);
            this.seyirci.MouseMove += new System.Windows.Forms.MouseEventHandler(this.sorulabel1_MouseMove);
            // 
            // Oyun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1219, 518);
            this.Controls.Add(this.seyirci);
            this.Controls.Add(this.Buttonlar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PuanTablo);
            this.Controls.Add(this.DiyerSoru);
            this.Controls.Add(this.sorulabel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Oyun";
            this.Text = "Oyun";
            this.Load += new System.EventHandler(this.Oyun_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Oyun_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Oyun_MouseMove);
            this.PuanTablo.ResumeLayout(false);
            this.PuanTablo.PerformLayout();
            this.Buttonlar.ResumeLayout(false);
            this.Buttonlar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button button1;
        private Button button2;
        private Guna.UI2.WinForms.Guna2GradientTileButton C;
        private Guna.UI2.WinForms.Guna2GradientTileButton B;
        private Guna.UI2.WinForms.Guna2GradientTileButton A;
        private Guna.UI2.WinForms.Guna2GradientTileButton D;
        private Label sorulabel1;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2Panel PuanTablo;
        private Label label2;
        private Label label2GeriSY;
        private Label b2;
        private Label b3;
        private Label b4;
        private Label b5;
        private Label b10;
        private Label b9;
        private Label b7;
        private Label b6;
        private Label b13;
        private Label b12;
        private Label b11;
        private Label b8;
        private Label b1;
        private Guna.UI2.WinForms.Guna2GradientTileButton DiyerSoru;
        private Label label3;
        private Guna.UI2.WinForms.Guna2Panel Buttonlar;
        private Guna.UI2.WinForms.Guna2GradientTileButton AramaJoker;
        private Guna.UI2.WinForms.Guna2GradientTileButton eliye50joker;
        private Guna.UI2.WinForms.Guna2GradientTileButton seyircibutton;
        private Label seyirci;
    }
}