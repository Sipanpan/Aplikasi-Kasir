using Final_Project.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Final_Project.Model.Entity;

namespace Final_Project
{
    // deklarasi tipe data untuk event OnCreate dan OnUpdate
    public delegate void CreateUpdateEventHandler(Barang brg);
    public partial class formTambah : Form
    {
        // deklarasi event ketika terjadi proses input data baru
        public event CreateUpdateEventHandler OnCreate;

        // deklarasi event ketika terjadi proses update data
        public event CreateUpdateEventHandler OnUpdate;

        // deklarasi objek controller
        private BarangController Controller;

        // deklarasi field untuk menyimpan status entry data (input baru atau update)
        private bool isNewData = true;

        // deklarasi field untuk meyimpan objek barang
        private Barang brg;

        //Constructor default
        public formTambah()
        {
            InitializeComponent();
        }

        // Constructor untuk inisialisasi data ketika entri data baru
        public formTambah(string title, BarangController controller, string jenis, string nama) : this()
        {
            lblJudul.Text = nama;
            //lblHarga.Text = harga;
            
            // ganti text/judul form
            this.Text = title;
            this.Controller = controller;

            Barang brg = new Barang();
            lblHarga.Text = controller.Pesan(jenis, nama).ToString();
            brg.Nama = nama;
            //brg.Harga = harga;
            brg.Harga = lblHarga.Text;

        }

        // Constructor untuk inisialisasi data ketika mengedit data
        public formTambah(string title, Barang obj, BarangController controller) : this()
        {
            // ganti text/judul form
            this.Text = title;
            this.Controller = controller;

            isNewData = false; // set status edit data
            brg = obj; // set objek brg yang akan diedit

            // untuk edit data, tampilkan data lama
            lblJudul.Text = brg.Nama;
            txtJumlah.Text = brg.Jumlah;
            lblHarga.Text = brg.Harga;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            // jika data baru, inisisalisasi objek barang
            if (isNewData) brg = new Barang();

            // set nilai property objek barang yang diambil dari textbox
            brg.Nama = lblJudul.Text;
            brg.Jumlah = txtJumlah.Text;
            brg.Harga = lblHarga.Text;
            brg.Total = Int32.Parse(brg.Jumlah) * Int32.Parse(brg.Harga);

            int result = 0;

            if (isNewData) // tambah data baru, panggil method create
            {
                // panggil operasi CRUD
                result = Controller.Create(brg);

                if (result > 0) // tambah data berhasil
                {
                    OnCreate(brg); // panggil event OnCreate

                    // reset form input, untuk persiapan input data berikutnya
                    txtJumlah.Clear();
                }
            }
            else // edit data, panggil method Update
            {
                // panggil operasi CRUD
                result = Controller.Update(brg);

                if (result > 0)
                {
                    OnUpdate(brg); // panggil event OnUpdate
                    this.Close();
                }
            }
        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            // tutup form tambah data barang
            this.Close();
        }

        private bool NumericOnly (KeyPressEventArgs e)
        {
            var strValid = "0123456789";
            if (!(e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                // inputan selain angka
                if (strValid.IndexOf(e.KeyChar) < 0)
                {
                    return true;
                }
                return false;
            }
            else
            {
                return false;
            }
        }

        private void txtJumlah_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = NumericOnly(e);
        }
    }
}
