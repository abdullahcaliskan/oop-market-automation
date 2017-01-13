namespace OOP_Okul
{
    partial class HesapDokumu
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
            this.lblGunSonu = new System.Windows.Forms.Label();
            this.txtKayitlar = new System.Windows.Forms.TextBox();
            this.lblToplamTutarInfo = new System.Windows.Forms.Label();
            this.lblSatilanInfo = new System.Windows.Forms.Label();
            this.lblTutar = new System.Windows.Forms.Label();
            this.lblSayi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGunSonu
            // 
            this.lblGunSonu.AutoSize = true;
            this.lblGunSonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGunSonu.Location = new System.Drawing.Point(12, 9);
            this.lblGunSonu.Name = "lblGunSonu";
            this.lblGunSonu.Size = new System.Drawing.Size(141, 24);
            this.lblGunSonu.TabIndex = 1;
            this.lblGunSonu.Text = "Hesap Dökümü";
            // 
            // txtKayitlar
            // 
            this.txtKayitlar.Location = new System.Drawing.Point(12, 48);
            this.txtKayitlar.Multiline = true;
            this.txtKayitlar.Name = "txtKayitlar";
            this.txtKayitlar.Size = new System.Drawing.Size(794, 278);
            this.txtKayitlar.TabIndex = 2;
            // 
            // lblToplamTutarInfo
            // 
            this.lblToplamTutarInfo.AutoSize = true;
            this.lblToplamTutarInfo.Location = new System.Drawing.Point(9, 329);
            this.lblToplamTutarInfo.Name = "lblToplamTutarInfo";
            this.lblToplamTutarInfo.Size = new System.Drawing.Size(79, 13);
            this.lblToplamTutarInfo.TabIndex = 3;
            this.lblToplamTutarInfo.Text = "Toplam Tutar : ";
            // 
            // lblSatilanInfo
            // 
            this.lblSatilanInfo.AutoSize = true;
            this.lblSatilanInfo.Location = new System.Drawing.Point(325, 329);
            this.lblSatilanInfo.Name = "lblSatilanInfo";
            this.lblSatilanInfo.Size = new System.Drawing.Size(104, 13);
            this.lblSatilanInfo.TabIndex = 4;
            this.lblSatilanInfo.Text = "Satılan Ürün Sayısı : ";
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Location = new System.Drawing.Point(94, 329);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(0, 13);
            this.lblTutar.TabIndex = 5;
            // 
            // lblSayi
            // 
            this.lblSayi.AutoSize = true;
            this.lblSayi.Location = new System.Drawing.Point(435, 329);
            this.lblSayi.Name = "lblSayi";
            this.lblSayi.Size = new System.Drawing.Size(0, 13);
            this.lblSayi.TabIndex = 6;
            // 
            // HesapDokumu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 364);
            this.Controls.Add(this.lblSayi);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.lblSatilanInfo);
            this.Controls.Add(this.lblToplamTutarInfo);
            this.Controls.Add(this.txtKayitlar);
            this.Controls.Add(this.lblGunSonu);
            this.Name = "HesapDokumu";
            this.Text = "Hesap Dökümü";
            this.Load += new System.EventHandler(this.HesapDokumu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGunSonu;
        private System.Windows.Forms.TextBox txtKayitlar;
        private System.Windows.Forms.Label lblToplamTutarInfo;
        private System.Windows.Forms.Label lblSatilanInfo;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.Label lblSayi;
    }
}