using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ChiTietMonAn
    {
        public int MaMonAn { get; set; }
        public int MaNguyenLieu { get; set; }
        public string GhiChu { get; set; }
        
        public DTO_ChiTietMonAn (int maMonAn, int maNguyenLieu, string ghiChu)
        {
            MaMonAn = maMonAn;
            MaNguyenLieu = maNguyenLieu;
            GhiChu = ghiChu;
        }
        public DTO_ChiTietMonAn(int maMonAn, int maNguyenLieu)
        {
            MaMonAn = maMonAn;
            MaNguyenLieu = maNguyenLieu;
        }
    }
}
