using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Final_Project.Model.Entity;
using Final_Project.Controller;
using Bunifu.UI.WinForms;
using Final_Project.View;

namespace Final_Project
{
    public partial class formKeranjang : Form
    {
        // deklarasi collection untuk menampung objek barang
        private List<Barang> listOfBarang = new List<Barang>();

        // deklarasi objek controller
        private BarangController controller;

        // constructor
        public formKeranjang()
        {
            InitializeComponent();

            // membuat objek controller
            controller = new BarangController();

            LoadDataMahasiswa();
            InisialisasiListView();
        }

        // atur kolom list view
        private void InisialisasiListView()
        {
            lvwBarang.View = System.Windows.Forms.View.Details;
            lvwBarang.FullRowSelect = true;
            lvwBarang.GridLines = true;

            lvwBarang.Columns.Add("No.", 30, HorizontalAlignment.Center);
            lvwBarang.Columns.Add("Menu", 400, HorizontalAlignment.Left);
            lvwBarang.Columns.Add("Jumlah", 100, HorizontalAlignment.Center);
            lvwBarang.Columns.Add("Harga", 100, HorizontalAlignment.Center);
            lvwBarang.Columns.Add("Total", 200, HorizontalAlignment.Center);
        }

        // method untuk menampilkan semua data mahasiswa
        private void LoadDataMahasiswa()
        {
            // kosongkan listview
            lvwBarang.Items.Clear();

            // panggil method ReadAll dan tampung datanya ke dalam collection
            listOfBarang = controller.ReadAll();
            txtTotal.Text = controller.GetTotal().ToString();

            // ekstrak objek brg dari collection
            foreach (var brg in listOfBarang)
            {
                var noUrut = lvwBarang.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(brg.Nama);
                item.SubItems.Add(brg.Jumlah);
                item.SubItems.Add(brg.Harga);
                item.SubItems.Add(brg.Total.ToString());

                // tampilkan data brg ke listview
                lvwBarang.Items.Add(item);
            }
        }

        // method event handler untuk merespon event OnCreate
        private void OnCreateEventHandler(Barang brg)
        {
            // tambahkan objek brg yang baru ke dalam collection
            listOfBarang.Add(brg);

            int noUrut = lvwBarang.Items.Count + 1;

            // tampilkan data brg yang baru ke list view
            ListViewItem item = new ListViewItem(noUrut.ToString());
            item.SubItems.Add(brg.Nama);
            item.SubItems.Add(brg.Jumlah);
            item.SubItems.Add(brg.Harga);
            item.SubItems.Add(brg.Total.ToString());

            lvwBarang.Items.Add(item);
        }

        // method event handler untuk merespon even onUpdate
        private void OnUpdateEventHandler(Barang brg)
        {
            // ambil index data brg yang edit
            int index = lvwBarang.SelectedIndices[0];

            // update informasi brg di listview
            ListViewItem itemRow = lvwBarang.Items[index];
            itemRow.SubItems[1].Text = brg.Nama;
            itemRow.SubItems[2].Text = brg.Jumlah;
            itemRow.SubItems[3].Text = brg.Harga;
            itemRow.SubItems[4].Text = brg.Total.ToString();
        }
           
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lvwBarang.SelectedItems.Count > 0)
            {
                // ambil objek brg yang mau diedit dari collection
                Barang brg = listOfBarang[lvwBarang.SelectedIndices[0]];

                // buat objek form entry data barang
                formTambah frmTambah = new formTambah("Edit Data Barang", brg, controller);

                // mendaftarkan method event handler untuk merespon event OnUpdate
                frmTambah.OnUpdate += OnUpdateEventHandler;

                // tampilkan form tambah
                frmTambah.ShowDialog();
            }
            else // data belum dipilih
            {
                MessageBox.Show("Data belum dipilih", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (lvwBarang.SelectedItems.Count > 0)
            {
                var konfirmasi = MessageBox.Show("Apakah data barang ingin dihapus ?", "Konfirmasi",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (konfirmasi == DialogResult.Yes)
                {
                    // ambil objek brg yang mau dihapus dari collection
                    Barang brg = listOfBarang[lvwBarang.SelectedIndices[0]];

                    // panggil operasi CRUD
                    var result = controller.Delete(brg);
                    if (result > 0)
                    {
                        LoadDataMahasiswa();
                    }
                }

            }
            else // data belum dipilih
            {
                MessageBox.Show("Data barang belum dipilih !!!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnTampil_Click(object sender, EventArgs e)
        {
            btnTampil.Visible = false;
            frmPembayaran pembayaran = new frmPembayaran();
            pembayaran.FormClosed += FrmPembayaran_FormClosed;
            pembayaran.Show(); 
        }

        private void FrmPembayaran_FormClosed(object sender, FormClosedEventArgs e)
        {
            btnTampil.Visible = true;
        }

        private void formKeranjang_Load(object sender, EventArgs e)
        {

        }
    }
}
