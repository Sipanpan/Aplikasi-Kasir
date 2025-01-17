using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using Final_Project.Model.Entity;
using Final_Project.Model.Context;
using System.Threading;
using System.Data.SqlClient;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Final_Project.Model.Repository
{
    public class BarangRepository
    {
        // deklarasi objek connection
        private SQLiteConnection _conn;

        // constructor
        public BarangRepository(DbContext context)
        {
            // inisialisasi objek connection
            _conn = context.Conn;
        }

        public int Create(Barang brg)
        {
            int result = 0;

            // deklarasi perintah sql
            string sql = @"insert into barang (Nama, Jumlah, Harga, Total)
                            values (@Nama, @Jumlah, @Harga, @Total)";

            // membuat objek command menggunakan blok using
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@Nama", brg.Nama);
                cmd.Parameters.AddWithValue("@Jumlah", brg.Jumlah);
                cmd.Parameters.AddWithValue("@Harga", brg.Harga);
                cmd.Parameters.AddWithValue("@Total", Int32.Parse(brg.Jumlah) * Int32.Parse(brg.Harga));

                try
                {
                    // jalankan perintah insert dan tampung hasilnya ke dalam variabel result
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Create error : {0}", ex.Message);
                }
            }
            return result;
        }

        public decimal GetTotal()
        {
            decimal Total = 0;

            // Query SQL untuk menghitung jumlah total
            string sql = @"SELECT SUM(Total) FROM barang";

            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                try
                {
                    object result = cmd.ExecuteScalar();

                    // Jika hasilnya tidak null, konversi ke decimal
                    if (result != DBNull.Value)
                    {
                        Total = Convert.ToDecimal(result);
                    }
                }
                catch (Exception ex)
                {
                    // Tangani exception sesuai kebutuhan
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            return Total;
        }

        public int Update(Barang brg)
        {
            int result = 0;

            // deklarasi perintah SQL
            string sql = @"update barang set Jumlah = @Jumlah, Harga = @Harga, Total = @Total
                           where Nama = @Nama";

            // membuat objek command menggunakan blok using
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@Nama", brg.Nama);
                cmd.Parameters.AddWithValue("@Jumlah", brg.Jumlah);
                cmd.Parameters.AddWithValue("@Harga", brg.Harga);
                cmd.Parameters.AddWithValue("@Total", brg.Total);

                try
                {
                    // jalankan perintah UPDATE dan tampung hasilnya ke dalam variabel result
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Update error: {0}", ex.Message);
                }
            }
            return result;
        }

        public int Pesan(Barang brg, string tabel, string kolom)
        {
            int result = 0;

            try
            {
                SQLiteDataReader reader = null;

                // deklarasi perintah SQL
                string sql = @"SELECT harga from " + tabel + " where nama = '" + kolom + "'";

                //string sql = @"update barang set Jumlah = @Jumlah, Total = @Total
                //where Nama = @Nama";

                // membuat objek command menggunakan blok using
                using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
                {
                    cmd.ExecuteNonQuery();
                    reader = cmd.ExecuteReader();

                    if(reader.Read())
                    {
                        result = reader.GetInt32(0);
                    }
                    else
                    {
                        result = 1;
                    }

                    // jalankan perintah UPDATE dan tampung hasilnya ke dalam variabel result
                    // result = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("Pesan error: {0}", ex.Message);
            }

            return result;
        }

        public int Delete(Barang brg)
        {
            int result = 0;

            // deklarasi perintah SQL
            string sql = @"delete from barang
                           where Nama = @Nama";

            // membuat objek command menggunakan blok using
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@Nama", brg.Nama);

                try
                {
                    // jalankan perintah DELETE dan tampung hasilnya ke dalam variabel result
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Delete error: {0}", ex.Message);
                }
            }
            return result;
        }

        public List<Barang> ReadAll()
        {
            // membuat objek collection untuk menampung objek barang
            List<Barang> list = new List<Barang>();

            try
            {
                // deklarasi perintah SQL
                string sql = @"select Nama, Jumlah, Harga, Total 
                               from barang 
                               order by Nama";

                // membuat objek command menggunakan blok using
                using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
                {
                    // membuat objek dtr (data reader) untuk menampung result set (hasil perintah SELECT)
                    using (SQLiteDataReader dtr = cmd.ExecuteReader())
                    {
                        // panggil method Read untuk mendapatkan baris dari result set
                        while (dtr.Read())
                        {
                            // proses konversi dari row result set ke object
                            Barang brg = new Barang();
                            brg. Nama = dtr["Nama"].ToString();
                            brg.Jumlah = dtr["Jumlah"].ToString();
                            brg. Harga = dtr["Harga"].ToString();
                            brg.Total = Int32.Parse(brg.Jumlah) * Int32.Parse(brg.Harga);

                            // tambahkan objek mahasiswa ke dalam collection
                            list.Add(brg);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadAll error: {0}", ex.Message);
            }

            return list;
        }

        // Method untuk menampilkan data barang berdasarkan pencarian nama
        public List<Barang> ReadByNama(string Nama)
        {
            // membuat objek collection untuk menampung objek barang
            List<Barang> list = new List<Barang>();

            try
            {
                // deklarasi perintah SQL
                string sql = @"select Nama, Jumlah, Harga, Total 
                               from barang 
                               where Nama like @Nama
                               order by Nama";

                // membuat objek command menggunakan blok using
                using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
                {
                    // mendaftarkan parameter dan mengeset nilainya
                    cmd.Parameters.AddWithValue("@Nama", string.Format("%{0}%", Nama));

                    // membuat objek dtr (data reader) untuk menampung result set (hasil perintah SELECT)
                    using (SQLiteDataReader dtr = cmd.ExecuteReader())
                    {
                        // panggil method Read untuk mendapatkan baris dari result set
                        while (dtr.Read())
                        {
                            // proses konversi dari row result set ke object
                            Barang brg = new Barang();
                            brg.Nama = dtr["Nama"].ToString();
                            brg.Jumlah = dtr["Jumlah"].ToString();
                            brg.Harga = dtr["Harga"].ToString();
                            brg.Total = Int32.Parse(brg.Jumlah) * Int32.Parse(brg.Harga);

                            // tambahkan objek mahasiswa ke dalam collection
                            list.Add(brg);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadByNama error: {0}", ex.Message);
            }

            return list;
        }
    }
}
