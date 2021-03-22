namespace aracYazilimApp
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblHome = new System.Windows.Forms.Label();
            this.anaPanel = new System.Windows.Forms.Panel();
            this.btnMinimum = new System.Windows.Forms.Button();
            this.btnMinMax = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pictureHome = new System.Windows.Forms.PictureBox();
            this.pictureho = new System.Windows.Forms.PictureBox();
            this.btnAnaSayfa = new System.Windows.Forms.Button();
            this.PictureAyarlar = new System.Windows.Forms.PictureBox();
            this.Pictureİletişim = new System.Windows.Forms.PictureBox();
            this.pictureSatışlar = new System.Windows.Forms.PictureBox();
            this.pictureMüsteri = new System.Windows.Forms.PictureBox();
            this.pictureUrun = new System.Windows.Forms.PictureBox();
            this.btnAyarlar = new System.Windows.Forms.Button();
            this.btnİletişim = new System.Windows.Forms.Button();
            this.btnSatışlar = new System.Windows.Forms.Button();
            this.btnMüsteri = new System.Windows.Forms.Button();
            this.btnÜrün = new System.Windows.Forms.Button();
            this.pictureİstatistik = new System.Windows.Forms.PictureBox();
            this.btnİstatistik = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureAyarlar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pictureİletişim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSatışlar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMüsteri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUrun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureİstatistik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.panel1.Controls.Add(this.pictureho);
            this.panel1.Controls.Add(this.btnAnaSayfa);
            this.panel1.Controls.Add(this.PictureAyarlar);
            this.panel1.Controls.Add(this.Pictureİletişim);
            this.panel1.Controls.Add(this.pictureSatışlar);
            this.panel1.Controls.Add(this.pictureMüsteri);
            this.panel1.Controls.Add(this.pictureUrun);
            this.panel1.Controls.Add(this.btnAyarlar);
            this.panel1.Controls.Add(this.btnİletişim);
            this.panel1.Controls.Add(this.btnSatışlar);
            this.panel1.Controls.Add(this.btnMüsteri);
            this.panel1.Controls.Add(this.btnÜrün);
            this.panel1.Controls.Add(this.pictureİstatistik);
            this.panel1.Controls.Add(this.btnİstatistik);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 720);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 145);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(25, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chip Tuning";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(61)))));
            this.panel3.Controls.Add(this.btnMinimum);
            this.panel3.Controls.Add(this.btnMinMax);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.lblHome);
            this.panel3.Controls.Add(this.pictureHome);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(200, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1100, 100);
            this.panel3.TabIndex = 2;
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHome.Location = new System.Drawing.Point(97, 39);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(476, 30);
            this.lblHome.TabIndex = 2;
            this.lblHome.Text = "CHİP TUNİNG ARAÇ YAZILIM SİSTEMLERİ ";
            // 
            // anaPanel
            // 
            this.anaPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.anaPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.anaPanel.Location = new System.Drawing.Point(200, 100);
            this.anaPanel.Name = "anaPanel";
            this.anaPanel.Size = new System.Drawing.Size(1100, 620);
            this.anaPanel.TabIndex = 3;
            // 
            // btnMinimum
            // 
            this.btnMinimum.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimum.BackgroundImage")));
            this.btnMinimum.FlatAppearance.BorderSize = 0;
            this.btnMinimum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimum.Location = new System.Drawing.Point(983, 12);
            this.btnMinimum.Name = "btnMinimum";
            this.btnMinimum.Size = new System.Drawing.Size(31, 25);
            this.btnMinimum.TabIndex = 5;
            this.btnMinimum.UseVisualStyleBackColor = true;
            this.btnMinimum.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnMinMax
            // 
            this.btnMinMax.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinMax.BackgroundImage")));
            this.btnMinMax.FlatAppearance.BorderSize = 0;
            this.btnMinMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinMax.Location = new System.Drawing.Point(1020, 12);
            this.btnMinMax.Name = "btnMinMax";
            this.btnMinMax.Size = new System.Drawing.Size(31, 25);
            this.btnMinMax.TabIndex = 4;
            this.btnMinMax.UseVisualStyleBackColor = true;
            this.btnMinMax.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(1057, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(31, 25);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureHome
            // 
            this.pictureHome.Image = ((System.Drawing.Image)(resources.GetObject("pictureHome.Image")));
            this.pictureHome.Location = new System.Drawing.Point(28, 23);
            this.pictureHome.Name = "pictureHome";
            this.pictureHome.Size = new System.Drawing.Size(63, 45);
            this.pictureHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureHome.TabIndex = 0;
            this.pictureHome.TabStop = false;
            // 
            // pictureho
            // 
            this.pictureho.Location = new System.Drawing.Point(3, 596);
            this.pictureho.Name = "pictureho";
            this.pictureho.Size = new System.Drawing.Size(12, 70);
            this.pictureho.TabIndex = 19;
            this.pictureho.TabStop = false;
            // 
            // btnAnaSayfa
            // 
            this.btnAnaSayfa.FlatAppearance.BorderSize = 0;
            this.btnAnaSayfa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnaSayfa.Image = ((System.Drawing.Image)(resources.GetObject("btnAnaSayfa.Image")));
            this.btnAnaSayfa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnaSayfa.Location = new System.Drawing.Point(12, 596);
            this.btnAnaSayfa.Name = "btnAnaSayfa";
            this.btnAnaSayfa.Size = new System.Drawing.Size(185, 70);
            this.btnAnaSayfa.TabIndex = 18;
            this.btnAnaSayfa.Text = "Ana Sayfa";
            this.btnAnaSayfa.UseVisualStyleBackColor = true;
            this.btnAnaSayfa.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // PictureAyarlar
            // 
            this.PictureAyarlar.Location = new System.Drawing.Point(3, 531);
            this.PictureAyarlar.Name = "PictureAyarlar";
            this.PictureAyarlar.Size = new System.Drawing.Size(12, 70);
            this.PictureAyarlar.TabIndex = 17;
            this.PictureAyarlar.TabStop = false;
            // 
            // Pictureİletişim
            // 
            this.Pictureİletişim.Location = new System.Drawing.Point(3, 455);
            this.Pictureİletişim.Name = "Pictureİletişim";
            this.Pictureİletişim.Size = new System.Drawing.Size(12, 78);
            this.Pictureİletişim.TabIndex = 16;
            this.Pictureİletişim.TabStop = false;
            // 
            // pictureSatışlar
            // 
            this.pictureSatışlar.Location = new System.Drawing.Point(3, 379);
            this.pictureSatışlar.Name = "pictureSatışlar";
            this.pictureSatışlar.Size = new System.Drawing.Size(12, 78);
            this.pictureSatışlar.TabIndex = 15;
            this.pictureSatışlar.TabStop = false;
            // 
            // pictureMüsteri
            // 
            this.pictureMüsteri.Location = new System.Drawing.Point(3, 303);
            this.pictureMüsteri.Name = "pictureMüsteri";
            this.pictureMüsteri.Size = new System.Drawing.Size(12, 78);
            this.pictureMüsteri.TabIndex = 14;
            this.pictureMüsteri.TabStop = false;
            // 
            // pictureUrun
            // 
            this.pictureUrun.Location = new System.Drawing.Point(3, 227);
            this.pictureUrun.Name = "pictureUrun";
            this.pictureUrun.Size = new System.Drawing.Size(12, 79);
            this.pictureUrun.TabIndex = 13;
            this.pictureUrun.TabStop = false;
            // 
            // btnAyarlar
            // 
            this.btnAyarlar.FlatAppearance.BorderSize = 0;
            this.btnAyarlar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyarlar.Image = ((System.Drawing.Image)(resources.GetObject("btnAyarlar.Image")));
            this.btnAyarlar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAyarlar.Location = new System.Drawing.Point(12, 531);
            this.btnAyarlar.Name = "btnAyarlar";
            this.btnAyarlar.Size = new System.Drawing.Size(185, 70);
            this.btnAyarlar.TabIndex = 12;
            this.btnAyarlar.Text = "Blog";
            this.btnAyarlar.UseVisualStyleBackColor = true;
            this.btnAyarlar.Click += new System.EventHandler(this.btnAyarlar_Click);
            // 
            // btnİletişim
            // 
            this.btnİletişim.FlatAppearance.BorderSize = 0;
            this.btnİletişim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnİletişim.Image = ((System.Drawing.Image)(resources.GetObject("btnİletişim.Image")));
            this.btnİletişim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnİletişim.Location = new System.Drawing.Point(12, 455);
            this.btnİletişim.Name = "btnİletişim";
            this.btnİletişim.Size = new System.Drawing.Size(185, 70);
            this.btnİletişim.TabIndex = 11;
            this.btnİletişim.Text = "İletişim";
            this.btnİletişim.UseVisualStyleBackColor = true;
            this.btnİletişim.Click += new System.EventHandler(this.btnİletişim_Click);
            // 
            // btnSatışlar
            // 
            this.btnSatışlar.FlatAppearance.BorderSize = 0;
            this.btnSatışlar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSatışlar.Image = ((System.Drawing.Image)(resources.GetObject("btnSatışlar.Image")));
            this.btnSatışlar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSatışlar.Location = new System.Drawing.Point(12, 379);
            this.btnSatışlar.Name = "btnSatışlar";
            this.btnSatışlar.Size = new System.Drawing.Size(185, 70);
            this.btnSatışlar.TabIndex = 10;
            this.btnSatışlar.Text = "Satışlar";
            this.btnSatışlar.UseVisualStyleBackColor = true;
            this.btnSatışlar.Click += new System.EventHandler(this.btnSatışlar_Click);
            // 
            // btnMüsteri
            // 
            this.btnMüsteri.FlatAppearance.BorderSize = 0;
            this.btnMüsteri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMüsteri.Image = ((System.Drawing.Image)(resources.GetObject("btnMüsteri.Image")));
            this.btnMüsteri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMüsteri.Location = new System.Drawing.Point(12, 303);
            this.btnMüsteri.Name = "btnMüsteri";
            this.btnMüsteri.Size = new System.Drawing.Size(185, 70);
            this.btnMüsteri.TabIndex = 9;
            this.btnMüsteri.Text = " Müşteri Kayıt";
            this.btnMüsteri.UseVisualStyleBackColor = true;
            this.btnMüsteri.Click += new System.EventHandler(this.btnMüsteri_Click);
            // 
            // btnÜrün
            // 
            this.btnÜrün.CausesValidation = false;
            this.btnÜrün.FlatAppearance.BorderSize = 0;
            this.btnÜrün.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnÜrün.Image = ((System.Drawing.Image)(resources.GetObject("btnÜrün.Image")));
            this.btnÜrün.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnÜrün.Location = new System.Drawing.Point(12, 227);
            this.btnÜrün.Name = "btnÜrün";
            this.btnÜrün.Size = new System.Drawing.Size(185, 70);
            this.btnÜrün.TabIndex = 8;
            this.btnÜrün.Text = "Ürünler";
            this.btnÜrün.UseVisualStyleBackColor = true;
            this.btnÜrün.Click += new System.EventHandler(this.btnÜrün_Click);
            // 
            // pictureİstatistik
            // 
            this.pictureİstatistik.Location = new System.Drawing.Point(3, 151);
            this.pictureİstatistik.Name = "pictureİstatistik";
            this.pictureİstatistik.Size = new System.Drawing.Size(12, 77);
            this.pictureİstatistik.TabIndex = 7;
            this.pictureİstatistik.TabStop = false;
            // 
            // btnİstatistik
            // 
            this.btnİstatistik.FlatAppearance.BorderSize = 0;
            this.btnİstatistik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnİstatistik.Image = ((System.Drawing.Image)(resources.GetObject("btnİstatistik.Image")));
            this.btnİstatistik.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnİstatistik.Location = new System.Drawing.Point(12, 151);
            this.btnİstatistik.Name = "btnİstatistik";
            this.btnİstatistik.Size = new System.Drawing.Size(185, 70);
            this.btnİstatistik.TabIndex = 6;
            this.btnİstatistik.Text = " Veri İstatistiği";
            this.btnİstatistik.UseVisualStyleBackColor = true;
            this.btnİstatistik.Click += new System.EventHandler(this.btnİstatistik_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 720);
            this.Controls.Add(this.anaPanel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureAyarlar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pictureİletişim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSatışlar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMüsteri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUrun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureİstatistik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel anaPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.PictureBox pictureHome;
        private System.Windows.Forms.Button btnMinimum;
        private System.Windows.Forms.Button btnMinMax;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.PictureBox pictureİstatistik;
        private System.Windows.Forms.Button btnİstatistik;
        private System.Windows.Forms.PictureBox PictureAyarlar;
        private System.Windows.Forms.PictureBox Pictureİletişim;
        private System.Windows.Forms.PictureBox pictureSatışlar;
        private System.Windows.Forms.PictureBox pictureMüsteri;
        private System.Windows.Forms.PictureBox pictureUrun;
        private System.Windows.Forms.Button btnAyarlar;
        private System.Windows.Forms.Button btnİletişim;
        private System.Windows.Forms.Button btnSatışlar;
        private System.Windows.Forms.Button btnMüsteri;
        private System.Windows.Forms.Button btnÜrün;
        private System.Windows.Forms.PictureBox pictureho;
        private System.Windows.Forms.Button btnAnaSayfa;
    }
}

