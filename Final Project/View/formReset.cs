using Final_Project.Model.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Final_Project.View;
using Final_Project.Model.Entity;

namespace Final_Project.View
{
    public partial class formReset : Form
    {
        Authentication auth;

        public formReset()
        {
            InitializeComponent();
        }

        private void cekAkun(string username)
        {
            auth = new Authentication();
            auth.getConnection();

            try
            {
                using (SQLiteConnection con = new SQLiteConnection(auth.connectionString))
                {
                    con.Open();
                    string query = "select count(*) from user where username = @username";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        if (count == 0)
                        {
                            MessageBox.Show("Akun dengan Nama ini tidak ditemukan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            // If account exists, reset the password
                            updatePassword(username, txtPasswordBaru.Text);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updatePassword(string username, string passwordBaru)
        {
            auth = new Authentication();
            auth.getConnection();

            try
            {
                using (SQLiteConnection con = new SQLiteConnection(auth.connectionString))
                {
                    con.Open();
                    string query = "update user set password = @passwordBaru where username = @username";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@passwordBaru", passwordBaru);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Display success message
                            MessageBox.Show("Kata Sandi berhasil diubah!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Close form and redirect to login
                            this.Hide();
                            formLogin login = new formLogin();
                            login.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Gagal mengubah Kata Sandi, coba lagi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan saat memperbarui Kata Sandi: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSetelUlang_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != string.Empty && txtPasswordBaru.Text != string.Empty && txtConfirmPwdBaru.Text != string.Empty)
            {
                // Check if new password and confirm password match
                if (txtPasswordBaru.Text == txtConfirmPwdBaru.Text)
                {
                    // Call method to check account and reset password
                    cekAkun(txtUsername.Text);
                }
                else
                {
                    MessageBox.Show("Kata Sandi Baru Tidak Sama!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Harap isi semua kolom!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
