namespace OOP_Okul
{
    partial class UrunEkle
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
            this.lblAd = new System.Windows.Forms.Label();
            this.lblBarkod = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtBarkodNo = new System.Windows.Forms.TextBox();
            this.lblSKT = new System.Windows.Forms.Label();
            this.dateSKT = new System.Windows.Forms.DateTimePicker();
            this.cmbTedarikci = new System.Windows.Forms.ComboBox();
            this.lblTedarikci = new System.Windows.Forms.Label();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.lblMiktar = new System.Windows.Forms.Label();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.txtEkAciklama = new System.Windows.Forms.TextBox();
            this.lblEkAciklama = new System.Windows.Forms.Label();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.pbYukleniyor = new System.Windows.Forms.ProgressBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblYuzde = new System.Windows.Forms.Label();
            this.lblProgressState = new System.Windows.Forms.Label();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(12, 9);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(48, 13);
            this.lblAd.TabIndex = 0;
            this.lblAd.Text = "Ürün Adı";
            // 
            // lblBarkod
            // 
            this.lblBarkod.AutoSize = true;
            this.lblBarkod.Location = new System.Drawing.Point(12, 35);
            this.lblBarkod.Name = "lblBarkod";
            this.lblBarkod.Size = new System.Drawing.Size(58, 13);
            this.lblBarkod.TabIndex = 1;
            this.lblBarkod.Text = "Barkod No";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(89, 6);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(183, 20);
            this.txtAd.TabIndex = 0;
            // 
            // txtBarkodNo
            // 
            this.txtBarkodNo.Location = new System.Drawing.Point(89, 32);
            this.txtBarkodNo.Name = "txtBarkodNo";
            this.txtBarkodNo.Size = new System.Drawing.Size(183, 20);
            this.txtBarkodNo.TabIndex = 2;
            // 
            // lblSKT
            // 
            this.lblSKT.AutoSize = true;
            this.lblSKT.Location = new System.Drawing.Point(12, 61);
            this.lblSKT.Name = "lblSKT";
            this.lblSKT.Size = new System.Drawing.Size(28, 13);
            this.lblSKT.TabIndex = 4;
            this.lblSKT.Text = "SKT";
            // 
            // dateSKT
            // 
            this.dateSKT.Location = new System.Drawing.Point(89, 58);
            this.dateSKT.Name = "dateSKT";
            this.dateSKT.Size = new System.Drawing.Size(183, 20);
            this.dateSKT.TabIndex = 3;
            // 
            // cmbTedarikci
            // 
            this.cmbTedarikci.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTedarikci.FormattingEnabled = true;
            this.cmbTedarikci.Location = new System.Drawing.Point(89, 84);
            this.cmbTedarikci.Name = "cmbTedarikci";
            this.cmbTedarikci.Size = new System.Drawing.Size(183, 21);
            this.cmbTedarikci.TabIndex = 5;
            // 
            // lblTedarikci
            // 
            this.lblTedarikci.AutoSize = true;
            this.lblTedarikci.Location = new System.Drawing.Point(12, 87);
            this.lblTedarikci.Name = "lblTedarikci";
            this.lblTedarikci.Size = new System.Drawing.Size(51, 13);
            this.lblTedarikci.TabIndex = 8;
            this.lblTedarikci.Text = "Tedarikçi";
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(89, 111);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(183, 20);
            this.txtMiktar.TabIndex = 6;
            // 
            // lblMiktar
            // 
            this.lblMiktar.AutoSize = true;
            this.lblMiktar.Location = new System.Drawing.Point(12, 114);
            this.lblMiktar.Name = "lblMiktar";
            this.lblMiktar.Size = new System.Drawing.Size(36, 13);
            this.lblMiktar.TabIndex = 9;
            this.lblMiktar.Text = "Miktar";
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(89, 137);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(183, 20);
            this.txtFiyat.TabIndex = 7;
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Location = new System.Drawing.Point(12, 140);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(29, 13);
            this.lblFiyat.TabIndex = 11;
            this.lblFiyat.Text = "Fiyat";
            // 
            // txtEkAciklama
            // 
            this.txtEkAciklama.Location = new System.Drawing.Point(89, 163);
            this.txtEkAciklama.Multiline = true;
            this.txtEkAciklama.Name = "txtEkAciklama";
            this.txtEkAciklama.Size = new System.Drawing.Size(183, 70);
            this.txtEkAciklama.TabIndex = 8;
            // 
            // lblEkAciklama
            // 
            this.lblEkAciklama.AutoSize = true;
            this.lblEkAciklama.Location = new System.Drawing.Point(12, 166);
            this.lblEkAciklama.Name = "lblEkAciklama";
            this.lblEkAciklama.Size = new System.Drawing.Size(66, 13);
            this.lblEkAciklama.TabIndex = 13;
            this.lblEkAciklama.Text = "Ek Açıklama";
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.Location = new System.Drawing.Point(89, 239);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(183, 23);
            this.btnUrunEkle.TabIndex = 9;
            this.btnUrunEkle.Text = "Ürün Ekle";
            this.btnUrunEkle.UseVisualStyleBackColor = true;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // pbYukleniyor
            // 
            this.pbYukleniyor.Location = new System.Drawing.Point(15, 279);
            this.pbYukleniyor.Name = "pbYukleniyor";
            this.pbYukleniyor.Size = new System.Drawing.Size(257, 16);
            this.pbYukleniyor.Step = 1;
            this.pbYukleniyor.TabIndex = 14;
            this.pbYukleniyor.UseWaitCursor = true;
            // 
            // timer
            // 
            this.timer.Interval = 25;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lblYuzde
            // 
            this.lblYuzde.AutoSize = true;
            this.lblYuzde.BackColor = System.Drawing.Color.Transparent;
            this.lblYuzde.Enabled = false;
            this.lblYuzde.Location = new System.Drawing.Point(242, 298);
            this.lblYuzde.Name = "lblYuzde";
            this.lblYuzde.Size = new System.Drawing.Size(0, 13);
            this.lblYuzde.TabIndex = 15;
            // 
            // lblProgressState
            // 
            this.lblProgressState.AutoSize = true;
            this.lblProgressState.Enabled = false;
            this.lblProgressState.Location = new System.Drawing.Point(13, 298);
            this.lblProgressState.Name = "lblProgressState";
            this.lblProgressState.Size = new System.Drawing.Size(0, 13);
            this.lblProgressState.TabIndex = 16;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(15, 239);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(68, 23);
            this.btnTemizle.TabIndex = 17;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // UrunEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 321);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.lblProgressState);
            this.Controls.Add(this.lblYuzde);
            this.Controls.Add(this.pbYukleniyor);
            this.Controls.Add(this.btnUrunEkle);
            this.Controls.Add(this.txtEkAciklama);
            this.Controls.Add(this.lblEkAciklama);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.lblMiktar);
            this.Controls.Add(this.cmbTedarikci);
            this.Controls.Add(this.lblTedarikci);
            this.Controls.Add(this.dateSKT);
            this.Controls.Add(this.lblSKT);
            this.Controls.Add(this.txtBarkodNo);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.lblBarkod);
            this.Controls.Add(this.lblAd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 360);
            this.MinimumSize = new System.Drawing.Size(300, 360);
            this.Name = "UrunEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblBarkod;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtBarkodNo;
        private System.Windows.Forms.Label lblSKT;
        private System.Windows.Forms.DateTimePicker dateSKT;
        private System.Windows.Forms.Label lblTedarikci;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.Label lblMiktar;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.TextBox txtEkAciklama;
        private System.Windows.Forms.Label lblEkAciklama;
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.ProgressBar pbYukleniyor;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ComboBox cmbTedarikci;
        private System.Windows.Forms.Label lblYuzde;
        private System.Windows.Forms.Label lblProgressState;
        private System.Windows.Forms.Button btnTemizle;
    }
}