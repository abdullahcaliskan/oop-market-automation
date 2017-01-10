namespace OOP_Okul
{
    partial class MusteriEdit
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
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.txtPostaKodu = new System.Windows.Forms.TextBox();
            this.txtAcikAdres = new System.Windows.Forms.TextBox();
            this.txtIlce = new System.Windows.Forms.TextBox();
            this.dateKayitTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtIl = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPostaKodu = new System.Windows.Forms.Label();
            this.lblAcikAdres = new System.Windows.Forms.Label();
            this.lblIlce = new System.Windows.Forms.Label();
            this.lblIl = new System.Windows.Forms.Label();
            this.lblKayitTarihi = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(80, 257);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(90, 23);
            this.btnGuncelle.TabIndex = 46;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // txtPostaKodu
            // 
            this.txtPostaKodu.Location = new System.Drawing.Point(80, 231);
            this.txtPostaKodu.Name = "txtPostaKodu";
            this.txtPostaKodu.Size = new System.Drawing.Size(192, 20);
            this.txtPostaKodu.TabIndex = 43;
            // 
            // txtAcikAdres
            // 
            this.txtAcikAdres.Location = new System.Drawing.Point(80, 168);
            this.txtAcikAdres.Multiline = true;
            this.txtAcikAdres.Name = "txtAcikAdres";
            this.txtAcikAdres.Size = new System.Drawing.Size(192, 57);
            this.txtAcikAdres.TabIndex = 41;
            // 
            // txtIlce
            // 
            this.txtIlce.Location = new System.Drawing.Point(80, 142);
            this.txtIlce.Name = "txtIlce";
            this.txtIlce.Size = new System.Drawing.Size(192, 20);
            this.txtIlce.TabIndex = 39;
            // 
            // dateKayitTarihi
            // 
            this.dateKayitTarihi.Location = new System.Drawing.Point(80, 90);
            this.dateKayitTarihi.Name = "dateKayitTarihi";
            this.dateKayitTarihi.Size = new System.Drawing.Size(192, 20);
            this.dateKayitTarihi.TabIndex = 35;
            // 
            // txtIl
            // 
            this.txtIl.Location = new System.Drawing.Point(80, 116);
            this.txtIl.Name = "txtIl";
            this.txtIl.Size = new System.Drawing.Size(192, 20);
            this.txtIl.TabIndex = 37;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(80, 64);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(192, 20);
            this.txtEmail.TabIndex = 34;
            // 
            // lblPostaKodu
            // 
            this.lblPostaKodu.AutoSize = true;
            this.lblPostaKodu.Location = new System.Drawing.Point(12, 234);
            this.lblPostaKodu.Name = "lblPostaKodu";
            this.lblPostaKodu.Size = new System.Drawing.Size(62, 13);
            this.lblPostaKodu.TabIndex = 45;
            this.lblPostaKodu.Text = "Posta Kodu";
            // 
            // lblAcikAdres
            // 
            this.lblAcikAdres.AutoSize = true;
            this.lblAcikAdres.Location = new System.Drawing.Point(12, 171);
            this.lblAcikAdres.Name = "lblAcikAdres";
            this.lblAcikAdres.Size = new System.Drawing.Size(58, 13);
            this.lblAcikAdres.TabIndex = 44;
            this.lblAcikAdres.Text = "Açık Adres";
            // 
            // lblIlce
            // 
            this.lblIlce.AutoSize = true;
            this.lblIlce.Location = new System.Drawing.Point(12, 145);
            this.lblIlce.Name = "lblIlce";
            this.lblIlce.Size = new System.Drawing.Size(24, 13);
            this.lblIlce.TabIndex = 42;
            this.lblIlce.Text = "İlçe";
            // 
            // lblIl
            // 
            this.lblIl.AutoSize = true;
            this.lblIl.Location = new System.Drawing.Point(12, 119);
            this.lblIl.Name = "lblIl";
            this.lblIl.Size = new System.Drawing.Size(12, 13);
            this.lblIl.TabIndex = 40;
            this.lblIl.Text = "İl";
            // 
            // lblKayitTarihi
            // 
            this.lblKayitTarihi.AutoSize = true;
            this.lblKayitTarihi.Location = new System.Drawing.Point(12, 93);
            this.lblKayitTarihi.Name = "lblKayitTarihi";
            this.lblKayitTarihi.Size = new System.Drawing.Size(59, 13);
            this.lblKayitTarihi.TabIndex = 38;
            this.lblKayitTarihi.Text = "Kayıt Tarihi";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(12, 67);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(36, 13);
            this.lblEmail.TabIndex = 36;
            this.lblEmail.Text = "E-Mail";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(80, 38);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(192, 20);
            this.txtTelefon.TabIndex = 33;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(80, 12);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(192, 20);
            this.txtAd.TabIndex = 31;
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(12, 41);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(60, 13);
            this.lblTelefon.TabIndex = 32;
            this.lblTelefon.Text = "Telefon No";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(12, 15);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(25, 13);
            this.lblAd.TabIndex = 30;
            this.lblAd.Text = "İsim";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(176, 257);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(96, 23);
            this.btnSil.TabIndex = 47;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // MusteriEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 292);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.txtPostaKodu);
            this.Controls.Add(this.txtAcikAdres);
            this.Controls.Add(this.txtIlce);
            this.Controls.Add(this.dateKayitTarihi);
            this.Controls.Add(this.txtIl);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblPostaKodu);
            this.Controls.Add(this.lblAcikAdres);
            this.Controls.Add(this.lblIlce);
            this.Controls.Add(this.lblIl);
            this.Controls.Add(this.lblKayitTarihi);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.lblAd);
            this.Name = "MusteriEdit";
            this.Text = "MusteriEdit";
            this.Load += new System.EventHandler(this.MusteriEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox txtPostaKodu;
        private System.Windows.Forms.TextBox txtAcikAdres;
        private System.Windows.Forms.TextBox txtIlce;
        private System.Windows.Forms.DateTimePicker dateKayitTarihi;
        private System.Windows.Forms.TextBox txtIl;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPostaKodu;
        private System.Windows.Forms.Label lblAcikAdres;
        private System.Windows.Forms.Label lblIlce;
        private System.Windows.Forms.Label lblIl;
        private System.Windows.Forms.Label lblKayitTarihi;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Button btnSil;
    }
}