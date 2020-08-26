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
    public partial class frm_khachhang : Form
    {   BLL.BLL_khachhang bllkh;
        public frm_khachhang()
        {
            InitializeComponent();
            bllkh = new BLL.BLL_khachhang(this);
           
        }

     
        private void frm_khachhang_Load(object sender, EventArgs e)
        {
            bllkh.loadkh();
        }

  
        private void btnSua_Click(object sender, EventArgs e)
        {
            bllkh.suakh();
            bllkh.loadkh();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            bllkh.luukh();
            bllkh.loadkh();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            bllkh.xoakh();
            bllkh.loadkh();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void DTV_khachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_makh.Text = DTV_khachhang.CurrentRow.Cells[0].Value.ToString();
            txt_tenkh.Text = DTV_khachhang.CurrentRow.Cells[1].Value.ToString();
            dt_namsinh.Text = DTV_khachhang.CurrentRow.Cells[2].Value.ToString();
            txt_gioitinh.Text = DTV_khachhang.CurrentRow.Cells[3].Value.ToString();
            txt_diachi.Text = DTV_khachhang.CurrentRow.Cells[4].Value.ToString();
            txt_sdt.Text = DTV_khachhang.CurrentRow.Cells[5].Value.ToString();
        }

        private void txt_makh_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_gioitinh_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_diachi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_tenkh_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_sdt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
