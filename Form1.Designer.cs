namespace OOP_Okul
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ustMenu = new System.Windows.Forms.MenuStrip();
            this.msKatalog = new System.Windows.Forms.ToolStripMenuItem();
            this.msSatis = new System.Windows.Forms.ToolStripMenuItem();
            this.msUrunler = new System.Windows.Forms.ToolStripMenuItem();
            this.msUrunEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.msUrunListele = new System.Windows.Forms.ToolStripMenuItem();
            this.msPersonel = new System.Windows.Forms.ToolStripMenuItem();
            this.msPersonelEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.msPersonelListele = new System.Windows.Forms.ToolStripMenuItem();
            this.msMusteri = new System.Windows.Forms.ToolStripMenuItem();
            this.msMusteriEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.msMusteriListele = new System.Windows.Forms.ToolStripMenuItem();
            this.msTedarikci = new System.Windows.Forms.ToolStripMenuItem();
            this.msTedarikciEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.msTedarikciListele = new System.Windows.Forms.ToolStripMenuItem();
            this.msHesapDokumu = new System.Windows.Forms.ToolStripMenuItem();
            this.msCikis = new System.Windows.Forms.ToolStripMenuItem();
            this.pb1Market = new System.Windows.Forms.PictureBox();
            this.gbKullaniciGirisi = new System.Windows.Forms.GroupBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.msSatisYap = new System.Windows.Forms.ToolStripMenuItem();
            this.ustMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb1Market)).BeginInit();
            this.gbKullaniciGirisi.SuspendLayout();
            this.SuspendLayout();
            // 
            // ustMenu
            // 
            this.ustMenu.BackColor = System.Drawing.Color.Transparent;
            this.ustMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ustMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msKatalog,
            this.msSatis,
            this.msUrunler,
            this.msPersonel,
            this.msMusteri,
            this.msTedarikci,
            this.msHesapDokumu,
            this.msCikis});
            this.ustMenu.Location = new System.Drawing.Point(0, 0);
            this.ustMenu.Name = "ustMenu";
            this.ustMenu.Size = new System.Drawing.Size(549, 25);
            this.ustMenu.TabIndex = 2;
            this.ustMenu.Text = "menuStrip1";
            // 
            // msKatalog
            // 
            this.msKatalog.Name = "msKatalog";
            this.msKatalog.Size = new System.Drawing.Size(66, 21);
            this.msKatalog.Text = "Katalog";
            // 
            // msSatis
            // 
            this.msSatis.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msSatisYap});
            this.msSatis.Name = "msSatis";
            this.msSatis.Size = new System.Drawing.Size(48, 21);
            this.msSatis.Text = "Satış";
            // 
            // msUrunler
            // 
            this.msUrunler.BackColor = System.Drawing.Color.LemonChiffon;
            this.msUrunler.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msUrunEkle,
            this.msUrunListele});
            this.msUrunler.Name = "msUrunler";
            this.msUrunler.Size = new System.Drawing.Size(47, 21);
            this.msUrunler.Text = "Stok";
            // 
            // msUrunEkle
            // 
            this.msUrunEkle.Name = "msUrunEkle";
            this.msUrunEkle.Size = new System.Drawing.Size(152, 22);
            this.msUrunEkle.Text = "Ürün Ekle";
            this.msUrunEkle.Click += new System.EventHandler(this.msUrunEkle_Click);
            // 
            // msUrunListele
            // 
            this.msUrunListele.Name = "msUrunListele";
            this.msUrunListele.Size = new System.Drawing.Size(152, 22);
            this.msUrunListele.Text = "Ürün Listele";
            this.msUrunListele.Click += new System.EventHandler(this.msUrunListele_Click);
            // 
            // msPersonel
            // 
            this.msPersonel.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msPersonelEkle,
            this.msPersonelListele});
            this.msPersonel.Name = "msPersonel";
            this.msPersonel.Size = new System.Drawing.Size(72, 21);
            this.msPersonel.Text = "Personel";
            // 
            // msPersonelEkle
            // 
            this.msPersonelEkle.Name = "msPersonelEkle";
            this.msPersonelEkle.Size = new System.Drawing.Size(169, 22);
            this.msPersonelEkle.Text = "Personel Ekle";
            this.msPersonelEkle.Click += new System.EventHandler(this.msPersonelEkle_Click);
            // 
            // msPersonelListele
            // 
            this.msPersonelListele.Name = "msPersonelListele";
            this.msPersonelListele.Size = new System.Drawing.Size(169, 22);
            this.msPersonelListele.Text = "Personel Listele";
            this.msPersonelListele.Click += new System.EventHandler(this.msPersonelListele_Click);
            // 
            // msMusteri
            // 
            this.msMusteri.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msMusteriEkle,
            this.msMusteriListele});
            this.msMusteri.Name = "msMusteri";
            this.msMusteri.Size = new System.Drawing.Size(66, 21);
            this.msMusteri.Text = "Müşteri";
            // 
            // msMusteriEkle
            // 
            this.msMusteriEkle.Name = "msMusteriEkle";
            this.msMusteriEkle.Size = new System.Drawing.Size(163, 22);
            this.msMusteriEkle.Text = "Müşteri Ekle";
            this.msMusteriEkle.Click += new System.EventHandler(this.msMusteriEkle_Click);
            // 
            // msMusteriListele
            // 
            this.msMusteriListele.Name = "msMusteriListele";
            this.msMusteriListele.Size = new System.Drawing.Size(163, 22);
            this.msMusteriListele.Text = "Müşteri Listele";
            this.msMusteriListele.Click += new System.EventHandler(this.msMusteriListele_Click);
            // 
            // msTedarikci
            // 
            this.msTedarikci.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msTedarikciEkle,
            this.msTedarikciListele});
            this.msTedarikci.Name = "msTedarikci";
            this.msTedarikci.Size = new System.Drawing.Size(72, 21);
            this.msTedarikci.Text = "Tedarikçi";
            // 
            // msTedarikciEkle
            // 
            this.msTedarikciEkle.Name = "msTedarikciEkle";
            this.msTedarikciEkle.Size = new System.Drawing.Size(169, 22);
            this.msTedarikciEkle.Text = "Tedarikçi Ekle";
            this.msTedarikciEkle.Click += new System.EventHandler(this.msTedarikciEkle_Click);
            // 
            // msTedarikciListele
            // 
            this.msTedarikciListele.Name = "msTedarikciListele";
            this.msTedarikciListele.Size = new System.Drawing.Size(169, 22);
            this.msTedarikciListele.Text = "Tedarikçi Listele";
            this.msTedarikciListele.Click += new System.EventHandler(this.msTedarikciListele_Click);
            // 
            // msHesapDokumu
            // 
            this.msHesapDokumu.Name = "msHesapDokumu";
            this.msHesapDokumu.Size = new System.Drawing.Size(114, 21);
            this.msHesapDokumu.Text = "Hesap Dökümü";
            // 
            // msCikis
            // 
            this.msCikis.Name = "msCikis";
            this.msCikis.Size = new System.Drawing.Size(47, 21);
            this.msCikis.Text = "Çıkış";
            this.msCikis.Click += new System.EventHandler(this.msCikis_Click);
            // 
            // pb1Market
            // 
            this.pb1Market.BackColor = System.Drawing.Color.Transparent;
            this.pb1Market.Image = ((System.Drawing.Image)(resources.GetObject("pb1Market.Image")));
            this.pb1Market.Location = new System.Drawing.Point(295, 53);
            this.pb1Market.Name = "pb1Market";
            this.pb1Market.Size = new System.Drawing.Size(230, 230);
            this.pb1Market.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb1Market.TabIndex = 3;
            this.pb1Market.TabStop = false;
            this.pb1Market.Tag = "asd";
            // 
            // gbKullaniciGirisi
            // 
            this.gbKullaniciGirisi.Controls.Add(this.btnLogin);
            this.gbKullaniciGirisi.Controls.Add(this.lblPass);
            this.gbKullaniciGirisi.Controls.Add(this.lblID);
            this.gbKullaniciGirisi.Controls.Add(this.txtPass);
            this.gbKullaniciGirisi.Controls.Add(this.txtID);
            this.gbKullaniciGirisi.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbKullaniciGirisi.Location = new System.Drawing.Point(24, 53);
            this.gbKullaniciGirisi.Name = "gbKullaniciGirisi";
            this.gbKullaniciGirisi.Size = new System.Drawing.Size(249, 230);
            this.gbKullaniciGirisi.TabIndex = 4;
            this.gbKullaniciGirisi.TabStop = false;
            this.gbKullaniciGirisi.Text = "Kullanıcı Girişi";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(97, 169);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(137, 31);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Giriş";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(10, 114);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(46, 17);
            this.lblPass.TabIndex = 3;
            this.lblPass.Text = "Parola";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(10, 53);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(81, 17);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "Kullanıcı Adı";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(97, 111);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '●';
            this.txtPass.Size = new System.Drawing.Size(137, 25);
            this.txtPass.TabIndex = 1;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(97, 50);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(137, 25);
            this.txtID.TabIndex = 0;
            // 
            // msSatisYap
            // 
            this.msSatisYap.Name = "msSatisYap";
            this.msSatisYap.Size = new System.Drawing.Size(152, 22);
            this.msSatisYap.Text = "Satış Yap";
            this.msSatisYap.Click += new System.EventHandler(this.msSatisYap_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(549, 311);
            this.Controls.Add(this.gbKullaniciGirisi);
            this.Controls.Add(this.pb1Market);
            this.Controls.Add(this.ustMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.ustMenu;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "1Mark@";
            this.ustMenu.ResumeLayout(false);
            this.ustMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb1Market)).EndInit();
            this.gbKullaniciGirisi.ResumeLayout(false);
            this.gbKullaniciGirisi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip ustMenu;
        private System.Windows.Forms.ToolStripMenuItem msUrunler;
        private System.Windows.Forms.ToolStripMenuItem msUrunEkle;
        private System.Windows.Forms.ToolStripMenuItem msUrunListele;
        private System.Windows.Forms.ToolStripMenuItem msMusteri;
        private System.Windows.Forms.ToolStripMenuItem msKatalog;
        private System.Windows.Forms.ToolStripMenuItem msSatis;
        private System.Windows.Forms.ToolStripMenuItem msPersonel;
        private System.Windows.Forms.ToolStripMenuItem msTedarikci;
        private System.Windows.Forms.ToolStripMenuItem msHesapDokumu;
        private System.Windows.Forms.ToolStripMenuItem msPersonelEkle;
        private System.Windows.Forms.ToolStripMenuItem msPersonelListele;
        private System.Windows.Forms.ToolStripMenuItem msMusteriEkle;
        private System.Windows.Forms.ToolStripMenuItem msMusteriListele;
        private System.Windows.Forms.ToolStripMenuItem msTedarikciEkle;
        private System.Windows.Forms.ToolStripMenuItem msTedarikciListele;
        private System.Windows.Forms.PictureBox pb1Market;
        private System.Windows.Forms.GroupBox gbKullaniciGirisi;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ToolStripMenuItem msCikis;
        private System.Windows.Forms.ToolStripMenuItem msSatisYap;
    }
}

