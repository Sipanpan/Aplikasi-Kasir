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
        public formKeranjang()
        {
            InitializeComponent();
            InisialisasiListView();
        }

        private void InisialisasiListView()
        {
            lvwBelanja.View = View.Details;
            lvwBelanja.FullRowSelect = true;
            lvwBelanja.GridLines = true;

            lvwBelanja.Columns.Add("No.", 30, HorizontalAlignment.Center);
            lvwBelanja.Columns.Add("Menu", 400, HorizontalAlignment.Center);
            lvwBelanja.Columns.Add("Jumlah", 100, HorizontalAlignment.Left);
            lvwBelanja.Columns.Add("Harga", 100, HorizontalAlignment.Center);
            lvwBelanja.Columns.Add("Total", 200, HorizontalAlignment.Center);
        }
    }
}
