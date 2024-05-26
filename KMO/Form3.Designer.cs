using System.Drawing;
using System.Windows.Forms;

namespace KMO
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.button2Gizle = new System.Windows.Forms.Button();
            this.button1Kapat = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.combobox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sorusayısı = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2Gizle
            // 
            this.button2Gizle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2Gizle.BackColor = System.Drawing.Color.Red;
            this.button2Gizle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2Gizle.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2Gizle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2Gizle.Location = new System.Drawing.Point(722, 0);
            this.button2Gizle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2Gizle.Name = "button2Gizle";
            this.button2Gizle.Size = new System.Drawing.Size(79, 28);
            this.button2Gizle.TabIndex = 9;
            this.button2Gizle.Text = "---";
            this.button2Gizle.UseVisualStyleBackColor = false;
            this.button2Gizle.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1Kapat
            // 
            this.button1Kapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1Kapat.BackColor = System.Drawing.Color.Red;
            this.button1Kapat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1Kapat.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1Kapat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1Kapat.Location = new System.Drawing.Point(801, 0);
            this.button1Kapat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1Kapat.Name = "button1Kapat";
            this.button1Kapat.Size = new System.Drawing.Size(79, 28);
            this.button1Kapat.TabIndex = 8;
            this.button1Kapat.Text = "X";
            this.button1Kapat.UseVisualStyleBackColor = false;
            this.button1Kapat.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(-2, 322);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(882, 48);
            this.button1.TabIndex = 10;
            this.button1.Text = "Basla";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.basla);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Soru Sayısı : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cyan;
            this.label2.Location = new System.Drawing.Point(182, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(426, 29);
            this.label2.TabIndex = 12;
            this.label2.Text = "en fazla 1 teste 13 soru vardır. ";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(0, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(877, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Başla buttonuna bastıktan sonra direk başlar her soruyu yanıtlama süreniz  30 san" +
    "iyedir ";
            // 
            // combobox1
            // 
            this.combobox1.BackColor = System.Drawing.Color.Transparent;
            this.combobox1.BorderColor = System.Drawing.Color.Black;
            this.combobox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combobox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox1.FillColor = System.Drawing.Color.Cyan;
            this.combobox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combobox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combobox1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.combobox1.ForeColor = System.Drawing.Color.Red;
            this.combobox1.ItemHeight = 40;
            this.combobox1.Location = new System.Drawing.Point(12, 144);
            this.combobox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combobox1.Name = "combobox1";
            this.combobox1.Size = new System.Drawing.Size(387, 46);
            this.combobox1.TabIndex = 15;
            this.combobox1.SelectedIndexChanged += new System.EventHandler(this.combobox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 15.8F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Cyan;
            this.label4.Location = new System.Drawing.Point(12, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(266, 33);
            this.label4.TabIndex = 16;
            this.label4.Text = "Bulunan Testler";
            // 
            // sorusayısı
            // 
            this.sorusayısı.AutoSize = true;
            this.sorusayısı.Font = new System.Drawing.Font("Showcard Gothic", 15.8F, System.Drawing.FontStyle.Bold);
            this.sorusayısı.ForeColor = System.Drawing.Color.Yellow;
            this.sorusayısı.Location = new System.Drawing.Point(284, 222);
            this.sorusayısı.Name = "sorusayısı";
            this.sorusayısı.Size = new System.Drawing.Size(32, 33);
            this.sorusayısı.TabIndex = 17;
            this.sorusayısı.Text = "0";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(438, 145);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 45);
            this.button2.TabIndex = 18;
            this.button2.Text = "Yenile";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(0, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(877, 35);
            this.label5.TabIndex = 19;
            this.label5.Text = "Dizinde bulunan uygulamada soruların bulunduğu bir dosya mevcuttur. Bu dosyanın i" +
    "çeriğinden soruları seçerek oyunu oynayabilirsiniz. Keyifli vakit geçirmenizi di" +
    "lerim.";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(880, 408);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.sorusayısı);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.combobox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2Gizle);
            this.Controls.Add(this.button1Kapat);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Menu_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Menu_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button2Gizle;
        private Button button1Kapat;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox combobox1;
        private Label label4;
        private Label sorusayısı;
        private Button button2;
        private Label label5;
    }
}