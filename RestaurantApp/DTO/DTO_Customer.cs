using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Customer
    {
        private int maKH;

        public int MaKH
        {
            get { return maKH; }
            set { maKH = value; }
        }
        private string hoKH;

        public string HoKH
        {
            get { return hoKH; }
            set { hoKH = value; }
        }
        private string tenKH;

        public string TenKH
        {
            get { return tenKH; }
            set { tenKH = value; }
        }
        private string sodienthoaiKH;

        public string SoDienThoaiKH
        {
            get { return sodienthoaiKH; }
            set { sodienthoaiKH = value; }
        }
        private DateTime ngaysinhKH;

        public DateTime NgaySinhKH
        {
            get { return ngaysinhKH; }
            set { ngaysinhKH = value; }
        }
        private string noisinhKH;

        public string NoiSinhKH
        {
            get { return noisinhKH; }
            set { noisinhKH = value; }
        }
        private string gioitinhKH;

        public string GioiTinhKH
        {
            get { return gioitinhKH; }
            set { gioitinhKH = value; }
        }
        private string soCMNDKH;

        public string SoCMNDKH
        {
            get { return soCMNDKH; }
            set { soCMNDKH = value; }
        }
        private int diemtichluy;

        public int DiemTichLuy
        {
            get { return diemtichluy; }
            set { diemtichluy = value; }
        }
        private string diachithuongtruKH;

        public string DiaChiThuongTruKH
        {
            get { return diachithuongtruKH; }
            set { diachithuongtruKH = value; }
        }
        private string emailKH;

        public string EmailKH
        {
            get { return emailKH; }
            set { emailKH = value; }
        }
        public DTO_Customer(int pMaKH, string pHoKH, string pTenKH, string pSoDienThoaiKH, DateTime pNgaySinhKH, string pNoiSinhKH, string pGioiTinhKH, string pSoCMNDKH, int pDiemTichLuy, string pDiaChiThuongTru, string pEmail)
        {
            MaKH = pMaKH;
            HoKH = pHoKH;
            TenKH = pTenKH;
            SoDienThoaiKH = pSoDienThoaiKH;
            NgaySinhKH = pNgaySinhKH;
            NoiSinhKH = pNoiSinhKH;
            GioiTinhKH = pGioiTinhKH;
            SoCMNDKH = pSoCMNDKH;
            DiemTichLuy = pDiemTichLuy;
            DiaChiThuongTruKH = pDiaChiThuongTru;
            EmailKH = pEmail;
        }
        public DTO_Customer(string pHoKH,string pTenKH,string pSoDienThoaiKH,DateTime pNgaySinhKH,string pNoiSinhKH,string pGioiTinhKH,string pSoCMNDKH,int pDiemTichLuy,string pDiaChiThuongTru,string pEmail)
        {
            HoKH = pHoKH;
            TenKH = pTenKH;
            SoDienThoaiKH = pSoDienThoaiKH;
            NgaySinhKH = pNgaySinhKH;
            NoiSinhKH = pNoiSinhKH;
            GioiTinhKH = pGioiTinhKH;
            SoCMNDKH = pSoCMNDKH;
            DiemTichLuy = pDiemTichLuy;
            DiaChiThuongTruKH = pDiaChiThuongTru;
            EmailKH = pEmail;
        }
        public DTO_Customer(int pMaKH)
        {
            MaKH = pMaKH;
        }
        
        
        
        
        
    }
}
