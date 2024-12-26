using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Final_Project.Model.Entity;
using Final_Project.Controller;
using Bunifu.UI.WinForms;

namespace Final_Project
{
    public partial class formKeranjang : Form
    {
        // deklarasi collection untuk menampung objek barang
        private List<Barang> listOfBarang = new List<Barang>();

        // deklarasi objek controller
        private BarangController controller;

        // constructor
        public formKeranjang()
        {
            InitializeComponent();

            // membuat objek controller
            controller = new BarangController();

            LoadDataMahasiswa();
            InisialisasiListView();
        }

        // atur kolom list view
        private void InisialisasiListView()
        {
            lvwBarang.View = System.Windows.Forms.View.Details;
            lvwBarang.FullRowSelect = true;
            lvwBarang.GridLines = true;

            lvwBarang.Columns.Add("No.", 30, HorizontalAlignment.Center);
            lvwBarang.Columns.Add("Menu", 400, HorizontalAlignment.Left);
            lvwBarang.Columns.Add("Jumlah", 100, HorizontalAlignment.Center);
            lvwBarang.Columns.Add("Harga", 100, HorizontalAlignment.Center);
            lvwBarang.Columns.Add("Total", 200, HorizontalAlignment.Center);
        }

        // method untuk menampilkan semua data mahasiswa
        private void LoadDataMahasiswa()
        {
            // kosongkan listview
            lvwBarang.Items.Clear();

            // panggil method ReadAll dan tampung datanya ke dalam collection
            listOfBarang = controller.ReadAll();

            // ekstrak objek brg dari collection
            foreach (var brg in listOfBarang)
            {
                var noUrut = lvwBarang.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(brg.Nama);
                item.SubItems.Add(brg.Jumlah);
                item.SubItems.Add(brg.Harga);
                item.SubItems.Add(brg.Total.ToString());

                //int a = item.SubItems[2];
                //txtTotal.Text = a.ToString();

                // tampilkan data brg ke listview
                lvwBarang.Items.Add(item);
                //txtTotal.Text += Int32.Parse(brg.Total.ToString());
            }
        }

        // method event handler untuk merespon event OnCreate
        private void OnCreateEventHandler(Barang brg)
        {
            // tambahkan objek brg yang baru ke dalam collection
            listOfBarang.Add(brg);

            int noUrut = lvwBarang.Items.Count + 1;

            // tampilkan data brg yang baru ke list view
            ListViewItem item = new ListViewItem(noUrut.ToString());
            item.SubItems.Add(brg.Nama);
            item.SubItems.Add(brg.Jumlah);
            item.SubItems.Add(brg.Harga);
            item.SubItems.Add(brg.Total.ToString());

            lvwBarang.Items.Add(item);
        }

        // method event handler untuk merespon even onUpdate
        private void OnUpdateEventHandler(Barang brg)
        {
            // ambil index data brg yang edit
            int index = lvwBarang.SelectedIndices[0];

            // update informasi brg di listview
            ListViewItem itemRow = lvwBarang.Items[index];
            itemRow.SubItems[1].Text = brg.Nama;
            itemRow.SubItems[2].Text = brg.Jumlah;
            itemRow.SubItems[3].Text = brg.Harga;
            itemRow.SubItems[4].Text = brg.Total.ToString();
        }
               
        /*
        // method event handler untuk merespon event OnCreate, ketika di panggil dari form tambah barang
        private void formTambah_OnCreate(Barang brg)
        {
            // tambahkan objek brg yang baru ke dalam collection
            listOfBarang.Add(brg);

            int noUrut = lvwBarang.Items.Count + 1;

            // tampilkan data brg yg baru ke list view
            ListViewItem item = new ListViewItem(noUrut.ToString());
            item.SubItems.Add(brg.Nama);
            item.SubItems.Add(brg.Jumlah);
            item.SubItems.Add(brg.Harga);
            item.SubItems.Add(brg.Total.ToString());

            lvwBarang.Items.Add(item);
        }

        // method event handler untuk merespon event OnUpdate, ketika di panggil dari form entry mahasiswa
        private void formTambah_OnUpdate(Barang brg)
        {
            // ambil baris data brg yang edit
            int row = lvwBarang.SelectedIndices[0];
            // update informasi brg di listview
            ListViewItem itemRow = lvwBarang.Items[row];
            itemRow.SubItems[1].Text = brg.Nama;
            itemRow.SubItems[2].Text = brg.Jumlah;
            itemRow.SubItems[3].Text = brg.Harga;
            itemRow.SubItems[4].Text = brg.Total.ToString();
        }*/

        /*private void btnTambah_Click(object sender, EventArgs e)
        {
            // buat objek form entry data barang
            formTambah frmTambah = new formTambah("Tambah Data Barang", controller);

            // mendaftarkan method event handler utk merespon event OnCreate
            frmTambah.OnCreate += OnCreateEventHandler;

            // tampilkan form tambah
            frmTambah.ShowDialog();
        }*/

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lvwBarang.SelectedItems.Count > 0)
            {
                // ambil objek brg yang mau diedit dari collection
                Barang brg = listOfBarang[lvwBarang.SelectedIndices[0]];

                // buat objek form entry data barang
                formTambah frmTambah = new formTambah("Edit Data Barang", brg, controller);

                // mendaftarkan method event handler untuk merespon event OnUpdate
                frmTambah.OnUpdate += OnUpdateEventHandler;

                // tampilkan form tambah
                frmTambah.ShowDialog();
            }
            else // data belum dipilih
            {
                MessageBox.Show("Data belum dipilih", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        /*
                int selectedIndex = lvwBarang.SelectedIndices[0];
                Console.WriteLine("==================================");  
                Console.WriteLine(selectedIndex.ToString());
                Console.WriteLine(listOfBarang.ToString());  
                // Memastikan indeks yang dipilih valid
                if (selectedIndex == 1 )//&& selectedIndex < listOfBarang.Count)
                {
                    Console.WriteLine("ini list of barang");
                    Console.WriteLine(listOfBarang);
                    Console.WriteLine("ini list of barang count");
                    Console.WriteLine(listOfBarang.Count);
                    Console.WriteLine(listOfBarang);
                    // Ambil objek brg yang mau diedit dari koleksi
                    Barang brg = listOfBarang[selectedIndex];
                    //Barang brg = listOfBarang[selectedIndex];

                    if (brg != null) // Pastikan objek tidak null
                    {
                        // Buat objek form entry data barang
                        using (formTambah frmTambah = new formTambah("Edit Data Barang", brg))
                        {
                            // Mendaftarkan method event handler untuk merespon event OnUpdate (subscribe)
                            frmTambah.OnUpdate += formTambah_OnUpdate;

                            // Tampilkan form entry barang
                            frmTambah.ShowDialog();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Data barang tidak ditemukan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Indeks yang dipilih tidak valid.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else // Data belum dipilih
            {
                MessageBox.Show("Data belum dipilih", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }*/

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (lvwBarang.SelectedItems.Count > 0)
            {
                var konfirmasi = MessageBox.Show("Apakah data barang ingin dihapus ?", "Konfirmasi",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (konfirmasi == DialogResult.Yes)
                {
                    // ambil objek brg yang mau dihapus dari collection
                    Barang brg = listOfBarang[lvwBarang.SelectedIndices[0]];

                    // panggil operasi CRUD
                    var result = controller.Delete(brg);
                    if (result > 0)
                    {
                        LoadDataMahasiswa();
                    }
                }

            }
            else // data belum dipilih
            {
                MessageBox.Show("Data barang belum dipilih !!!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        /*
            // ambil objek brg yang mau dihapus dari collection
            Barang obj = listOfBarang[lvwBarang.SelectedIndices[0]];

            string msg = string.Format("Apakah data barang '{0}' ingin dihapus ? ", obj.Nama);

            if (MessageBox.Show(msg, "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                // hapus objek barang dari collection
                listOfBarang.Remove(obj);

                lvwBarang.Items.Clear();

                // refresh data brg yang ditampilkan ke listview
                foreach (Barang brg in listOfBarang)
                {
                    int noUrut = lvwBarang.Items.Count + 1;

                    ListViewItem item = new ListViewItem(noUrut.ToString());
                    item.SubItems.Add(brg.Nama);
                    item.SubItems.Add(brg.Jumlah);
                    item.SubItems.Add(brg.Harga);
                    item.SubItems.Add(brg.Total.ToString());

                    lvwBarang.Items.Add(item);
                }
            }
        }
        else // data belum dipilih
        {
            MessageBox.Show("Data belum dipilih", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }*/

        /*
        private void btnTampil_Click(object sender, EventArgs e)
        {
            lvwBarang.Items.Clear();
            // membuat objek Connection, sekaligus buka koneksi ke database
            SQLiteConnection conn = GetOpenConnection();

            // deklarasi variabel sql untuk menampung perintah SELECT
            string sql = @"select Nama, Jumlah, Harga, Total from barang order by nama";

            // membuat objek Command untuk mengeksekusi perintah SQL
            SQLiteCommand cmd = new SQLiteCommand(sql, conn);

            // membuat objek DataReader untuk menampung hasil perintah SELECT
            SQLiteDataReader dtr = cmd.ExecuteReader(); // eksekusi perintah SELECT

            while (dtr.Read()) // gunakan perulangan utk menampilkan data ke listview
{
                var noUrut = lvwBarang.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(dtr["Nama"].ToString());
                item.SubItems.Add(dtr["Jumlah"].ToString());
                item.SubItems.Add(dtr["Harga"].ToString());
                item.SubItems.Add(dtr["Total"].ToString());

                lvwBarang.Items.Add(item);
            }
            // setelah selesai digunakan,
            // segera hapus objek datareader, command dan connection dari memory
            dtr.Dispose();
            cmd.Dispose();
            conn.Dispose();
        }

        private SQLiteConnection GetOpenConnection()
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
