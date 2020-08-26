using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DOAN_QLBH_DinhThanhSon_2485.DAL
{
    class DAL_khachhang
    {
        LOPDUNGCHUNG lopchung = new LOPDUNGCHUNG();

        public int ThemKH(string makh, string tenkh, DateTime ngaysinh, string gioitinh, string diachi, string sdt)
        {

            string sql = "Insert into KHACHHANG values(N'" + makh + "',N'" + tenkh + "',N'" + ngaysinh.ToString() + "',N'" + gioitinh + "',N'" + diachi + "',N'" + sdt + "')";
            return lopchung.ThemSuaXoa(sql);
        }
        public int suakh(string makh, string hoten, DateTime ngaysinh, string gioitinh, string diachi, string sdt)
        {
            string sql = "Update KHACHHANG set TenKH =N'" + hoten + "',NgaySINH =N'" + ngaysinh.ToString() + "',GioiTINH =N'" + gioitinh + "',DiaCHI =N'" + diachi + "',SDT =N'" + sdt + "'where MaKH = '" + makh + "'";
            return lopchung.ThemSuaXoa(sql);
        }
        public int xoakh(string makh)
        {
            string sql = "Delete KHACHHANG where MaKH = N'" + makh + "'";
            return lopchung.ThemSuaXoa(sql);

        }
        public DataTable loadkh()
        {
            string sql = "Select * from KHACHHANG";
            return lopchung.LoadDuLieu(sql);

        }

    }
}
