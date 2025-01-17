using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Final_Project.Model.Entity;
using Final_Project.Model.Context;
using Final_Project.Model.Repository;
using Final_Project.Controller;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class formMinuman : Form
    {
        // deklarasi collection untuk menampung objek barang
        private List<Barang> listOfBarang = new List<Barang>();

        // deklarasi objek controller
        private BarangController controller;

        public formMinuman()
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

        private void formMinuman_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void btnLemonTea_Click(object sender, EventArgs e)
        {
            // buat objek form entry data barang
            formTambah frmTambah = new formTambah("Tambah Data Barang", controller, "minuman", "Lemon Tea");

            // mendaftarkan method event handler utk merespon event OnCreate (subscribe)
            frmTambah.OnCreate += OnCreateEventHandler;

            // tampilkan form entry barang
            frmTambah.ShowDialog();
        }

        private void btnEsTeh_Click(object sender, EventArgs e)
        {
            // buat objek form entry data barang
            formTambah frmTambah = new formTambah("Tambah Data Barang", controller, "minuman", "Es Teh");

            // mendaftarkan method event handler utk merespon event OnCreate (subscribe)
            frmTambah.OnCreate += OnCreateEventHandler;

            // tampilkan form entry barang
            frmTambah.ShowDialog();
        }

        private void btnEsJeruk_Click(object sender, EventArgs e)
        {
            // buat objek form entry data barang
            formTambah frmTambah = new formTambah("Tambah Data Barang", controller, "minuman", "Es Jeruk");

            // mendaftarkan method event handler utk merespon event OnCreate (subscribe)
            frmTambah.OnCreate += OnCreateEventHandler;

            // tampilkan form entry barang
            frmTambah.ShowDialog();
        }

        private void btnKopiSusu_Click(object sender, EventArgs e)
        {
            // buat objek form entry data barang
            formTambah frmTambah = new formTambah("Tambah Data Barang", controller, "minuman", "Es Kopi Susu");

            // mendaftarkan method event handler utk merespon event OnCreate (subscribe)
            frmTambah.OnCreate += OnCreateEventHandler;

            // tampilkan form entry barang
            frmTambah.ShowDialog();
        }

        private void btnEsSusu_Click(object sender, EventArgs e)
        {
            // buat objek form entry data barang
            formTambah frmTambah = new formTambah("Tambah Data Barang", controller, "minuman", "Es Susu");

            // mendaftarkan method event handler utk merespon event OnCreate (subscribe)
            frmTambah.OnCreate += OnCreateEventHandler;

            // tampilkan form entry barang
            frmTambah.ShowDialog();
        }

        private void btnSodaGembira_Click(object sender, EventArgs e)
        {
            // buat objek form entry data barang
            formTambah frmTambah = new formTambah("Tambah Data Barang", controller, "minuman", "Soda Gembira");

            // mendaftarkan method event handler utk merespon event OnCreate (subscribe)
            frmTambah.OnCreate += OnCreateEventHandler;

            // tampilkan form entry barang
            frmTambah.ShowDialog();
        }

        private void btnTehBotol_Click(object sender, EventArgs e)
        {
            // buat objek form entry data barang
            formTambah frmTambah = new formTambah("Tambah Data Barang", controller, "minuman", "Teh Botol");

            // mendaftarkan method event handler utk merespon event OnCreate (subscribe)
            frmTambah.OnCreate += OnCreateEventHandler;

            // tampilkan form entry barang
            frmTambah.ShowDialog();
        }

        private void btnEsCampur_Click(object sender, EventArgs e)
        {
            // buat objek form entry data barang
            formTambah frmTambah = new formTambah("Tambah Data Barang", controller, "minuman", "Es Campur");

            // mendaftarkan method event handler utk merespon event OnCreate (subscribe)
            frmTambah.OnCreate += OnCreateEventHandler;

            // tampilkan form entry barang
            frmTambah.ShowDialog();
        }
    }
}
