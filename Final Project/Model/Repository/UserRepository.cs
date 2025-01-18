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

namespace Final_Project.Model.Repository
{
    public class UserRepository
    {
        // deklarasi objek connection
        private SQLiteConnection _conn;

        // constructor
        public UserRepository(DbContext context)
        {
            // inisialisasi objek connection
            _conn = context.Conn;
        }

        /*public string cekAkun(string username)
        {
            string result;

            // deklarasi perintah sql
            string sql = @"select * from user where username = '" + username + "'";

            // membuat objek command menggunakan blok using
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {

                try
                {
                    // jalankan perintah insert dan tampung hasilnya ke dalam variabel result
                    result = cmd.ExecuteReader();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Create error : {0}", ex.Message);
                }
            }
            return result;
        }*/
    }
}
