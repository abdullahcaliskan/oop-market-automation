namespace OOP_Okul
{
    partial class UrunListele
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
            this.gridUrunler = new System.Windows.Forms.DataGridView();
            this.lblInfoBar = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridUrunler)).BeginInit();
            this.SuspendLayout();
            // 
            // gridUrunler
            // 
            this.gridUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUrunler.Location = new System.Drawing.Point(12, 35);
            this.gridUrunler.Name = "gridUrunler";
            this.gridUrunler.Size = new System.Drawing.Size(763, 257);
            this.gridUrunler.TabIndex = 0;
            this.gridUrunler.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridUrunler_CellMouseDoubleClick);
            // 
            // lblInfoBar
            // 
            this.lblInfoBar.AutoSize = true;
            this.lblInfoBar.Location = new System.Drawing.Point(618, 298);
            this.lblInfoBar.Name = "lblInfoBar";
            this.lblInfoBar.Size = new System.Drawing.Size(157, 13);
            this.lblInfoBar.TabIndex = 1;
            this.lblInfoBar.Text = "Stokta bulunan ürünler listelendi";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Location = new System.Drawing.Point(12, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(341, 13);
            this.lblHeader.TabIndex = 2;
            this.lblHeader.Text = "*Ürün üzerinde işlem yapmak için, çift tıklayınız. (miktar arttır/azalt ve sil)";
            // 
            // UrunListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 320);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblInfoBar);
            this.Controls.Add(this.gridUrunler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "UrunListele";
            this.Text = "Ürün Listesi";
            this.Load += new System.EventHandler(this.UrunListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridUrunler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridUrunler;
        private System.Windows.Forms.Label lblInfoBar;
        private System.Windows.Forms.Label lblHeader;
    }
}