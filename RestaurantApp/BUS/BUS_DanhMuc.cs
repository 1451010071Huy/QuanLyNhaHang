using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;
using DAO;
using DTO;
namespace BUS
{
    public class BUS_DanhMuc
    {
        DAO_DanhMuc Dm = new DAO_DanhMuc();
        public DataSet getDanhMuc()
        {
            return Dm.getDanhMuc();
        }
        public int ThemDanhMuc(DTO_DanhMuc dm)
        {
            if (dm.TenDanhMuc == "")
                return 2;
            else
            {
                Dm.ThemDanhMuc(dm);
                return 1;
            }
        }
        public void XoaDanhMuc(DTO_DanhMuc dm)
        {
                Dm.XoaDanhMuc(dm);
  
        }
        public void SuaDanhMuc(DTO_DanhMuc dm)
        {
            DAO_DanhMuc daoDanhMuc = new DAO_DanhMuc();
            daoDanhMuc.SuaDanhMuc(dm);
        }

    }
}
