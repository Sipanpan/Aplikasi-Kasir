using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class formKeranjang : Form
    {
        // deklarasi collection untuk menampung objek barang
        private IList<Barang> listOfBarang = new List<Barang>();

        // constructor
        public formKeranjang()
        {
            InitializeComponent();
            InisialisasiListView();
        }

        // atur kolom list view
        private void InisialisasiListView()
        {
            lvwBarang.View = View.Details;
            lvwBarang.FullRowSelect = true;
            lvwBarang.GridLines = true;

            lvwBarang.Columns.Add("No.", 30, HorizontalAlignment.Center);
            lvwBarang.Columns.Add("Menu", 400, HorizontalAlignment.Left);
            lvwBarang.Columns.Add("Jumlah", 100, HorizontalAlignment.Center);
            lvwBarang.Columns.Add("Harga", 100, HorizontalAlignment.Center);
            lvwBarang.Columns.Add("Total", 200, HorizontalAlignment.Center);
        }

        // method event handler untuk merespon event OnCreate, ketika di panggil dari form tambah barang
        private void formTambah_OnCreate(Barang brg)
        {
            // tambahkan objek brg yang baru ke dalam collection
            listOfBarang.Add(brg);

            int noUrut = lvwBarang.Items.Count + 1;

            // tampilkan data brg yg baru ke list view
            ListViewItem item = new ListViewItem(noUrut.ToString());
            item.SubItems.Add(brg.Nama);
            item.SubItems.Add(brg.Jumlah);
            item.SubItems.Add(brg.Harga);
            item.SubItems.Add(brg.Total.ToString());

            lvwBarang.Items.Add(item);
        }

        // method event handler untuk merespon event OnUpdate, ketika di panggil dari form entry mahasiswa
        private void formTambah_OnUpdate(Barang brg)
        {
            // ambil baris data brg yang edit
            int row = lvwBarang.SelectedIndices[0];
            // update informasi brg di listview
            ListViewItem itemRow = lvwBarang.Items[row];
            itemRow.SubItems[1].Text = brg.Nama;
            itemRow.SubItems[2].Text = brg.Jumlah;
            itemRow.SubItems[3].Text = brg.Harga;
            itemRow.SubItems[4].Text = brg.Total.ToString();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            // buat objek form entry data barang
            formTambah frmTambah = new formTambah("Tambah Data Barang");

            // mendaftarkan method event handler utk merespon event OnCreate (subscribe)
            frmTambah.OnCreate += formTambah_OnCreate;

            // tampilkan form entry barang
            frmTambah.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lvwBarang.SelectedItems.Count > 0)
            {
                // ambil objek brg yang mau diedit dari collection
                Barang brg = listOfBarang[lvwBarang.SelectedIndices[0]];

                // buat objek form entry data barang
                formTambah frmTambah = new formTambah("Edit Data barang", brg);

                // mendaftarkan method event handler utk merespon event OnUpdate (subscribe)
                frmTambah.OnUpdate += formTambah_OnUpdate;

                // tampilkan form entry barang
                frmTambah.ShowDialog();
            }
            else // data belum dipilih
            {
                MessageBox.Show("Data belum dipilih", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (lvwBarang.SelectedItems.Count > 0)
            {
                // ambil objek brg yang mau dihapus dari collection
                Barang obj = listOfBarang[lvwBarang.SelectedIndices[0]];

                string msg = string.Format("Apakah data barang '{0}' ingin dihapus ? ", obj.Nama);
                
                if (MessageBox.Show(msg, "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    // hapus objek barang dari collection
                    listOfBarang.Remove(obj);

                    lvwBarang.Items.Clear();

                    // refresh data brg yang ditampilkan ke listview
                    foreach (Barang brg in listOfBarang)
                    {
                        int noUrut = lvwBarang.Items.Count + 1;

                        ListViewItem item = new ListViewItem(noUrut.ToString());
                        item.SubItems.Add(brg.Nama);
                        item.SubItems.Add(brg.Jumlah);
                        item.SubItems.Add(brg.Harga);
                        item.SubItems.Add(brg.Total.ToString());

                        lvwBarang.Items.Add(item);
                    }
                }
            }
            else // data belum dipilih
            {
                MessageBox.Show("Data belum dipilih", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
