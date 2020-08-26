using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DOAN_QLBH_DinhThanhSon_2485.DAL
{
    class DAL_nhacungcap
    {

        LOPDUNGCHUNG lopchung = new LOPDUNGCHUNG();

        public int themncc(string mancc,string tenncc)
        {

            string sql = "Insert into NHACUNGCAP values(N'" + mancc + "',N'" + tenncc + "')";
            return lopchung.ThemSuaXoa(sql);
        }
        public int suancc(string mancc, string tenncc)
        {
            string sql = "Update NHACUNGCAP set TenNCC =N'" + tenncc + "'where MaNCC = '" + mancc + "'";
            return lopchung.ThemSuaXoa(sql);
        }
        public int xoancc(string mancc)
        {
            string sql = "Delete NHACUNGCAP where MaNCC = N'" + mancc + "'";
            return lopchung.ThemSuaXoa(sql);

        }
        public DataTable loadncc()
        {
            string sql = "Select * from NHACUNGCAP";
            return lopchung.LoadDuLieu(sql);

        }

    }
}
