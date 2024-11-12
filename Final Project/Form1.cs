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
    public partial class Form1 : Form
    {
        formMakanan makanan;
        formMinuman minuman;
        formCemilan cemilan;
        formAboutUs aboutUs;
        public Form1()
        {
            InitializeComponent();
        }

        bool sidebarExpand;
        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();

                    pnMakanan.Width = sidebar.Width;
                    pnMinuman.Width = sidebar.Width;
                    pnCemilan.Width = sidebar.Width;
                    pnAboutUs.Width = sidebar.Width;
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();

                    pnMakanan.Width = sidebar.Width;
                    pnMinuman.Width = sidebar.Width;
                    pnCemilan.Width = sidebar.Width;
                    pnAboutUs.Width = sidebar.Width;
                }
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void btnMakanan_Click(object sender, EventArgs e)
        {
            if (makanan == null)
            {
                makanan = new formMakanan();
                makanan.FormClosed += makanan_FormClosed;
                makanan.MdiParent = this;
                makanan.Dock = DockStyle.Fill;
                makanan.Show();
            }
            else
            {
                makanan.Activate();
            }
        }

        private void makanan_FormClosed (object sender, FormClosedEventArgs e)
        {
            makanan = null;
        }

        private void btnMinuman_Click(object sender, EventArgs e)
        {
            if (minuman == null)
            {
                minuman = new formMinuman();
                minuman.FormClosed += minuman_FormClosed;
                minuman.MdiParent = this;
                minuman.Dock = DockStyle.Fill;
                minuman.Show();
            }
            else
            {
                minuman.Activate();
            }
        }

        private void minuman_FormClosed(object sender, FormClosedEventArgs e)
        {
            minuman = null;
        }

        private void btnCemilan_Click(object sender, EventArgs e)
        {
            if (cemilan == null)
            {
                cemilan = new formCemilan();
                cemilan.FormClosed += cemilan_FormClosed;
                cemilan.MdiParent = this;
                cemilan.Dock = DockStyle.Fill;
                cemilan.Show();
            }
            else
            {
                cemilan.Activate();
            }
        }

        private void cemilan_FormClosed(object sender, FormClosedEventArgs e)
        {
            cemilan = null;
        }

        private void btnAboutUs_Click(object sender, EventArgs e)
        {
            if (aboutUs == null)
            {
                aboutUs = new formAboutUs();
                aboutUs.FormClosed += aboutUs_FormClosed;
                aboutUs.MdiParent = this;
                aboutUs.Dock = DockStyle.Fill;
                aboutUs.Show();
            }
            else
            {
                aboutUs.Activate();
            }
        }

        private void aboutUs_FormClosed(object sender, FormClosedEventArgs e)
        {
            aboutUs = null;
        }
    }
}
