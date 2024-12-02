using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class formMakanan : Form
    {
        public formMakanan()
        {
            InitializeComponent();
        }
                
        private void formMakanan_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        public void bunifuButton22_Click(object sender, EventArgs e)
        {
            // buat objek form entry data barang
            formTambah frmTambah = new formTambah("Tambah Data Barang");

            // mendaftarkan method event handler utk merespon event OnCreate (subscribe)
            //frmTambah.OnCreate += formTambah_OnCreate;

            // tampilkan form entry barang
            frmTambah.ShowDialog();
        }
    }
}
