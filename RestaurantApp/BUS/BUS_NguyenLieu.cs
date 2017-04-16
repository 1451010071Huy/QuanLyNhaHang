using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using DAO;
namespace BUS
{
    public class BUS_NguyenLieu
    {
        DAO_NguyenLieu Nl = new DAO_NguyenLieu();
        //hàm này để lấy nguyên liệu đổ vào combobox nguyên liệu
        public DataSet getNguyenLieu()
        {
            return Nl.getNguyenLieu();
        }
    }
}
