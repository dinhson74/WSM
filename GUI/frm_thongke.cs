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
using System.Data;


namespace DOAN_QLBH_DinhThanhSon_2485.GUI
{
    public partial class frm_thongke : Form
    {
        DAL.LOPDUNGCHUNG lopchung = new DAL.LOPDUNGCHUNG();
        BLL.bll_hoadon bllhd;


        DataTable dttime;
        public frm_thongke()
        {
            InitializeComponent();


            bllhd = new BLL.bll_hoadon(this);
        }
        


        private void btnTimTheoKhoangtg_Click(object sender, EventArgs e)
        {
            lopchung.connection().Open();
            
            string sql = "SELECT * FROM HOADON WHERE 1=1";
            if ((dt_timetruoc.Text != "") && (dt_timesau.Text != ""))
            {
                sql = sql + " AND NgayBAN >= '" + dt_timetruoc.Text + "' AND NgayBAN <= '" + dt_timesau.Text + "'";
            }
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, lopchung.connection());
            da.Fill(ds);
            lopchung.connection().Close();
            DGV_thongke.DataSource = ds.Tables[0];
            DGV_thongke.Refresh();
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            bllhd.loadtk();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_tinhtong_Click(object sender, EventArgs e)
        {
            int sc = DGV_thongke.Rows.Count;
            float thanhtien = 0;
            for (int i = 0; i < sc - 1; i++)
                thanhtien += float.Parse(DGV_thongke.Rows[i].Cells["ThanhTIEN"].Value.ToString());
            txt_tong.Text = thanhtien.ToString();
        }
    }
}
