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
    public partial class frm_nhacungcap : Form
    {
        BLL.BLL_nhacungcap bllncc;
        BLL.BLL_hanghoa bllhh;
        
        public frm_nhacungcap()
        {
            InitializeComponent();
            bllncc = new BLL.BLL_nhacungcap(this);
            bllhh = new BLL.BLL_hanghoa(this);
        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            bllncc.xoancc();
          
           
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            bllncc.suancc();
            
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            bllncc.themncc();
            



        }

        private void DTV_nhacungcap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_mancc.Text = DTV_nhacungcap.CurrentRow.Cells[0].Value.ToString();
            txt_tenncc.Text = DTV_nhacungcap.CurrentRow.Cells[1].Value.ToString();
        }

        private void frm_nhacungcap_Load(object sender, EventArgs e)
        {
            bllncc.loadncc();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
