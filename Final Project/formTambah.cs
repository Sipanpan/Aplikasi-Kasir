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
    // deklarasi tipe data untuk event OnCreate dan OnUpdate
    public delegate void CreateUpdateEventHandler(Barang brg);
    public partial class formTambah : Form
    {
        // deklarasi event ketika terjadi proses input data baru
        public event CreateUpdateEventHandler OnCreate;

        // deklarasi event ketika terjadi proses update data
        public event CreateUpdateEventHandler OnUpdate;

        // deklarasi variabel untuk menyimpan status entry data (input baru atau update)
        private bool isNewData = true;

        // deklarasi variabel/objek brg untuk meyimpan data barang
        private Barang brg;

        //Constructor default
        public formTambah()
        {
            InitializeComponent();
        }

        // Constructor untuk inisialisasi data ketika entri data baru
        public formTambah(string title) : this()
        {
            // ganti text/judul form
            this.Text = title;
        }

        // Constructor untuk inisialisasi data ketika mengedit data
        public formTambah(string title, Barang obj) : this()
        {
            // ganti text/judul form
            this.Text = title;

            isNewData = false; // set status edit data
            brg = obj; // set objek brg yang akan diedit

            // untuk edit data, tampilkan data lama
            txtNama.Text = brg.Nama;
            txtJumlah.Text = brg.Jumlah;
            txtHarga.Text = brg.Harga;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            // jika data baru, inisialisasi objek barang
            if (isNewData) brg = new Barang();

            // set nilai property objek barang yg diambil dari TextBox
            brg.Nama = txtNama.Text;
            brg.Jumlah = txtJumlah.Text;
            brg.Harga = txtHarga.Text;
            brg.Total = Int32.Parse(txtJumlah.Text) * Int32.Parse(txtHarga.Text); ///!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

            if (isNewData) // data baru
            {
                OnCreate(brg); // panggil event OnCreate
                
                // reset form input, utk persiapan input data berikutnya
                txtNama.Clear();
                txtJumlah.Clear();
                txtHarga.Clear();

                txtNama.Focus();
            }
            else // update
            {
                OnUpdate(brg); // panggil event OnUpdate
                this.Close();
            }*/
            }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            // tutup form tambah data barang
            this.Close();
        }
    }
}
