using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Final_Project.Model.Entity;
using Final_Project.Model.Repository;
using Final_Project.Model.Context;
using System.Web.Management;

namespace Final_Project.Controller
{
    public class UserController
    {
        // deklarasi objek repository untuk menjalankan operasi CRUD
        private UserRepository _repository;

        public int Create(User usr)
        {
            int result = 0;

            // cek Nama yan diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(usr.UserName))
            {
                MessageBox.Show("Username harus diisi !!!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // cek Jumlah yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(usr.Password))
            {
                MessageBox.Show("Password harus diisi !!!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _repository = new UserRepository(context);

                // panggil method Create repository untuk menambahkan data
                // !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!result = _repository.Create(usr);
            }

            if (result > 0)
            {
                MessageBox.Show("Berhasil mendaftarkan user !", "Informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Gagal mendaftarkan user !!!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return result;
        }
    }
}
