using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{

    public class DTO_Employee
    {
        private int maNV;

        public int MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }


        private string hoNV;

        public string HoNV
        {
            get { return hoNV; }
            set { hoNV = value; }
        }

        private string tenNV;

        public string TenNV
        {
            get { return tenNV; }
            set { tenNV = value; }
        }
        private string sodienthoai;

        public string SoDienThoai
        {
            get { return sodienthoai; }
            set { sodienthoai = value; }
        }
        private DateTime ngaysinh;

        public DateTime NgaySinh
        {
            get { return ngaysinh; }
            set { ngaysinh = value; }
        }
        private DateTime ngayvaolam;

        public DateTime NgayVaoLam
        {
            get { return ngayvaolam; }
            set { ngayvaolam = value; }
        }
        private string chucvu;

        public string ChucVu
        {
            get { return chucvu; }
            set { chucvu = value; }
        }
        private double luongthang;

        public double LuongThang
        {
            get { return luongthang; }
            set { luongthang = value; }
        }
        private string gioitinh;

        public string GioiTinh
        {
            get { return gioitinh; }
            set { gioitinh = value; }
        }
        private string socmnd;

        public string SoCMND
        {
            get { return socmnd; }
            set { socmnd = value; }
        }
        private string diachithuongtru;

        public string DiaChiThuongTru
        {
            get { return diachithuongtru; }
            set { diachithuongtru = value; }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public DTO_Employee(int pMaNV, string pHoNV, string pTenNV, string pSoDienThoai, DateTime pNgaySinh, DateTime pNgayVaoLam, string pChucVu, double pLuongThang, string pGioiTinh, string pSoCMND, string pDiaChiThuongTru, string pEmail)
        {
            MaNV = pMaNV;
            HoNV = pHoNV;
            TenNV = pTenNV;
            SoDienThoai = pSoDienThoai;
            NgaySinh = pNgaySinh;
            NgayVaoLam = pNgayVaoLam;
            ChucVu = pChucVu;
            LuongThang = pLuongThang;
            GioiTinh = pGioiTinh;
            SoCMND = pSoCMND;
            DiaChiThuongTru = pDiaChiThuongTru;
            Email = pEmail;
        }
        public DTO_Employee(string pHoNV, string pTenNV, string pSoDienThoai, DateTime pNgaySinh, DateTime pNgayVaoLam, string pChucVu, double pLuongThang, string pGioiTinh, string pSoCMND, string pDiaChiThuongTru, string pEmail)
        {
            HoNV = pHoNV;
            TenNV = pTenNV;
            SoDienThoai = pSoDienThoai;
            NgaySinh = pNgaySinh;
            NgayVaoLam = pNgayVaoLam;
            ChucVu = pChucVu;
            LuongThang = pLuongThang;
            GioiTinh = pGioiTinh;
            SoCMND = pSoCMND;
            DiaChiThuongTru = pDiaChiThuongTru;
            Email = pEmail;
        }
        public DTO_Employee(int pMaNV)
        {
            MaNV = pMaNV;
        }
        public DTO_Employee ()
        {
           
        }
        

    }
}
