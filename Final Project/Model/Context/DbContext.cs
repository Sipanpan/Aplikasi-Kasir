using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace Final_Project.Model.Context
{
    public class DbContext : IDisposable
    {
        // deklarasi private variabel / field
        private SQLiteConnection _conn;

        // deklarasi property conn (connection), untuk menyimpan objek koneksi
        public SQLiteConnection Conn
        {
            get { return _conn ?? (_conn = GetOpenConnection()); }
        }

        // method untuk melakukan koneksi ke database
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

        // method ini digunakan untuk menghapus objek koneksi dari memory ketika sudah tidak digunakan
        public void Dispose()
        {
            if (_conn != null)
            {
                try
                {
                    if (_conn.State != ConnectionState.Closed) _conn.Close();
                }
                finally
                {
                    _conn.Dispose();
                }
            }
            GC.SuppressFinalize(this);
        }
    }
}
