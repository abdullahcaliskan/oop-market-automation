namespace OOP_Okul
{
    partial class SatisYap
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.txtBarkodNo = new System.Windows.Forms.TextBox();
            this.gridStok = new System.Windows.Forms.DataGridView();
            this.lblBarkodNo = new System.Windows.Forms.Label();
            this.lblInfoBar = new System.Windows.Forms.Label();
            this.gridFis = new System.Windows.Forms.DataGridView();
            this.btnFiseEkle = new System.Windows.Forms.Button();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.btnFisdenSil = new System.Windows.Forms.Button();
            this.btnFiseMultipleEkle = new System.Windows.Forms.Button();
            this.btnFistenMultipleSil = new System.Windows.Forms.Button();
            this.lblMiktar = new System.Windows.Forms.Label();
            this.comboMusteri = new System.Windows.Forms.ComboBox();
            this.lblMusteri = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.btnSatisYap = new System.Windows.Forms.Button();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.lblToplam = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridStok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridFis)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHeader.Location = new System.Drawing.Point(12, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(140, 29);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Satış Ekranı";
            // 
            // txtBarkodNo
            // 
            this.txtBarkodNo.Location = new System.Drawing.Point(78, 56);
            this.txtBarkodNo.Name = "txtBarkodNo";
            this.txtBarkodNo.Size = new System.Drawing.Size(183, 20);
            this.txtBarkodNo.TabIndex = 1;
            this.txtBarkodNo.TextChanged += new System.EventHandler(this.txtBarkodNo_TextChanged);
            // 
            // gridStok
            // 
            this.gridStok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridStok.Location = new System.Drawing.Point(12, 100);
            this.gridStok.Name = "gridStok";
            this.gridStok.Size = new System.Drawing.Size(438, 323);
            this.gridStok.TabIndex = 3;
            // 
            // lblBarkodNo
            // 
            this.lblBarkodNo.AutoSize = true;
            this.lblBarkodNo.Location = new System.Drawing.Point(14, 59);
            this.lblBarkodNo.Name = "lblBarkodNo";
            this.lblBarkodNo.Size = new System.Drawing.Size(58, 13);
            this.lblBarkodNo.TabIndex = 4;
            this.lblBarkodNo.Text = "Barkod No";
            // 
            // lblInfoBar
            // 
            this.lblInfoBar.AutoSize = true;
            this.lblInfoBar.Location = new System.Drawing.Point(267, 59);
            this.lblInfoBar.Name = "lblInfoBar";
            this.lblInfoBar.Size = new System.Drawing.Size(87, 13);
            this.lblInfoBar.TabIndex = 6;
            this.lblInfoBar.Text = "*Min. 2 Basamak";
            // 
            // gridFis
            // 
            this.gridFis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFis.Location = new System.Drawing.Point(525, 100);
            this.gridFis.Name = "gridFis";
            this.gridFis.Size = new System.Drawing.Size(438, 323);
            this.gridFis.TabIndex = 7;
            // 
            // btnFiseEkle
            // 
            this.btnFiseEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFiseEkle.Location = new System.Drawing.Point(456, 136);
            this.btnFiseEkle.Name = "btnFiseEkle";
            this.btnFiseEkle.Size = new System.Drawing.Size(63, 40);
            this.btnFiseEkle.TabIndex = 8;
            this.btnFiseEkle.Text = ">";
            this.btnFiseEkle.UseVisualStyleBackColor = true;
            this.btnFiseEkle.Click += new System.EventHandler(this.btnFiseEkle_Click);
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(456, 253);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(63, 20);
            this.txtMiktar.TabIndex = 9;
            // 
            // btnFisdenSil
            // 
            this.btnFisdenSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFisdenSil.Location = new System.Drawing.Point(456, 335);
            this.btnFisdenSil.Name = "btnFisdenSil";
            this.btnFisdenSil.Size = new System.Drawing.Size(63, 40);
            this.btnFisdenSil.TabIndex = 10;
            this.btnFisdenSil.Text = "<";
            this.btnFisdenSil.UseVisualStyleBackColor = true;
            this.btnFisdenSil.Click += new System.EventHandler(this.btnFisdenSil_Click);
            // 
            // btnFiseMultipleEkle
            // 
            this.btnFiseMultipleEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFiseMultipleEkle.Location = new System.Drawing.Point(456, 182);
            this.btnFiseMultipleEkle.Name = "btnFiseMultipleEkle";
            this.btnFiseMultipleEkle.Size = new System.Drawing.Size(63, 40);
            this.btnFiseMultipleEkle.TabIndex = 11;
            this.btnFiseMultipleEkle.Text = ">>";
            this.btnFiseMultipleEkle.UseVisualStyleBackColor = true;
            this.btnFiseMultipleEkle.Click += new System.EventHandler(this.btnFiseMultipleEkle_Click);
            // 
            // btnFistenMultipleSil
            // 
            this.btnFistenMultipleSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFistenMultipleSil.Location = new System.Drawing.Point(456, 289);
            this.btnFistenMultipleSil.Name = "btnFistenMultipleSil";
            this.btnFistenMultipleSil.Size = new System.Drawing.Size(63, 40);
            this.btnFistenMultipleSil.TabIndex = 12;
            this.btnFistenMultipleSil.Text = "<<";
            this.btnFistenMultipleSil.UseVisualStyleBackColor = true;
            this.btnFistenMultipleSil.Click += new System.EventHandler(this.btnFistenMultipleSil_Click);
            // 
            // lblMiktar
            // 
            this.lblMiktar.AutoSize = true;
            this.lblMiktar.Location = new System.Drawing.Point(470, 237);
            this.lblMiktar.Name = "lblMiktar";
            this.lblMiktar.Size = new System.Drawing.Size(36, 13);
            this.lblMiktar.TabIndex = 13;
            this.lblMiktar.Text = "Miktar";
            // 
            // comboMusteri
            // 
            this.comboMusteri.FormattingEnabled = true;
            this.comboMusteri.Location = new System.Drawing.Point(569, 55);
            this.comboMusteri.Name = "comboMusteri";
            this.comboMusteri.Size = new System.Drawing.Size(218, 21);
            this.comboMusteri.TabIndex = 14;
            // 
            // lblMusteri
            // 
            this.lblMusteri.AutoSize = true;
            this.lblMusteri.Location = new System.Drawing.Point(522, 59);
            this.lblMusteri.Name = "lblMusteri";
            this.lblMusteri.Size = new System.Drawing.Size(41, 13);
            this.lblMusteri.TabIndex = 15;
            this.lblMusteri.Text = "Müşteri";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(793, 59);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(136, 13);
            this.lblNote.TabIndex = 16;
            this.lblNote.Text = "*Seçme zorunluluğu yoktur.";
            // 
            // btnSatisYap
            // 
            this.btnSatisYap.Location = new System.Drawing.Point(828, 429);
            this.btnSatisYap.Name = "btnSatisYap";
            this.btnSatisYap.Size = new System.Drawing.Size(135, 23);
            this.btnSatisYap.TabIndex = 17;
            this.btnSatisYap.Text = "Satış Yap";
            this.btnSatisYap.UseVisualStyleBackColor = true;
            this.btnSatisYap.Click += new System.EventHandler(this.btnSatisYap_Click);
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(522, 434);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(0, 13);
            this.lblTarih.TabIndex = 18;
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Location = new System.Drawing.Point(681, 434);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(79, 13);
            this.lblToplamTutar.TabIndex = 19;
            this.lblToplamTutar.Text = "Toplam Tutar : ";
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.Location = new System.Drawing.Point(766, 434);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(0, 13);
            this.lblToplam.TabIndex = 20;
            // 
            // SatisYap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 463);
            this.Controls.Add(this.lblToplam);
            this.Controls.Add(this.lblToplamTutar);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.btnSatisYap);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.lblMusteri);
            this.Controls.Add(this.comboMusteri);
            this.Controls.Add(this.lblMiktar);
            this.Controls.Add(this.btnFistenMultipleSil);
            this.Controls.Add(this.btnFiseMultipleEkle);
            this.Controls.Add(this.btnFisdenSil);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.btnFiseEkle);
            this.Controls.Add(this.gridFis);
            this.Controls.Add(this.lblInfoBar);
            this.Controls.Add(this.lblBarkodNo);
            this.Controls.Add(this.gridStok);
            this.Controls.Add(this.txtBarkodNo);
            this.Controls.Add(this.lblHeader);
            this.Name = "SatisYap";
            this.Text = "SatisYap";
            this.Load += new System.EventHandler(this.SatisYap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridStok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridFis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TextBox txtBarkodNo;
        private System.Windows.Forms.DataGridView gridStok;
        private System.Windows.Forms.Label lblBarkodNo;
        private System.Windows.Forms.Label lblInfoBar;
        private System.Windows.Forms.DataGridView gridFis;
        private System.Windows.Forms.Button btnFiseEkle;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.Button btnFisdenSil;
        private System.Windows.Forms.Button btnFiseMultipleEkle;
        private System.Windows.Forms.Button btnFistenMultipleSil;
        private System.Windows.Forms.Label lblMiktar;
        private System.Windows.Forms.ComboBox comboMusteri;
        private System.Windows.Forms.Label lblMusteri;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Button btnSatisYap;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.Label lblToplam;
    }
}