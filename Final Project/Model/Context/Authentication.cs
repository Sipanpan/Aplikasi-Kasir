using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SQLite;

namespace Final_Project.Model.Context
{
    public class Authentication
    {
        public string connectionString { get; set; }
        string connection;

        public void getConnection()
        {
            connection = @"Data Source=DbKasir.db; Version=3";
            connectionString = connection;
        }

        public void createDatabase()
        {
            if (!File.Exists("DbKasir.db"))
            {
                try
                {
                    File.Create("DbKasir.db");

                    createTabel();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                createTabel();
            }
        }

        private void createTabel()
        {
            try
            {
                getConnection();
                using (SQLiteConnection con = new SQLiteConnection(connection))
                {
                    con.Open();
                    SQLiteCommand cmd = new SQLiteCommand();

                    string query = @"create table user (id integer primary key autoincrement, username text(25), password text(25))";
                    cmd.CommandText = query;
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
