using Final_Project.Model.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Final_Project.View
{
    public partial class formRegister : Form
    {
        Authentication auth;

        public formRegister()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != string.Empty && txtPassword.Text != string.Empty && txtConfirmPwd.Text != string.Empty)
            {
                if (txtPassword.Text == txtConfirmPwd.Text)
                {
                    cekAkun(txtUsername.Text);
                }
                else
                {
                    MessageBox.Show("Kata sandi tidak sama!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cekAkun(string username)
        {
            auth = new Authentication();

            auth.createDatabase();
            auth.getConnection();

            try
            {
                using (SQLiteConnection con = new SQLiteConnection(auth.connectionString))
                {
                    SQLiteCommand cmd = new SQLiteCommand();
                    con.Open();

                    int count = 0;
                    string query = @"select * from user where username = '" + username + "'";
                    cmd.CommandText = query;
                    cmd.Connection = con;

                    SQLiteDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        count++;
                    }
                    if (count == 1)
                    {
                        MessageBox.Show("Akun sudah pernah dibuat!", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return;
                    }
                    else if (count == 0)
                    {
                        insertData(txtUsername.Text, txtPassword.Text);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void insertData(string usernames, string password)
        {
            auth = new Authentication();
            auth.getConnection();

            try
            {

                using (SQLiteConnection con = new SQLiteConnection(auth.connectionString))
                {
                    con.Open();
                    SQLiteCommand cmd = new SQLiteCommand();
                    string query = @"insert into user (username, password) values(@username, @password)";
                    cmd.CommandText = query;
                    cmd.Connection = con;
                    cmd.Parameters.Add(new SQLiteParameter("@username", usernames));
                    cmd.Parameters.Add(new SQLiteParameter("@password", password));
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Berhasil membuat akun!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        }

        private void btnMasuk_Click(object sender, EventArgs e)
        {
            formLogin login = new formLogin();
            this.Hide();
            login.ShowDialog();
        }
    }
}
