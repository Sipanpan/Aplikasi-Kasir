using Final_Project.Model.Context;
using Final_Project.Model.Entity;
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

namespace Final_Project.View
{
    public partial class formLupa : Form
    {
        Authentication auth;

        public formLupa()
        {
            InitializeComponent();
        }

        public void btnCariUser_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != string.Empty) // Validasi input
            {
                bool isUsernameExists = cekAkun(txtUsername.Text);
                
                if (isUsernameExists)
                {
                    // Jika username ditemukan, buka form reset password
                    DialogResult result = MessageBox.Show("Pengguna ditemukan! Lanjutkan ke form Atur Ulang Kata Sandi ?",
                                                          "Informasi", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                    if (result == DialogResult.OK)
                    {
                        // Pindah ke form reset password
                        this.Hide();
                        formReset rsp = new formReset();
                        rsp.ShowDialog();
                        this.Hide(); // Sembunyikan form saat ini
                    }
                }
                else
                {
                    // Jika username tidak ditemukan
                    MessageBox.Show("Pengguna tidak ditemukan. Silakan coba lagi.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Jika input kosong
                MessageBox.Show("Harap masukkan Nama !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool cekAkun(string username)
        {
            auth = new Authentication();
            auth.getConnection();

            using (SQLiteConnection con = new SQLiteConnection(auth.connectionString))
            {
                con.Open();

                string query = "select count(*) from user where username = @username";
                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@username", username);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0; // Jika count > 0, berarti username ditemukan
                }
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
