using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DOAN_QLBH_DinhThanhSon_2485.DAL
{
    class DAL_nhanvien
    {

        LOPDUNGCHUNG lopchung = new LOPDUNGCHUNG();

        public int ThemNV(string manv, string tennv, DateTime ngaysinh, string gioitinh, string diachi, string sdt)
        {

            string sql = "Insert into NHANVIEN values(N'" + manv + "',N'" + tennv + "',N'" + ngaysinh.ToString() + "',N'" + gioitinh + "',N'" + diachi + "',N'" + sdt + "')";
            return lopchung.ThemSuaXoa(sql);
        }
        public int suanv(string manv, string hoten, DateTime ngaysinh, string gioitinh, string diachi, string sdt)
        {
            string sql = "Update NHANVIEN set TenNV =N'" + hoten + "',NgaySINH =N'" + ngaysinh.ToString() + "',GioiTINH =N'" + gioitinh + "',DiaCHI =N'" + diachi + "',SDT =N'" + sdt + "'where MaNV = '" + manv + "'";
            return lopchung.ThemSuaXoa(sql);
        }
        public int xoanv(string manv)
        {
            string sql = "Delete NHANVIEN where MaNV = N'" + manv + "'";
            return lopchung.ThemSuaXoa(sql);

        }
        public DataTable loadnv()
        {
            string sql = "Select * from NHANVIEN";
            return lopchung.LoadDuLieu(sql);

        }
       
    }
}