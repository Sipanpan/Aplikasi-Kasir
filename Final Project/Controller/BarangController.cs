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
    public class BarangController
    {
        // deklarasi objek repository untuk menjalankan operasi CRUD
        private BarangRepository _repository;

        public int Create(Barang brg)
        {
            int result = 0;

            // cek Nama yan diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(brg.Nama))
            {
                MessageBox.Show("Nama harus diisi !!!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // cek Jumlah yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(brg.Jumlah))
            {
                MessageBox.Show("Jumlah harus diisi !!!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // cek Harga yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(brg.Harga))
            {
                MessageBox.Show("Harga harus diisi !!!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _repository = new BarangRepository(context);

                // panggil method Create repository untuk menambahkan data
                result = _repository.Create(brg);
            }

            if (result > 0)
            {
                MessageBox.Show("Data barang berhasil disimpan !", "Informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data barang gagal disimpan !!!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return result;
        }

        public int Pesan(Barang brg, string fafa)
        {
            int result = 0;

            // cek Nama yan diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(brg.Nama))
            {
                MessageBox.Show("Nama harus diisi !!!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // cek Jumlah yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(brg.Jumlah))
            {
                MessageBox.Show("Jumlah harus diisi !!!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // cek Harga yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(brg.Harga))
            {
                MessageBox.Show("Harga harus diisi !!!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _repository = new BarangRepository(context);

                // panggil method Create repository untuk menambahkan data
                result = _repository.Pesan(brg, fafa);
            }

            if (result > 0)
            {
                MessageBox.Show("Data barang berhasil disimpan !", "Informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data barang gagal disimpan !!!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return result;
        }

        public int Update(Barang brg)
        {
            int result = 0;

            // cek Nama yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(brg.Nama))
            {
                MessageBox.Show("Nama harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // cek Jumlah yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(brg.Jumlah))
            {
                MessageBox.Show("Jumlah harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // cek angkatan yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(brg.Harga))
            {
                MessageBox.Show("Harga harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new BarangRepository(context);

                // panggil method Update class repository untuk mengupdate data
                result = _repository.Update(brg);
            }

            if (result > 0)
            {
                MessageBox.Show("Data barang berhasil diupdate !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data barang gagal diupdate !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            return result;
        }

        public int Delete(Barang brg)
        {
            int result = 0;

            // cek nilai Nama yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(brg.Nama))
            {
                MessageBox.Show("Nama harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new BarangRepository(context);

                // panggil method Delete class repository untuk menghapus data
                result = _repository.Delete(brg);
            }

            if (result > 0)
            {
                MessageBox.Show("Data barang berhasil dihapus !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data barang gagal dihapus !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return result;
        }

        public List<Barang> ReadByNama(string Nama)
        {
            // membuat objek collection
            List<Barang> list = new List<Barang>();

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new BarangRepository(context);

                // panggil method GetByNama yang ada di dalam class repository
                list = _repository.ReadByNama(Nama);
            }
            return list;
        }

        public List <Barang> ReadAll()
        {
            // membuat objek collection
            List<Barang> list = new List<Barang>();

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new BarangRepository(context);

                // panggil method GetAll yang ada di dalam class repository
                list = _repository.ReadAll();
            }
            return list;
        }

        public List<Barang> ReadTTL()
        {
            // membuat objek collection
            List<Barang> list = new List<Barang>();


            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new BarangRepository(context);

                // panggil method GetAll yang ada di dalam class repository
                // list = _repository.ReadTTL();
            }
            return list;
        }
    }
}
