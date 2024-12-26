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
    public partial class frmQRIS : Form
    {
        public frmQRIS()
        {
            InitializeComponent();
            this.FormClosed += FrmQRIS_FormClosed;
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmQRIS_Load(object sender, EventArgs e)
        {

        }
        private void FrmQRIS_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();    
        }
    }
}
