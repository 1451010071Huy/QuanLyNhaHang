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
    public class BUS_MonAn
    {
        DAO_MonAn monAn = new DAO_MonAn();
        public DataSet getMonAn()
        {     
            return monAn.getMonAn();
        }
        public void ThemMonAn(DTO_MonAn ma)
        {
            monAn.ThemMonAn(ma);
        }
        public void SuaMonAn(DTO_MonAn ma)
        {
            monAn.SuaMonAn(ma);
        }
        public void XoaMonAn(DTO_MonAn ma)
        {
            monAn.XoaMonAn(ma);
        }
    }
}
