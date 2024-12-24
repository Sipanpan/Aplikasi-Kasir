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
        public formTambah(string title, BarangController controller, string nama, string harga) : this()
        {
            lblJudul.Text = nama;
            // ganti text/judul form
            this.Text = title;
            this.Controller = controller;

            Barang brg = new Barang();

            brg.Nama = nama;
            brg.Harga = harga;
            txtNama.Text = brg.Nama;
            txtHarga.Text = brg.Harga;
        }

        /*
            // membuat objek Connection, sekaligus buka koneksi ke database
            SQLiteConnection conn = GetOpenConnection();

            // deklarasi variabel sql untuk menampung perintah INSERT
            string sql = @"select nama, harga from makanan where nama = @nama";

            // membuat objek Command untuk mengeksekusi perintah SQL
            using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
            {
                // Menambahkan parameter untuk mencegah SQL injection
                cmd.Parameters.AddWithValue("@nama", mkn);

                // Membuat objek datareader untuk menampung hasil perintah select
                using (SQLiteDataReader dtr = cmd.ExecuteReader()) // Eksekusi perintah select
                {
                    if (dtr.Read())
                    {
                        txtNama.Text = dtr["nama"].ToString();
                        txtHarga.Text = dtr["harga"].ToString();
                    }
                    else
                    {
                        // Menangani kasus ketika tidak ada data ditemukan, jika perlu
                        txtNama.Text = string.Empty;
                        txtHarga.Text = string.Empty;
                    }
                }
            }
        }*/

        // Constructor untuk inisialisasi data ketika mengedit data
        public formTambah(string title, Barang obj, BarangController controller) : this()
        {
            // ganti text/judul form
            this.Text = title;
            this.Controller = controller;

            isNewData = false; // set status edit data
            brg = obj; // set objek brg yang akan diedit

            // untuk edit data, tampilkan data lama
            txtNama.Text = brg.Nama;
            txtJumlah.Text = brg.Jumlah;
            txtHarga.Text = brg.Harga;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            // jika data baru, inisisalisasi objek barang
            if (isNewData) brg = new Barang();

            // set nilai property objek barang yang diambil dari textbox
            brg.Nama = txtNama.Text;
            brg.Jumlah = txtJumlah.Text;
            brg.Harga = txtHarga.Text;
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
                    txtNama.Clear();
                    txtJumlah.Clear();
                    txtHarga.Clear();

                    txtNama.Focus();
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

            /*
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
            var sql = @"insert into barang (Nama, Jumlah, Harga, Total) values (@Nama, @Jumlah, @Harga, @Total)";

            // membuat objek Command untuk mengeksekusi perintah SQL
            SQLiteCommand cmd = new SQLiteCommand(sql, conn);

            try
            {
                // set parameter untuk Nama, Jumlah dan Harga
                cmd.Parameters.AddWithValue("@Nama", txtNama.Text);
                cmd.Parameters.AddWithValue("@Jumlah", txtJumlah.Text);
                cmd.Parameters.AddWithValue("@Harga", txtHarga.Text);
                cmd.Parameters.AddWithValue("@Total", Int32.Parse(txtJumlah.Text) * Int32.Parse(txtHarga.Text));

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
                MessageBox.Show("Pesanan telah ditambahkan di keranjang", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                // reset form
                txtNama.Clear();
                txtJumlah.Clear();
                txtHarga.Clear();
                txtNama.Focus();
            }
            else
                MessageBox.Show("Menu gagal ditambahkan!!!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            
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

        /* private SQLiteConnection GetOpenConnection()
        {
            SQLiteConnection conn = null; // deklarasi objek connection

            try // penggunaan blok try-catch untuk penanganan error
            {
                // Lokasi file database relatif terhadap folder aplikasi
                string dbName = @"DbKasir.db"; // Nama file database
                string basePath = AppDomain.CurrentDomain.BaseDirectory; // Lokasi aplikasi berjalan
                string fullPath = Path.Combine(basePath, dbName); // Gabungkan jalur relatif

                // Buat database jika belum ada
                CreateDatabaseIfNotExists(fullPath);

                // Deklarasi variabel connectionString
                string connectionString = $"Data Source={fullPath};Version=3;FailIfMissing=True";

                // Buat objek connection
                conn = new SQLiteConnection(connectionString);
                conn.Open(); // Buka koneksi ke database
            }
            // jika terjadi error di blok try, akan ditangani langsung oleh blok catch
            catch (Exception ex)
            {
                // Tampilkan pesan error jika terjadi kesalahan
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return conn;
        }

        private void CreateDatabaseIfNotExists(string fullPath)
        {
            try
            {
                if (!File.Exists(fullPath))
                {
                    // Buat file database baru jika belum ada
                    SQLiteConnection.CreateFile(fullPath);
                    MessageBox.Show($"Database baru dibuat di: {fullPath}", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal membuat database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }*/
    }
}
