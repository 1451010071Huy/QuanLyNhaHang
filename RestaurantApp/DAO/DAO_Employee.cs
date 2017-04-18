using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{

    public class DAO_Employee
    {
        private DataProvider dp;
        public DAO_Employee()
        {
            dp = new DataProvider();
        }
        public List<DTO_Employee> GetEmployee()
        {
            List<DTO_Employee> list = new List<DTO_Employee>();
            int pMaNV;
            double pLuongThang;
            string pHoNV, pTenNV, pSodienthoai,  pChucVu,  pGioiTinh, pSoCMND, pDiaChiThuongTru, pEmail;
            DateTime pNgaySinh, pNgayVaoLam;
            //dp.Connect();     
            try
            {
                string sql = "SELECT * FROM NhanVien";
                SqlDataReader dr = dp.ExecuteReader(sql);
                while (dr.Read())
                {
                    pMaNV = dr.GetInt32(0);
                    pHoNV = dr.GetString(1);
                    pTenNV = dr.GetString(2);
                    pSodienthoai = dr.GetString(3);
                    pNgaySinh = dr.GetDateTime(4);
                    pNgayVaoLam = dr.GetDateTime(5);
                    pChucVu = dr.GetString(6);
                    pLuongThang = dr.GetDouble(7);
                    pGioiTinh = dr.GetString(8);
                    pSoCMND = dr.GetString(9);
                    pDiaChiThuongTru = dr.GetString(10);
                    pEmail = dr.GetString(11);

                    DTO_Employee emp = new DTO_Employee(pMaNV,pHoNV, pTenNV, pSodienthoai, pNgaySinh, pNgayVaoLam, pChucVu, pLuongThang, pGioiTinh, pSoCMND, pDiaChiThuongTru, pEmail);
                    list.Add(emp);
                }
                dr.Close();
                return list;
            }
            catch (SqlException ex)
            {

                throw ex;
            }
            finally
            {
               // dp.DisConnect();
            }
        }


        public int Add (DTO_Employee emp)
        {
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@HoNV", emp.HoNV));
            paras.Add(new SqlParameter("@TenNV", emp.TenNV));
            paras.Add(new SqlParameter("@SoDienThoai", emp.SoDienThoai));
            paras.Add(new SqlParameter("@NgaySinh", emp.NgaySinh));
            paras.Add(new SqlParameter("NgayVaoLam", emp.NgayVaoLam));
            paras.Add(new SqlParameter("@ChucVu", emp.ChucVu));
            paras.Add(new SqlParameter("@LuongThang", emp.LuongThang));
            paras.Add(new SqlParameter("@GioiTinh", emp.GioiTinh));
            paras.Add(new SqlParameter("@SoCMND", emp.SoCMND));
            paras.Add(new SqlParameter("@DiaChiThuongTru", emp.DiaChiThuongTru));
            paras.Add(new SqlParameter("@Email", emp.Email));
            try 
	        {	        
		        return(dp.ExcuteNonQuery("sp_ThemNhanVien", System.Data.CommandType.StoredProcedure, paras));
	        }
	        catch (SqlException ex)
	        {
		        
	          	throw ex;
	        }

        }
        public int Delete(DTO_Employee emp)
        {
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@MaNV", emp.MaNV));
            try
            {
                return (dp.ExcuteNonQuery("sp_XoaNhanVien", System.Data.CommandType.StoredProcedure, paras));
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        public int Update(DTO_Employee emp)
        {
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@MaNV", emp.MaNV));
            paras.Add(new SqlParameter("@HoNV", emp.HoNV));
            paras.Add(new SqlParameter("@TenNV", emp.TenNV));
            paras.Add(new SqlParameter("@SoDienThoai", emp.SoDienThoai));
            paras.Add(new SqlParameter("@NgaySinh", emp.NgaySinh));
            paras.Add(new SqlParameter("NgayVaoLam", emp.NgayVaoLam));
            paras.Add(new SqlParameter("@ChucVu", emp.ChucVu));
            paras.Add(new SqlParameter("@LuongThang", emp.LuongThang));
            paras.Add(new SqlParameter("@GioiTinh", emp.GioiTinh));
            paras.Add(new SqlParameter("@SoCMND", emp.SoCMND));
            paras.Add(new SqlParameter("@DiaChiThuongTru", emp.DiaChiThuongTru));
            paras.Add(new SqlParameter("@Email", emp.Email));
            try
            {
                return (dp.ExcuteNonQuery("sp_SuaNhanVien", System.Data.CommandType.StoredProcedure, paras));
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
        
        public DataTable SearchByMaNV(DTO_Employee emp)
        {
            SqlConnection cnn = dp.getConnect();
            List<SqlParameter> paras = new List<SqlParameter>();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_TimTheoMaNhanVien", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaNV", emp.MaNV));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dp.DisConnect();
            return dt;
        }
        public DataTable SearchByChucVu(DTO_Employee emp)
        {
            SqlConnection cnn = dp.getConnect();
            List<SqlParameter> paras = new List<SqlParameter>();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_TimTheoChucVuNhanVien", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@ChucVu", emp.ChucVu));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dp.DisConnect();
            return dt;
        }
        public DataTable SearchByHoNV(DTO_Employee emp)
        {
            SqlConnection cnn = dp.getConnect();
            List<SqlParameter> paras = new List<SqlParameter>();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_TimTheoHoNhanVien", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@HoNV", emp.HoNV));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dp.DisConnect();
            return dt;
        }
        public DataTable SearchByTenNV(DTO_Employee emp)
        {
            SqlConnection cnn = dp.getConnect();
            List<SqlParameter> paras = new List<SqlParameter>();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_TimTheoTenNhanVien", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@TenNV", emp.TenNV));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dp.DisConnect();
            return dt;
        }
    }

       

        
}
