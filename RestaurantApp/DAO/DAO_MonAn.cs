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
    public class DAO_MonAn
    {
        DataProvider dp = new DataProvider();
        public DataSet getMonAn()
        {       
            SqlConnection cnn = dp.getConnect();//Ham nay tra ve 1 chuoi ket noi
            string sqlMonAn = "SELECT MaMonAn,TenMonAn,GiaTien,DonViTinh,DanhMuc.TenDanhMuc,DanhMuc.MaDanhMuc FROM MonAn,DanhMuc WHERE MonAn.MaDanhMuc = DanhMuc.MaDanhMuc";//Ham nay tra ve 1 chuoi cau truy van
            SqlDataAdapter da = new SqlDataAdapter(sqlMonAn,cnn);// van chuyen du lieu
            DataSet ds = new DataSet();//Tao 1 bang ao
            da.Fill(ds);//do du lieu vao bang ao
            return ds;
        }
        public void ThemMonAn(DTO_MonAn ma)
        {
            SqlConnection cnn = dp.getConnect();    
            dp.Connect();
            string themMon = "INSERT INTO MonAn(TenMonAn,GiaTien,MaDanhMuc,DonViTinh) VALUES(N'" + ma.TenMonAn + "','" + ma.GiaTien + "','" +ma.MaDanhMuc + "',N'" + ma.DonViTinh + "')";
            SqlCommand cmd = new SqlCommand(themMon, cnn);
            cmd.ExecuteNonQuery();//Thuc thi cau truy van
        }
        public void SuaMonAn(DTO_MonAn ma)
        {
            SqlConnection cnn = dp.getConnect();
            dp.Connect();
            string suaMon = "UPDATE MonAn SET TenMonAn = N'" + ma.TenMonAn+ "',GiaTien ='" + ma.GiaTien +"',MaDanhMuc = '" + ma.MaDanhMuc + "', DonViTinh = N'" + ma.DonViTinh + "' WHERE MaMonAn = '" + ma.MaMonAn + "'";
            SqlCommand cmd = new SqlCommand(suaMon, cnn);
            cmd.ExecuteNonQuery();
        }
        public void XoaMonAn(DTO_MonAn ma)
        {
            DataProvider dp = new DataProvider();
            SqlConnection cnn = dp.getConnect();
            dp.Connect();//ham nay de ket noi thay vi cnn.open();
            string xoaMon = "DELETE FROM MonAn WHERE MaMonAn = '" + ma.MaMonAn + "'";
            SqlCommand cmd = new SqlCommand(xoaMon, cnn);
            cmd.ExecuteNonQuery();
        }
    }

}
