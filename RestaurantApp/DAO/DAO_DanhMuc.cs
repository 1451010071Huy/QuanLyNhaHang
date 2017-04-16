using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAO
{
    //ham nay tra ve 1 table
    public class DAO_DanhMuc
    {
        DataProvider dp = new DataProvider();
        public DataSet getDanhMuc()
        {
            SqlConnection cnn = dp.getConnect();
            //Ham nay tra ve 1 chuoi ket noi
            string sqlDanhMuc = "SELECT *FROM DanhMuc";//Ham nay tra ve 1 chuoi cau truy van
            SqlDataAdapter da = new SqlDataAdapter(sqlDanhMuc,cnn);// van chuyen du lieu
            DataSet ds = new DataSet();//Tao 1 bang ao
            da.Fill(ds);//do du lieu vao bang ao
            return ds;
        }
        public void ThemDanhMuc(DTO_DanhMuc dm)
        {       
            SqlConnection cnn = dp.getConnect();
            dp.Connect();
            string themDanhMuc = "INSERT INTO DanhMuc(TenDanhMuc,MoTa) VALUES(N'" + dm.TenDanhMuc + "',N'" + dm.MoTa + "')";
            SqlCommand cmd = new SqlCommand(themDanhMuc, cnn);
            cmd.ExecuteNonQuery();//thuc thi sqlCommand
        }
        public void XoaDanhMuc(DTO_DanhMuc dm)
        {
            SqlConnection cnn = dp.getConnect();
            dp.Connect();//ham nay de ket noi thay thi cnn.open();
            string xoaDanhMuc = "DELETE FROM DanhMuc WHERE MaDanhMuc = '" + dm.MaDanhMuc + "'";
            SqlCommand cmd = new SqlCommand(xoaDanhMuc, cnn);
            cmd.ExecuteNonQuery();
        }

        public void SuaDanhMuc(DTO_DanhMuc dm)
        {
            SqlConnection cnn = dp.getConnect();
            string Sua = "UPDATE DanhMuc SET TenDanhMuc = N'" + dm.TenDanhMuc + "', MoTa = N'" + dm.MoTa + "' WHERE MaDanhMuc = '" + dm.MaDanhMuc + "'";
            dp.Connect();
            SqlCommand cmd = new SqlCommand(Sua, cnn);
            cmd.ExecuteNonQuery();
        }
    }
    
}
