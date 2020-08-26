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
    public partial class frm_nhanvien : Form
    {
        BLL.BLL_nhanvien bll_nv;
        public frm_nhanvien()
        {
            InitializeComponent();
            bll_nv = new BLL.BLL_nhanvien(this);
        }

        private void frm_nhanvien_Load(object sender, EventArgs e)
        {
            bll_nv.loadnv();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            bll_nv.luunv();
            bll_nv.loadnv();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            bll_nv.xoanv();
            bll_nv.loadnv();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            bll_nv.suanv();
            bll_nv.loadnv();

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DTV_nhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_mnv.Text = DTV_nhanvien.CurrentRow.Cells[0].Value.ToString();
            txt_tennv.Text = DTV_nhanvien.CurrentRow.Cells[1].Value.ToString();
            dt_namsinh.Text = DTV_nhanvien.CurrentRow.Cells[2].Value.ToString();
            txt_gioitinh.Text = DTV_nhanvien.CurrentRow.Cells[3].Value.ToString();
            txt_diachi.Text = DTV_nhanvien.CurrentRow.Cells[4].Value.ToString();
            txt_sdt.Text = DTV_nhanvien.CurrentRow.Cells[5].Value.ToString();

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
