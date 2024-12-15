using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace Final_Project
{
    public partial class formMain : Form
    {
        formMakanan makanan;
        formMinuman minuman;
        formCemilan cemilan;
        formKeranjang keranjang;
        formAboutUs aboutUs;
        public formMain()
        {
            InitializeComponent();
        }

        bool sidebarExpand;
        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();

                    pnMakanan.Width = sidebar.Width;
                    pnMinuman.Width = sidebar.Width;
                    pnCemilan.Width = sidebar.Width;
                    pnKeranjang.Width = sidebar.Width;
                    pnAboutUs.Width = sidebar.Width;
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();

                    pnMakanan.Width = sidebar.Width;
                    pnMinuman.Width = sidebar.Width;
                    pnCemilan.Width = sidebar.Width;
                    pnKeranjang.Width = sidebar.Width;
                    pnAboutUs.Width = sidebar.Width;
                }
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            pnWelcome.Visible = true;
        }

        private void btnMakanan_Click(object sender, EventArgs e)
        {
            pnWelcome.Visible = false;
            if (makanan == null)
            {
                makanan = new formMakanan();
                makanan.FormClosed += makanan_FormClosed;
                makanan.MdiParent = this;
                makanan.Dock = DockStyle.Fill;
                makanan.Show();
            }
            else
            {
                makanan.Activate();
            }
        }

        private void makanan_FormClosed (object sender, FormClosedEventArgs e)
        {
            makanan = null;
        }

        private void btnMinuman_Click(object sender, EventArgs e)
        {
            pnWelcome.Visible = false;
            if (minuman == null)
            {
                minuman = new formMinuman();
                minuman.FormClosed += minuman_FormClosed;
                minuman.MdiParent = this;
                minuman.Dock = DockStyle.Fill;
                minuman.Show();
            }
            else
            {
                minuman.Activate();
            }
        }

        private void minuman_FormClosed(object sender, FormClosedEventArgs e)
        {
            minuman = null;
        }

        private void btnCemilan_Click(object sender, EventArgs e)
        {
            pnWelcome.Visible = false;
            if (cemilan == null)
            {
                cemilan = new formCemilan();
                cemilan.FormClosed += cemilan_FormClosed;
                cemilan.MdiParent = this;
                cemilan.Dock = DockStyle.Fill;
                cemilan.Show();
            }
            else
            {
                cemilan.Activate();
            }
        }

        private void cemilan_FormClosed(object sender, FormClosedEventArgs e)
        {
            cemilan = null;
        }

        private void btnAboutUs_Click(object sender, EventArgs e)
        {
            pnWelcome.Visible = false;
            if (aboutUs == null)
            {
                aboutUs = new formAboutUs();
                aboutUs.FormClosed += aboutUs_FormClosed;
                aboutUs.MdiParent = this;
                aboutUs.Dock = DockStyle.Fill;
                aboutUs.Show();
            }
            else
            {
                aboutUs.Activate();
            }
        }

        private void aboutUs_FormClosed(object sender, FormClosedEventArgs e)
        {
            aboutUs = null;
        }

        private void btnKeranjang_Click(object sender, EventArgs e)
        {
            pnWelcome.Visible = false;
            if (keranjang == null)
            {
                keranjang = new formKeranjang();
                keranjang.FormClosed += keranjang_FormClosed;
                keranjang.MdiParent = this;
                keranjang.Dock = DockStyle.Fill;
                keranjang.Show();
            }
            else
            {
                keranjang.Activate();
            }
        }

        private void keranjang_FormClosed(object sender, FormClosedEventArgs e)
        {
            keranjang = null;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void maximizeButton_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }

            else if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnTesKoneksi_Click(object sender, EventArgs e)
        {
            // membuat objek connection
            SQLiteConnection conn = GetOpenConnection();

            // cek status koneksi
            if (conn != null && conn.State == ConnectionState.Open) // koneksi berhasil
            {
                MessageBox.Show("Koneksi ke database berhasil !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Koneksi ke database gagal !!!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            conn?.Dispose(); // tutup dan hapus objek connection dari memory
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
        }
    }
}
