namespace OOP_Okul
{
    partial class PersonelListele
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
            this.lblInfoBar = new System.Windows.Forms.Label();
            this.gridMusteriler = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridMusteriler)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Location = new System.Drawing.Point(12, 13);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(256, 13);
            this.lblHeader.TabIndex = 9;
            this.lblHeader.Text = "*İşlem yapmak istediğiniz satıra/hücreye çift tıklayınız.";
            // 
            // lblInfoBar
            // 
            this.lblInfoBar.AutoSize = true;
            this.lblInfoBar.Location = new System.Drawing.Point(684, 366);
            this.lblInfoBar.Name = "lblInfoBar";
            this.lblInfoBar.Size = new System.Drawing.Size(252, 13);
            this.lblInfoBar.TabIndex = 8;
            this.lblInfoBar.Text = "Marketinizde çalışan personeller ve bilgileri listelendi.";
            // 
            // gridMusteriler
            // 
            this.gridMusteriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMusteriler.Location = new System.Drawing.Point(12, 39);
            this.gridMusteriler.Name = "gridMusteriler";
            this.gridMusteriler.Size = new System.Drawing.Size(924, 319);
            this.gridMusteriler.TabIndex = 7;
            this.gridMusteriler.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridMusteriler_CellMouseDoubleClick);
            // 
            // PersonelListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 388);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblInfoBar);
            this.Controls.Add(this.gridMusteriler);
            this.Name = "PersonelListele";
            this.Text = "PersonelListele";
            this.Load += new System.EventHandler(this.PersonelListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridMusteriler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblInfoBar;
        private System.Windows.Forms.DataGridView gridMusteriler;
    }
}