using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_MonAn:DTO_DanhMuc
    {
        public int MaMonAn { get; set; } 
        public string TenMonAn { get; set; }
        public int GiaTien { get; set; } 
        public string DonViTinh { get; set; }

        public DTO_MonAn(int maMonAn, string tenMonAn , int giaTien ,int maDanhMuc ,string donViTinh):base(maDanhMuc)
        {
            MaMonAn = maMonAn;
            TenMonAn = tenMonAn;
            GiaTien = giaTien;
            DonViTinh = donViTinh;
        }
        public DTO_MonAn(string tenMonAn , int giaTien , int maDanhmuc, string donViTinh):base(maDanhmuc)
        {
            TenMonAn = tenMonAn;
            GiaTien = giaTien;
            DonViTinh = donViTinh;
        }
        public DTO_MonAn(int maMonAn)
        {
            MaMonAn = maMonAn;
        }

    }
}
