using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOAN_QLBH_DinhThanhSon_2485.BLL
{
    class BLL_hanghoa
    {
        DAL.DAL_hanghoa dAL_hh = new DAL.DAL_hanghoa();
        GUI.frm_hanghoa frm_hh;
        GUI.frm_hoadon frm_hoadon;
        GUI.frm_nhacungcap frm_ncc;
        public BLL_hanghoa(GUI.frm_hanghoa f)
        {
            frm_hh = f;
        }
        public BLL_hanghoa(GUI.frm_hoadon f)
        {
            frm_hoadon = f;
        }
        public BLL_hanghoa(GUI.frm_nhacungcap f)
        {
            frm_ncc = f;
        }
        public void themhh()
        {
            int ketqua = dAL_hh.themhang(frm_hh.txtMahang.Text, frm_hh.cb_ncc.SelectedValue.ToString(), frm_hh.txtTenhang.Text, frm_hh.txtSoluong.Text,frm_hh.txtDongianhap.Text,frm_hh.txtDongiaban.Text);
            if (ketqua >= 1) MessageBox.Show("Thêm thành công");
            else MessageBox.Show("Thêm thất bai");

        }
        public void suahh()
        {
            int ketqua = dAL_hh.suahang(frm_hh.txtMahang.Text, frm_hh.cb_ncc.SelectedValue.ToString(), frm_hh.txtTenhang.Text, frm_hh.txtSoluong.Text,frm_hh.txtDongianhap.Text, frm_hh.txtDongiaban.Text);
            if (ketqua >= 1) MessageBox.Show("Sửa thành công");
            else MessageBox.Show("Sửa thất bai");
        }
        public void xoahh()
        {
            int ketqua = dAL_hh.xoahang(frm_hh.txtMahang.Text);
            if (ketqua >= 1) MessageBox.Show("Xóa thành công");
            else MessageBox.Show("Xóa thất bai");
        }
        public void loadhh()
        {
            frm_hh.DTV_hh.DataSource = dAL_hh.loadhh();
        }
        public void LayDSHH()
        { 
                frm_hoadon.cb_mahang.DataSource = dAL_hh.loadhh();
                frm_hoadon.cb_mahang.DisplayMember = "MaH";
                frm_hoadon.cb_mahang.ValueMember = "MaH";
        }
        
       
    }
}

