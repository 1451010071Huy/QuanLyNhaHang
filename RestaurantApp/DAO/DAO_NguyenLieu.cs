using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

using DTO;
namespace DAO
{
    public class DAO_NguyenLieu
    {
        DataProvider dp = new DataProvider();
        public DataSet getNguyenLieu()
        {
            SqlConnection cnn = dp.getConnect();//Ham nay tra ve 1 chuoi ket noi
            string sqlNguyenLieu = "SELECT MaNguyenLieu,TenNL FROM NguyenLieu";//Ham nay tra ve 1 chuoi cau truy van
            //Phai them fiel MaNguyenLieu moi lay duoc gia tri ValueMember
            SqlDataAdapter da = new SqlDataAdapter(sqlNguyenLieu, cnn);// van chuyen du lieu
            DataSet ds = new DataSet();//Tao 1 bang ao
            da.Fill(ds);//do du lieu vao bang ao
            return ds;
        }
    }
}
