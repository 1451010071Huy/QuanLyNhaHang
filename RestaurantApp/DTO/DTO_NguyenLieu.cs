using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_NguyenLieu
    {
        public string TenNguyenLieu { get; set; }
        public string NgayNhap { get; set; }
        public string HanSuDung { get; set; }
        public int MaNhaCungCap { get; set; }
        public int SoLuongTonKho { get; set; }
        public string DonViTinh { get; set; }
        
        public DTO_NguyenLieu(string tenNguyenLieu, string ngayNhap, string hanSuDung, int maNhaCungCap, int soLuongTonKho ,string donViTinh)
        {
            TenNguyenLieu = tenNguyenLieu;
            NgayNhap = ngayNhap;
            HanSuDung = hanSuDung;
            MaNhaCungCap = MaNhaCungCap;
            SoLuongTonKho = soLuongTonKho;
            DonViTinh = donViTinh;
        }
        public DTO_NguyenLieu(string tenNguyenLieu)
        {
            TenNguyenLieu = tenNguyenLieu;
        }
    }
}
