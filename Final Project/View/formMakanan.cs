using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Final_Project.Model.Entity;
using Final_Project.Model.Context;
using Final_Project.Model.Repository;
using Final_Project.Controller;
using Bunifu.UI.WinForms;

namespace Final_Project
{
    public partial class formMakanan : Form
    {
        // deklarasi collection untuk menampung objek barang
        private List<Barang> listOfBarang = new List<Barang>();

        // deklarasi objek controller
        private BarangController controller;

        // deklarasi variabel/objek brg untuk meyimpan data barang
        private Barang mieso;

        public formMakanan()
        {
            InitializeComponent();

            // membuat objek controller
            controller = new BarangController();
        }

        // method event handler untuk merespon event OnCreate
        private void OnCreateEventHandler(Barang brg)
        {
            // tambahkan objek brg yang baru ke dalam collection
            listOfBarang.Add(brg);

            int noUrut = listOfBarang.Count + 1;

            // tampilkan data brg yang baru ke list view
            ListViewItem item = new ListViewItem(noUrut.ToString());
            item.SubItems.Add(brg.Nama);
            item.SubItems.Add(brg.Jumlah);
            item.SubItems.Add(brg.Harga);
            item.SubItems.Add(brg.Total.ToString());

            // lvwBarang.Items.Add(item);
        }

        private void formMakanan_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void btnBaksoJumbo_Click(object sender, EventArgs e)
        {
            //string ww = "Bakso Jumbo";

            // buat objek form entry data barang
            formTambah frmTambah = new formTambah("Tambah Data Barang", controller, "Bakso Jumbo", "12000");

            // mendaftarkan method event handler utk merespon event OnCreate (subscribe)
            frmTambah.OnCreate += OnCreateEventHandler;

            // tampilkan form entry barang
            frmTambah.ShowDialog();
        }


        /*
        private void btnMieAyam_Click(object sender, EventArgs e)
        {
            // buat objek form entry data barang
            formTambah frmTambah = new formTambah("Tambah Data Barang", "Mie Ayam");

            // mendaftarkan method event handler utk merespon event OnCreate (subscribe)
            //frmTambah.OnCreate += formTambah_OnCreate;

            // tampilkan form entry barang
            frmTambah.ShowDialog();
        }*/
    }
}
