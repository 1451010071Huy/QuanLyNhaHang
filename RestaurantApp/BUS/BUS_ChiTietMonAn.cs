using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using DAO;
using DTO;

namespace BUS
{
    public class BUS_ChiTietMonAn
    {
        DAO_ChiTietMonAn chiTietMonAn = new DAO_ChiTietMonAn();
        public DataSet getChiTietMonAn()
        {
            return chiTietMonAn.getChiTietMonAn();
        }
        public void ThemCongThuc(DTO_ChiTietMonAn ct)
        {
            chiTietMonAn.ThemCongThuc(ct);
        }
        public void XoaCongThuc(DTO_ChiTietMonAn ct)
        {
            chiTietMonAn.XoaCongThuc(ct);
        }
    }
}
