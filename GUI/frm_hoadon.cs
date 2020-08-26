using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DOAN_QLBH_DinhThanhSon_2485.DAL;
using System.Data.SqlClient;

namespace DOAN_QLBH_DinhThanhSon_2485.GUI
{
    public partial class frm_hoadon : Form
    {
      DAL.LOPDUNGCHUNG conn = new DAL.LOPDUNGCHUNG();
        LOPDUNGCHUNG lopchung = new LOPDUNGCHUNG();
        DataTable dthd;
        SqlConnection con;
        SqlCommand comm;

        BLL.BLL_khachhang bllkh;
        BLL.BLL_nhanvien bllnv;
        BLL.BLL_hanghoa bllhh;
        BLL.bll_hoadon bllhd;
        public frm_hoadon()
        {
            InitializeComponent();
            bllkh = new BLL.BLL_khachhang(this);
            bllnv = new BLL.BLL_nhanvien(this);
            bllhh = new BLL.BLL_hanghoa(this);
            bllhd = new BLL.bll_hoadon(this);

            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string sql;
            if ((cb_mnv.Text == ""))
            {
                MessageBox.Show("Bạn hãy nhập điều kiện tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT * from HOADON WHERE 1=1";
           
            if (cb_mnv.Text != "")
                sql += " AND MaNV LIKE N'%" + cb_mnv.SelectedValue + "%'";
            dthd = lopchung.LoadDuLieu(sql);
            if (dthd.Rows.Count == 0)
                MessageBox.Show("Không có nhân viên thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Có " + dthd.Rows.Count + " nhân viên thoả mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DTV_hoadon.DataSource = dthd;
        }

        private void cboMakhach_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            con = conn.connection();
            con.Open();
            comm = new SqlCommand("select * from KHACHHANG where MaKH = '" + cb_mkh.SelectedValue.ToString() + "'", con);
            SqlDataReader reader = comm.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();              
                txtTenkhach.Text = reader.GetString(1).ToString();
                txtDiachi.Text = reader.GetString(4).ToString();
                txtDienthoai.Text = reader.GetString(5).ToString();
            }
        }

        private void cboManhanvien_SelectedIndexChanged(object sender, EventArgs e)
        {
            con = conn.connection();
            con.Open();
            comm = new SqlCommand("select * from NHANVIEN where MaNV = '" + cb_mnv.SelectedValue.ToString() + "'", con);
            SqlDataReader reader = comm.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                txt_tennv.Text = reader.GetString(1).ToString();

            }
        }
        private void cb_mahang_SelectedIndexChanged(object sender, EventArgs e)
        {
            con = conn.connection();
            con.Open();
            comm = new SqlCommand("select * from HANGHOA where MaH = '" + cb_mahang.SelectedValue.ToString() + "'", con);
            SqlDataReader reader = comm.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                txt_tenhang.Text = reader.GetString(2).ToString();
                txt_giaban.Text = reader.GetInt32(5).ToString();

            }

        }
        private void cboMakhach_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frm_hoadon_Load(object sender, EventArgs e)
        {
            bllkh.LayDSNCC();
            bllnv.LayDSNV();
            bllhh.LayDSHH();
            bllhd.loadhd();
           
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_soluong_TextChanged(object sender, EventArgs e)
        {
            double sl, gn, tt;
            if (txt_giaban.Text == "")
                gn = 0;
            else
                gn = Convert.ToDouble(txt_giaban.Text);
            if (txt_soluong.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txt_soluong.Text);

            tt = gn * sl;
            txt_thanhtien.Text = tt.ToString();
        }

        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            bllhd.themhd();
            bllhd.loadhd();
           
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            bllhd.xoahd();
            bllhd.loadhd();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            bllhd.suahd();
            bllhd.loadhd();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_tinhtong_Click(object sender, EventArgs e)
        {
            int sc = DTV_hoadon.Rows.Count;
            float thanhtien = 0;
            for (int i = 0; i < sc - 1; i++)
                thanhtien += float.Parse(DTV_hoadon.Rows[i].Cells["ThanhTIEN"].Value.ToString());
            txtTongtien.Text = thanhtien.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql;
            if ((cb_mkh.Text == ""))
            {
                MessageBox.Show("Bạn hãy nhập điều kiện tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT * from HOADON WHERE 1=1";

            if (cb_mkh.Text != "")
                sql += " AND MaKH LIKE N'%" + cb_mkh.SelectedValue + "%'";
            dthd = lopchung.LoadDuLieu(sql);
            if (dthd.Rows.Count == 0)
                MessageBox.Show("Không có khách hàng thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Có " + dthd.Rows.Count + " khách thoả mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DTV_hoadon.DataSource = dthd;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            bllhd.loadhd();
        }

        private void DTV_hoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_mahd.Text = DTV_hoadon.CurrentRow.Cells[0].Value.ToString();
            cb_mnv.Text = DTV_hoadon.CurrentRow.Cells[1].Value.ToString();
            dt_ngayban.Text = DTV_hoadon.CurrentRow.Cells[2].Value.ToString();
            cb_mkh.Text = DTV_hoadon.CurrentRow.Cells[3].Value.ToString();
            cb_mahang.Text = DTV_hoadon.CurrentRow.Cells[4].Value.ToString();
            txt_soluong.Text = DTV_hoadon.CurrentRow.Cells[5].Value.ToString();
            txt_giaban.Text = DTV_hoadon.CurrentRow.Cells[6].Value.ToString();
            txt_thanhtien.Text = DTV_hoadon.CurrentRow.Cells[7].Value.ToString();
        }
    }
  
}
    

