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

namespace Final_Project
{
    public partial class formCemilan : Form
    {
        // deklarasi collection untuk menampung objek barang
        private List<Barang> listOfBarang = new List<Barang>();

        // deklarasi objek controller
        private BarangController controller;

        public formCemilan()
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

        private void formCemilan_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void btnKentangGoreng_Click(object sender, EventArgs e)
        {
            // buat objek form entry data barang
            formTambah frmTambah = new formTambah("Tambah Data Barang", controller, "Kentang Goreng", "6000");

            // mendaftarkan method event handler utk merespon event OnCreate (subscribe)
            frmTambah.OnCreate += OnCreateEventHandler;

            // tampilkan form entry barang
            frmTambah.ShowDialog();
        }

        private void btnTerongKrispi_Click(object sender, EventArgs e)
        {
            // buat objek form entry data barang
            formTambah frmTambah = new formTambah("Tambah Data Barang", controller, "Terong Krispi", "5000");

            // mendaftarkan method event handler utk merespon event OnCreate (subscribe)
            frmTambah.OnCreate += OnCreateEventHandler;

            // tampilkan form entry barang
            frmTambah.ShowDialog();
        }

        private void btnTempeKriuk_Click(object sender, EventArgs e)
        {
            // buat objek form entry data barang
            formTambah frmTambah = new formTambah("Tambah Data Barang", controller, "Tempe Kriuk", "4000");

            // mendaftarkan method event handler utk merespon event OnCreate (subscribe)
            frmTambah.OnCreate += OnCreateEventHandler;

            // tampilkan form entry barang
            frmTambah.ShowDialog();
        }

        private void btnTahuKrispi_Click(object sender, EventArgs e)
        {
            // buat objek form entry data barang
            formTambah frmTambah = new formTambah("Tambah Data Barang", controller, "Tahu Krispi", "5000");

            // mendaftarkan method event handler utk merespon event OnCreate (subscribe)
            frmTambah.OnCreate += OnCreateEventHandler;

            // tampilkan form entry barang
            frmTambah.ShowDialog();
        }

        private void btnJamurKrispi_Click(object sender, EventArgs e)
        {
            // buat objek form entry data barang
            formTambah frmTambah = new formTambah("Tambah Data Barang", controller, "Jamur Krispi", "6000");

            // mendaftarkan method event handler utk merespon event OnCreate (subscribe)
            frmTambah.OnCreate += OnCreateEventHandler;

            // tampilkan form entry barang
            frmTambah.ShowDialog();
        }

        private void btnTahuBakso_Click(object sender, EventArgs e)
        {
            // buat objek form entry data barang
            formTambah frmTambah = new formTambah("Tambah Data Barang", controller, "Tahu Bakso", "8000");

            // mendaftarkan method event handler utk merespon event OnCreate (subscribe)
            frmTambah.OnCreate += OnCreateEventHandler;

            // tampilkan form entry barang
            frmTambah.ShowDialog();
        }

        private void btnGorengan_Click(object sender, EventArgs e)
        {
            // buat objek form entry data barang
            formTambah frmTambah = new formTambah("Tambah Data Barang", controller, "Gorengan", "5000");

            // mendaftarkan method event handler utk merespon event OnCreate (subscribe)
            frmTambah.OnCreate += OnCreateEventHandler;

            // tampilkan form entry barang
            frmTambah.ShowDialog();
        }

        private void btnTahuPenyet_Click(object sender, EventArgs e)
        {
            // buat objek form entry data barang
            formTambah frmTambah = new formTambah("Tambah Data Barang", controller, "Tahu Penyet", "5000");

            // mendaftarkan method event handler utk merespon event OnCreate (subscribe)
            frmTambah.OnCreate += OnCreateEventHandler;

            // tampilkan form entry barang
            frmTambah.ShowDialog();
        }
    }
}
