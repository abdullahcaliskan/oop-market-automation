using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Okul
{
    

    public partial class PromptDialog : Form
    {
        Communicator iletisim_glob;
        public PromptDialog()
        {
            lblBilgi.Text = "Geçerli bir işlem yok..."+ Environment.NewLine +
                            "Pencere kapatılacak...";
            System.Threading.Thread.Sleep(1500);
            this.Close();
        }
        public PromptDialog(Communicator iletisim)
        {
            InitializeComponent();
            lblBilgi.Text = iletisim.InfoMessage;
            iletisim_glob = iletisim;
        }

        private void PromptDialog_Load(object sender, EventArgs e)
        { 
            btnEkle.Enabled = false;
            btnCikar.Enabled = false;   
        }

        private void txtAdet_TextChanged(object sender, EventArgs e)
        {
            if (txtAdet.Text == "")
            {
                btnEkle.Enabled = false;
                btnCikar.Enabled = false;
            }
            else
            {
                btnEkle.Enabled = true;
                btnCikar.Enabled = true;
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            iletisim_glob.PromptMiktar= Convert.ToInt32(txtAdet.Text);
            iletisim_glob.Response = "EKLE";
            this.Close();
        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            iletisim_glob.PromptMiktar = Convert.ToInt32(txtAdet.Text);
            if (iletisim_glob.Miktar <= iletisim_glob.PromptMiktar)
                iletisim_glob.Response = "SIL";
            else
                iletisim_glob.Response = "CIKAR";
            this.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            iletisim_glob.Response = "SIL";
            this.Close();
        }
    }
}
