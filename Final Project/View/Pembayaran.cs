using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Final_Project.View;


namespace Final_Project.View
{
    public partial class frmPembayaran : Form
    {
        public frmPembayaran()
        {
            InitializeComponent();
            this.FormClosed += FrmPembayaran_FormClosed;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void frmPembayaran_Load(object sender, EventArgs e)
        {

        }

        private void FrmPembayaran_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void btnX_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnQR_Click(object sender, EventArgs e)
        {
            btnQR.Visible = false;
            frmQRIS qr = new frmQRIS();
            qr.FormClosed += FrmQRIS_FormClosed;
            qr.Show();
        }

        private void FrmQRIS_FormClosed(object sender, FormClosedEventArgs e)
        {
            btnQR.Visible = true;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Terimakasih sudah membayar. Selamat Menikmati :)", "Informasi",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
