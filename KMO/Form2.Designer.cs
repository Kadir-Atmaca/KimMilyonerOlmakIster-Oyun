using System.Drawing;
using System.Windows.Forms;

namespace KMO
{
    partial class Hakinda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hakinda));
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(549, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 31);
            this.button2.TabIndex = 7;
            this.button2.Text = "---";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(649, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 31);
            this.button1.TabIndex = 8;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 52);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Hakinda_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Hakinda_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 23);
            this.label1.TabIndex = 20;
            this.label1.Text = "\"En Önemli özelik ÖZGÜR YAZILIM olması\"";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Hakinda_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Hakinda_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(12, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 26);
            this.label2.TabIndex = 21;
            this.label2.Text = "Kategori :   ";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Hakinda_MouseDown);
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Hakinda_MouseMove);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(12, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 26);
            this.label3.TabIndex = 22;
            this.label3.Text = "Yapımcı Tasarımcı :";
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Hakinda_MouseDown);
            this.label3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Hakinda_MouseMove);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(12, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(273, 26);
            this.label4.TabIndex = 23;
            this.label4.Text = "Fikir ve Test Sorular :";
            this.label4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Hakinda_MouseDown);
            this.label4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Hakinda_MouseMove);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(12, 368);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 26);
            this.label5.TabIndex = 24;
            this.label5.Text = "Sürüm :";
            this.label5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Hakinda_MouseDown);
            this.label5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Hakinda_MouseMove);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Cyan;
            this.label6.Location = new System.Drawing.Point(25, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(356, 26);
            this.label6.TabIndex = 25;
            this.label6.Text = "Çoçuk ,eglence , zeka gelisimi";
            this.label6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Hakinda_MouseDown);
            this.label6.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Hakinda_MouseMove);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Cyan;
            this.label7.Location = new System.Drawing.Point(24, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 26);
            this.label7.TabIndex = 26;
            this.label7.Text = "Kadir Atmaca";
            this.label7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Hakinda_MouseDown);
            this.label7.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Hakinda_MouseMove);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Cyan;
            this.label8.Location = new System.Drawing.Point(25, 345);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(178, 26);
            this.label8.TabIndex = 27;
            this.label8.Text = "RÜMEYSA FIRAT";
            this.label8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Hakinda_MouseDown);
            this.label8.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Hakinda_MouseMove);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Cyan;
            this.label9.Location = new System.Drawing.Point(24, 394);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 26);
            this.label9.TabIndex = 28;
            this.label9.Text = " V1.0 BEta";
            this.label9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Hakinda_MouseDown);
            this.label9.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Hakinda_MouseMove);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(171, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(329, 26);
            this.label10.TabIndex = 29;
            this.label10.Text = "Kim Milyoner Olmak Ister !";
            this.label10.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Hakinda_MouseDown);
            this.label10.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Hakinda_MouseMove);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(12, 420);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(289, 26);
            this.label11.TabIndex = 30;
            this.label11.Text = "Soru Depolama Formatı";
            this.label11.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Hakinda_MouseDown);
            this.label11.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Hakinda_MouseMove);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Cyan;
            this.label12.Location = new System.Drawing.Point(25, 448);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(294, 26);
            this.label12.TabIndex = 31;
            this.label12.Text = "(txt) Depolama Formatı";
            this.label12.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Hakinda_MouseDown);
            this.label12.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Hakinda_MouseMove);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(12, 474);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(223, 26);
            this.label13.TabIndex = 32;
            this.label13.Text = "programlama dili";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Cyan;
            this.label14.Location = new System.Drawing.Point(24, 500);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(226, 26);
            this.label14.TabIndex = 33;
            this.label14.Text = "c# net framework";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(14, 32);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(402, 18);
            this.label15.TabIndex = 34;
            this.label15.Text = "\"Kodumu al, istediğin gibi değiştir, geliştir veya sil.\"";
            // 
            // Hakinda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(743, 553);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Hakinda";
            this.Text = "Hakkında";
            this.Load += new System.EventHandler(this.Hakinda_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Hakinda_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Hakinda_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button2;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
    }
}