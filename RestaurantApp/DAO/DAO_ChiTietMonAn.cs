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
    public class DAO_ChiTietMonAn
    {
        DataProvider dp = new DataProvider();
        public DataSet getChiTietMonAn()
        {
            SqlConnection cnn = dp.getConnect();//Ham nay tra ve 1 chuoi ket noi
            string sqlMonAn = "SELECT MonAn.TenMonAn,NguyenLieu.TenNL,GhiChu,MonAn.MaMonAn,NguyenLieu.MaNguyenLieu FROM MonAn,ChiTietMonAn,NguyenLieu WHERE MonAn.MaMonAn = ChiTietMonAn.MaMonAn AND ChiTietMonAn.MaNguyenLieu = NguyenLieu.MaNguyenLieu";//Ham nay tra ve 1 chuoi cau truy van
           // SqlCommand cmd = new SqlCommand(sqlMonAn, cnn);//Thu thi cau truy van 
            SqlDataAdapter da = new SqlDataAdapter(sqlMonAn, cnn);// (cmd)van chuyen du lieu
            DataSet ds = new DataSet();//Tao 1 bang ao
            da.Fill(ds);//do du lieu vao bang ao
            return ds;
        }
        public void ThemCongThuc(DTO_ChiTietMonAn ct)
        {
            SqlConnection cnn = dp.getConnect();
            dp.Connect();
            string themChiTiet = "INSERT INTO ChiTietMonAn(MaMonAn,MaNguyenLieu,GhiChu) VALUES(N'" + ct.MaMonAn + "','" + ct.MaNguyenLieu + "',N'" + ct.GhiChu + "')";
            SqlCommand cmd = new SqlCommand(themChiTiet, cnn);
            cmd.ExecuteNonQuery();//Thuc thi cau truy van
        }
        public void XoaCongThuc(DTO_ChiTietMonAn ct)
        {
            SqlConnection cnn = dp.getConnect();
            dp.Connect();//ham nay de ket noi thay thi cnn.open();
            string xoaCongThuc = "DELETE FROM ChiTietMonAn WHERE MaMonAn = '" + ct.MaMonAn + "' AND MaNguyenLieu = '" + ct.MaNguyenLieu + "'";
            SqlCommand cmd = new SqlCommand(xoaCongThuc, cnn);
            cmd.ExecuteNonQuery();
        }
    }
}
