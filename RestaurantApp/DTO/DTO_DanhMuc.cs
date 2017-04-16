using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_DanhMuc
    {
        public int MaDanhMuc { get; set; }
        public string TenDanhMuc { get; set; } 
        public string MoTa { get; set; }

        public DTO_DanhMuc()
        {
            MaDanhMuc = 1;
            TenDanhMuc = "";
            MoTa = "";
        }
        public DTO_DanhMuc(int maDanhMuc ,string tenDanhMuc  , string moTa)
        {
            MaDanhMuc = maDanhMuc;
            TenDanhMuc = tenDanhMuc;
            MoTa = moTa;
        }
        public DTO_DanhMuc(int maDanhMuc)
        {
            MaDanhMuc = maDanhMuc;
        }
        public DTO_DanhMuc( string tenDanhMuc, string moTa)
        {
            TenDanhMuc = tenDanhMuc;
            MoTa = moTa;
        }
    }
}
