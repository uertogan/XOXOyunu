namespace XOXOyunu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblOyuncu1 = new Label();
            lblOyuncu2 = new Label();
            btnS1K1 = new Button();
            btnS1K3 = new Button();
            btnS1K2 = new Button();
            btnS2K2 = new Button();
            btnS2K3 = new Button();
            btnS2K1 = new Button();
            btnS3K2 = new Button();
            btnS3K3 = new Button();
            btnS3K1 = new Button();
            groupBox1 = new GroupBox();
            btnXOSec = new Button();
            lblOyuncuSirasi = new Label();
            lblKazanan = new Label();
            btnYenidenBaslat = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblOyuncu1
            // 
            lblOyuncu1.BorderStyle = BorderStyle.FixedSingle;
            lblOyuncu1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblOyuncu1.Location = new Point(356, 57);
            lblOyuncu1.Name = "lblOyuncu1";
            lblOyuncu1.Size = new Size(141, 35);
            lblOyuncu1.TabIndex = 0;
            lblOyuncu1.Text = "1. Oyuncu: ";
            // 
            // lblOyuncu2
            // 
            lblOyuncu2.BorderStyle = BorderStyle.FixedSingle;
            lblOyuncu2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblOyuncu2.Location = new Point(356, 104);
            lblOyuncu2.Name = "lblOyuncu2";
            lblOyuncu2.Size = new Size(141, 35);
            lblOyuncu2.TabIndex = 1;
            lblOyuncu2.Text = "2. Oyuncu: ";
            // 
            // btnS1K1
            // 
            btnS1K1.Location = new Point(32, 68);
            btnS1K1.Name = "btnS1K1";
            btnS1K1.Size = new Size(55, 48);
            btnS1K1.TabIndex = 2;
            btnS1K1.UseVisualStyleBackColor = true;
            btnS1K1.Click += XOTiklama_Click;
            // 
            // btnS1K3
            // 
            btnS1K3.Location = new Point(200, 68);
            btnS1K3.Name = "btnS1K3";
            btnS1K3.Size = new Size(55, 48);
            btnS1K3.TabIndex = 3;
            btnS1K3.UseVisualStyleBackColor = true;
            btnS1K3.Click += XOTiklama_Click;
            // 
            // btnS1K2
            // 
            btnS1K2.Location = new Point(116, 68);
            btnS1K2.Name = "btnS1K2";
            btnS1K2.Size = new Size(55, 48);
            btnS1K2.TabIndex = 4;
            btnS1K2.UseVisualStyleBackColor = true;
            btnS1K2.Click += XOTiklama_Click;
            // 
            // btnS2K2
            // 
            btnS2K2.Location = new Point(116, 137);
            btnS2K2.Name = "btnS2K2";
            btnS2K2.Size = new Size(55, 48);
            btnS2K2.TabIndex = 7;
            btnS2K2.UseVisualStyleBackColor = true;
            btnS2K2.Click += XOTiklama_Click;
            // 
            // btnS2K3
            // 
            btnS2K3.Location = new Point(200, 137);
            btnS2K3.Name = "btnS2K3";
            btnS2K3.Size = new Size(55, 48);
            btnS2K3.TabIndex = 6;
            btnS2K3.UseVisualStyleBackColor = true;
            btnS2K3.Click += XOTiklama_Click;
            // 
            // btnS2K1
            // 
            btnS2K1.Location = new Point(32, 137);
            btnS2K1.Name = "btnS2K1";
            btnS2K1.Size = new Size(55, 48);
            btnS2K1.TabIndex = 5;
            btnS2K1.UseVisualStyleBackColor = true;
            btnS2K1.Click += XOTiklama_Click;
            // 
            // btnS3K2
            // 
            btnS3K2.Location = new Point(116, 212);
            btnS3K2.Name = "btnS3K2";
            btnS3K2.Size = new Size(55, 48);
            btnS3K2.TabIndex = 10;
            btnS3K2.UseVisualStyleBackColor = true;
            btnS3K2.Click += XOTiklama_Click;
            // 
            // btnS3K3
            // 
            btnS3K3.Location = new Point(200, 212);
            btnS3K3.Name = "btnS3K3";
            btnS3K3.Size = new Size(55, 48);
            btnS3K3.TabIndex = 9;
            btnS3K3.UseVisualStyleBackColor = true;
            btnS3K3.Click += XOTiklama_Click;
            // 
            // btnS3K1
            // 
            btnS3K1.Location = new Point(32, 212);
            btnS3K1.Name = "btnS3K1";
            btnS3K1.Size = new Size(55, 48);
            btnS3K1.TabIndex = 8;
            btnS3K1.UseVisualStyleBackColor = true;
            btnS3K1.Click += XOTiklama_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnS3K2);
            groupBox1.Controls.Add(btnS3K3);
            groupBox1.Controls.Add(btnS3K1);
            groupBox1.Controls.Add(btnS2K2);
            groupBox1.Controls.Add(btnS2K3);
            groupBox1.Controls.Add(btnS2K1);
            groupBox1.Controls.Add(btnS1K2);
            groupBox1.Controls.Add(btnS1K3);
            groupBox1.Controls.Add(btnS1K1);
            groupBox1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            groupBox1.Location = new Point(31, 47);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(293, 287);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Oyun Alanı";
            // 
            // btnXOSec
            // 
            btnXOSec.BackColor = Color.DarkOrange;
            btnXOSec.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnXOSec.Location = new Point(519, 57);
            btnXOSec.Name = "btnXOSec";
            btnXOSec.Size = new Size(141, 82);
            btnXOSec.TabIndex = 12;
            btnXOSec.Text = "X-O SEÇ";
            btnXOSec.UseVisualStyleBackColor = false;
            btnXOSec.Click += btnXOSec_Click;
            // 
            // lblOyuncuSirasi
            // 
            lblOyuncuSirasi.BorderStyle = BorderStyle.FixedSingle;
            lblOyuncuSirasi.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblOyuncuSirasi.Location = new Point(42, 9);
            lblOyuncuSirasi.Name = "lblOyuncuSirasi";
            lblOyuncuSirasi.Size = new Size(282, 35);
            lblOyuncuSirasi.TabIndex = 13;
            lblOyuncuSirasi.Text = "Oyun Sırası :";
            lblOyuncuSirasi.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblKazanan
            // 
            lblKazanan.BorderStyle = BorderStyle.FixedSingle;
            lblKazanan.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblKazanan.Location = new Point(356, 239);
            lblKazanan.Name = "lblKazanan";
            lblKazanan.Size = new Size(282, 35);
            lblKazanan.TabIndex = 14;
            lblKazanan.Text = "Kazanan:";
            lblKazanan.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnYenidenBaslat
            // 
            btnYenidenBaslat.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnYenidenBaslat.Location = new Point(464, 313);
            btnYenidenBaslat.Name = "btnYenidenBaslat";
            btnYenidenBaslat.Size = new Size(195, 42);
            btnYenidenBaslat.TabIndex = 15;
            btnYenidenBaslat.Text = "Yeniden Başlat";
            btnYenidenBaslat.UseVisualStyleBackColor = true;
            btnYenidenBaslat.Click += btnYenidenBaslat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(695, 374);
            Controls.Add(btnYenidenBaslat);
            Controls.Add(lblKazanan);
            Controls.Add(lblOyuncuSirasi);
            Controls.Add(btnXOSec);
            Controls.Add(groupBox1);
            Controls.Add(lblOyuncu2);
            Controls.Add(lblOyuncu1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblOyuncu1;
        private Label lblOyuncu2;
        private Button btnS1K1;
        private Button btnS1K3;
        private Button btnS1K2;
        private Button btnS2K2;
        private Button btnS2K3;
        private Button btnS2K1;
        private Button btnS3K2;
        private Button btnS3K3;
        private Button btnS3K1;
        private GroupBox groupBox1;
        private Button btnXOSec;
        private Label lblOyuncuSirasi;
        private Label lblKazanan;
        private Button btnYenidenBaslat;
    }
}
