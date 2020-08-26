using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOAN_QLBH_DinhThanhSon_2485.BLL
{
    class BLL_nhacungcap
    {

        DAL.DAL_nhacungcap dal_nhacungcap = new DAL.DAL_nhacungcap();
        GUI.frm_nhacungcap frm_nhacungcap;
        GUI.frm_hanghoa frm_hanghoa;
        public BLL_nhacungcap(GUI.frm_hanghoa f)
        {
            frm_hanghoa = f;
           
        }
        public BLL_nhacungcap(GUI.frm_nhacungcap f)
        {
            frm_nhacungcap = f;

        }
      
        public void themncc()
        {
            int ketqua = dal_nhacungcap.themncc(frm_nhacungcap.txt_mancc.Text, frm_nhacungcap.txt_tenncc.Text);
            if (ketqua >= 1) MessageBox.Show("Thêm thành công");
            else MessageBox.Show("Thêm thất bai");

        }
        public void suancc()
        {
            int ketqua = dal_nhacungcap.suancc(frm_nhacungcap.txt_mancc.Text, frm_nhacungcap.txt_tenncc.Text);
            if (ketqua >= 1) MessageBox.Show("Sửa thành công");
            else MessageBox.Show("Sửa thất bai");
        }
        public void xoancc()
        {
            int ketqua = dal_nhacungcap.xoancc(frm_nhacungcap.txt_mancc.Text);
            if (ketqua >= 1) MessageBox.Show("Xóa thành công");
            else MessageBox.Show("Xóa thất bai");
        }
        public void loadncc()
        {
            frm_nhacungcap.DTV_nhacungcap.DataSource = dal_nhacungcap.loadncc();
        }
        public void LayDSNCC()
        {
            frm_hanghoa.cb_ncc.DataSource = dal_nhacungcap.loadncc();
            frm_hanghoa.cb_ncc.DisplayMember = "TenNCC";
            frm_hanghoa.cb_ncc.ValueMember = "MaNCC";
        }
    }
}
