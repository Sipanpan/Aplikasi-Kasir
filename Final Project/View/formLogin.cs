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
    public partial class formLogin : Form
    {
        formRegister register;
        Authentication auth;

        public formLogin()
        {
            InitializeComponent();
        }

        public string usernames;

        private void btnRegister_Click(object sender, EventArgs e)
        {
            register = new formRegister();
            this.Hide();
            register.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != string.Empty && txtPassword.Text != string.Empty)
            {
                cekAkun(txtUsername.Text, txtPassword.Text);
            }
        }

        private void cekAkun(string username, string password)
        {
            auth = new Authentication();
            auth.getConnection();

            try
            {
                using (SQLiteConnection con = new SQLiteConnection(auth.connectionString))
                {
                    con.Open();
                    SQLiteCommand cmd = new SQLiteCommand();

                    string query = @"select * from user where username = '" + username + "' and password = '" + password + "'";

                    int count = 0;
                    cmd.CommandText = query;
                    cmd.Connection = con;

                    SQLiteDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        count++;
                    }
                    if (count == 1)
                    {
                        MessageBox.Show("Berhasil Masuk !", "Sukses", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        usernames = username;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Nama atau Kata sandi salah!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLupaPwd_Click(object sender, EventArgs e)
        {
            formLupa lupa = new formLupa();
            this.Hide();
            lupa.ShowDialog();
        }
    }
}
