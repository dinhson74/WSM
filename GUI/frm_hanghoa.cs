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
using DOAN_QLBH_DinhThanhSon_2485;


namespace DOAN_QLBH_DinhThanhSon_2485.GUI
{   
    
    public partial class frm_hanghoa : Form
    {
        DataTable tblH;
        DAL.LOPDUNGCHUNG lopchung = new DAL.LOPDUNGCHUNG();
        
        BLL.BLL_hanghoa bllhh;
        BLL.BLL_nhacungcap bllncc1;
        public frm_hanghoa()
        {
            InitializeComponent();
            bllncc1 = new BLL.BLL_nhacungcap(this);
            bllhh = new BLL.BLL_hanghoa(this);
            
        }

       

        private void btnThem_Click(object sender, EventArgs e)
        {
            bllhh.themhh();
            bllhh.loadhh();

        }

        private void frm_hanghoa_Load(object sender, EventArgs e)
        {
            bllhh.loadhh();
            bllncc1.LayDSNCC();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            bllhh.suahh();
            bllhh.loadhh();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            bllhh.xoahh();
            bllhh.loadhh();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DTV_hh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMahang.Text = DTV_hh.CurrentRow.Cells[0].Value.ToString();
            cb_ncc.Text = DTV_hh.CurrentRow.Cells[1].Value.ToString();
            txtTenhang.Text = DTV_hh.CurrentRow.Cells[2].Value.ToString();
            txtSoluong.Text = DTV_hh.CurrentRow.Cells[3].Value.ToString();
            txtDongianhap.Text = DTV_hh.CurrentRow.Cells[4].Value.ToString();
            txtDongiaban.Text = DTV_hh.CurrentRow.Cells[5].Value.ToString();
        }

        private void txtDongianhap_TextChanged(object sender, EventArgs e)
        {
            double gn, gb;
            if (txtDongianhap.Text == "")
                gn = 0;
            else
              gn = Convert.ToDouble(txtDongianhap.Text);
            gb = gn + (gn * 20 / 100);
            txtDongiaban.Text = gb.ToString();

        }
       
        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string sql;
            if ((txtMahang.Text == "") && (txtTenhang.Text == "") && (cb_ncc.Text == ""))
            {
                MessageBox.Show("Bạn hãy nhập điều kiện tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT * from HANGHOA WHERE 1=1";
            if (txtMahang.Text != "")
                sql += " AND MAH LIKE N'%" + txtMahang.Text + "%'";
            if (txtTenhang.Text != "")
                sql += " AND TenHANG LIKE N'%" + txtTenhang.Text + "%'";
            if (cb_ncc.Text != "")
                sql += " AND MaNCC LIKE N'%" + cb_ncc.SelectedValue + "%'";
            tblH =lopchung.LoadDuLieu(sql);
            if (tblH.Rows.Count == 0)
                MessageBox.Show("Không có hàng hóa thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Có " + tblH.Rows.Count + "  hàng hóa thoả mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DTV_hh.DataSource = tblH;
        }

        private void DTV_hh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSoluong_TextChanged(object sender, EventArgs e)
        {

        }

        private void cb_ncc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
