using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace DOAN_QLBH_DinhThanhSon_2485.GUI
{
    public partial class frm_dangnhap : Form
    {
        DAL.LOPDUNGCHUNG lopchung = new DAL.LOPDUNGCHUNG();
       
        public frm_dangnhap()
        {
            InitializeComponent();
           
        }

        private void frm_dangnhap_Load(object sender, EventArgs e)
        {

        }

        private void tbn_dangnhap_Click(object sender, EventArgs e)
        {
            SqlConnection conn = lopchung.connection();
            SqlCommand comm = new SqlCommand();
            comm.CommandText = "select * from TAIKHOAN where TK = '" + txt_taikhoan.Text + "'and MK = '" + txt_matkhau.Text + "'";
            comm.Connection = conn;
            conn.Open();
          
            SqlDataReader read = comm.ExecuteReader();
            if (read.Read() == true)
            {
                this.Hide();
                frm_main main = new frm_main();

                main.Show();

            }
            else
            {
                DialogResult tb;
                tb = (MessageBox.Show("Bạn đã nhập sai tài khoản hoặc mật khẩu", "chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning));
            }
            conn.Close();
        }
    }
}
