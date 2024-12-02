using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
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
            var result = 0;

            // validasi nama harus diisi
            if (string.IsNullOrEmpty(txtNama.Text))
            {
                MessageBox.Show("Nama harus diisi !!!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNama.Focus();
                return;
            }

            // validasi jumlah harus diisi
            if (string.IsNullOrEmpty(txtJumlah.Text))
            {
                MessageBox.Show("Jumlah harus diisi !!!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtJumlah.Focus();
                return;
            }

            // membuat objek Connection, sekaligus buka koneksi ke database
            SQLiteConnection conn = GetOpenConnection();

            // deklarasi variabel sql untuk menampung perintah INSERT
            var sql = @"insert into barang (Nama, Jumlah, Harga) values (@Nama, @Jumlah, @Harga)";

            // membuat objek Command untuk mengeksekusi perintah SQL
            SQLiteCommand cmd = new SQLiteCommand(sql, conn);

            try
            {
                // set parameter untuk Nama, Jumlah dan Harga
                cmd.Parameters.AddWithValue("@Nama", txtNama.Text);
                cmd.Parameters.AddWithValue("@Jumlah", txtJumlah.Text);
                cmd.Parameters.AddWithValue("@Harga", txtHarga.Text);

                result = cmd.ExecuteNonQuery(); // eksekusi perintah INSERT
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cmd.Dispose();
            }

            if (result > 0)
            {
                MessageBox.Show("Data mahasiswa berhasil disimpan !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                // reset form
                txtNama.Clear();
                txtJumlah.Clear();
                txtHarga.Clear();
                txtNama.Focus();
            }
            else
                MessageBox.Show("Data mahasiswa gagal disimpan !!!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            
            // setelah selesai digunakan,
            // segera hapus objek connection dari memory
            conn.Dispose();




            /*
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

        private SQLiteConnection GetOpenConnection()
        {
            SQLiteConnection conn = null; // deklarasi objek connection

            try // penggunaan blok try-catch untuk penanganan error
            {
                // atur ulang lokasi database yang disesuaikan dengan
                // lokasi database perpustakaan Anda
                string dbName = @"C:\#KULIAH\SMT 3\Pemrog Lanjut\aplikasi kasir\iniDatabase\DbKasir.db";

                // deklarasi variabel connectionString, ref: https://www.connectionstrings.com/
                string connectionString = string.Format("Data Source ={0}; FailIfMissing = True", dbName);

                conn = new SQLiteConnection(connectionString); // buat objek connection

                conn.Open(); // buka koneksi ke database
            }
            // jika terjadi error di blok try, akan ditangani langsung oleh blok catch
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return conn;
        }
    }
}
