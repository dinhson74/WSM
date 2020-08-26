using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace DOAN_QLBH_DinhThanhSon_2485.DAL
{

    class DAL_dangnhap
    {
        LOPDUNGCHUNG lopchung = new LOPDUNGCHUNG();
        GUI.frm_dangnhap frmdn = new GUI.frm_dangnhap();
        
        public void DangNhap1()
        {


            lopchung.Mo();
            SqlCommand comm = new SqlCommand();
            comm.CommandText = "select * from TaiKhoan where TK='" + frmdn.txt_taikhoan.Text + "'and MK ='" + frmdn.txt_matkhau.Text + "'";
            
            SqlDataReader read = comm.ExecuteReader();
            if (read.Read() == true)
            {

                frmdn.Show();

            }
            else
            {
                DialogResult tb;
                tb = (MessageBox.Show("Bạn đã nhập sai tài khoản hoặc mật khẩu", "chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning));
            }
            lopchung.Dong();
        }
    }
}
