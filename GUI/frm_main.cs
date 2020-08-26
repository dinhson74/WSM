using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOAN_QLBH_DinhThanhSon_2485.GUI
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_khachhang"] == null)
            {
                frm_khachhang khachhang = new frm_khachhang();
                khachhang.MdiParent = this;
                khachhang.Show();
            }
            else
            {
                Application.OpenForms["frm_khachhang"].Activate();

            }
        }

        private void nToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_nhanvien"] == null)
            {
                frm_nhanvien nhanvien = new frm_nhanvien();
                nhanvien.MdiParent = this;
                nhanvien.Show();
            }
            else
            {
                Application.OpenForms["frm_nhanvien"].Activate();

            }
        }

        private void hàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_hanghoa"] == null)
            {
                frm_hanghoa hanghoa = new frm_hanghoa();
                hanghoa.MdiParent = this;
                hanghoa.Show();
            }
            else
            {
                Application.OpenForms["frm_hanghoa"].Activate();

            }
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_nhacungcap"] == null)
            {
                frm_nhacungcap ncc = new frm_nhacungcap();
                ncc.MdiParent = this;
                ncc.Show();
            }
            else
            {
                Application.OpenForms["frm_nhacungcap"].Activate();

            }
        }

        private void bánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_hoadon"] == null)
            {
                frm_hoadon hoadon = new frm_hoadon();
                hoadon.MdiParent = this;
                hoadon.Show();
            }
            else
            {
                Application.OpenForms["frm_hoadon"].Activate();

            }
        }

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_thongke"] == null)
            {
                frm_thongke thongke = new frm_thongke();
                thongke.MdiParent = this;
                thongke.Show();
            }
            else
            {
                Application.OpenForms["frm_thongke"].Activate();

            }
        }
    }
}
