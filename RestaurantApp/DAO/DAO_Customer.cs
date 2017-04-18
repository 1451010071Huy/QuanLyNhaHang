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
    public class DAO_Customer
    {
        private DataProvider dp;
        public DAO_Customer()
        {
            dp = new DataProvider();
        }
        public List<DTO_Customer> GetCustomer()
        {
            List<DTO_Customer> list = new List<DTO_Customer>();
            int pMaKH, pDiemTichLuy;
            string pHoKH, pTenKH, pSoDienThoaiKH, pNoiSinhKH, pGioiTinhKH, pSoCMNDKH, pDiaChiThuongTru, pEmailKH;
            DateTime pNgaySinhKH;
            try
            {
                string sql = "SELECT * FROM KhachHang";
                SqlDataReader dr = dp.ExecuteReader(sql);
                while (dr.Read())
                {
                    pMaKH = dr.GetInt32(0);
                    pHoKH = dr.GetString(1);
                    pTenKH = dr.GetString(2);
                    pSoDienThoaiKH = dr.GetString(3);
                    pNgaySinhKH = dr.GetDateTime(4);
                    pNoiSinhKH = dr.GetString(5);
                    pGioiTinhKH = dr.GetString(6);
                    pSoCMNDKH = dr.GetString(7);
                    pDiemTichLuy = dr.GetInt32(8);
                    pDiaChiThuongTru = dr.GetString(9);
                    pEmailKH = dr.GetString(10);

                    DTO_Customer emp = new DTO_Customer(pMaKH, pHoKH, pTenKH, pSoDienThoaiKH, pNgaySinhKH, pNoiSinhKH, pGioiTinhKH, pSoCMNDKH, pDiemTichLuy, pDiaChiThuongTru, pEmailKH);
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

            }
        }
        public int AddCustomer(DTO_Customer emp)
        {
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@HoKH", emp.HoKH));
            paras.Add(new SqlParameter("@TenKH", emp.TenKH));
            paras.Add(new SqlParameter("SoDienThoai", emp.SoDienThoaiKH));
            paras.Add(new SqlParameter("@NgaySinh", emp.NgaySinhKH));
            paras.Add(new SqlParameter("@NoiSinh", emp.NoiSinhKH));
            paras.Add(new SqlParameter("@GioiTinh", emp.GioiTinhKH));
            paras.Add(new SqlParameter("@SoCMND", emp.SoCMNDKH));
            paras.Add(new SqlParameter("@DiemTichLuy", emp.DiemTichLuy));
            paras.Add(new SqlParameter("@DiaChiThuongTru", emp.DiaChiThuongTruKH));
            paras.Add(new SqlParameter("@Email", emp.EmailKH));
            try
            {
                return (dp.ExcuteNonQuery("sp_ThemKhachHang", System.Data.CommandType.StoredProcedure, paras));
            }
            catch (SqlException ex)
            {
                
                throw ex;
            }

        }
        public int DeleteCustomer(DTO_Customer emp)
        {
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@MaKH", emp.MaKH));
            try
            {
                return (dp.ExcuteNonQuery("sp_XoaKhachHang", System.Data.CommandType.StoredProcedure, paras));
            }
            catch (SqlException ex)
            {
                
                throw ex;
            }
        }
        public int UpdateCustomer(DTO_Customer emp)
        {
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@MaKH", emp.MaKH));
            paras.Add(new SqlParameter("@HoKH", emp.HoKH));
            paras.Add(new SqlParameter("@TenKH", emp.TenKH));
            paras.Add(new SqlParameter("SoDienThoai", emp.SoDienThoaiKH));
            paras.Add(new SqlParameter("@NgaySinh", emp.NgaySinhKH));
            paras.Add(new SqlParameter("@NoiSinh", emp.NoiSinhKH));
            paras.Add(new SqlParameter("@GioiTinh", emp.GioiTinhKH));
            paras.Add(new SqlParameter("@SoCMND", emp.SoCMNDKH));
            paras.Add(new SqlParameter("@DiemTichLuy", emp.DiemTichLuy));
            paras.Add(new SqlParameter("@DiaChiThuongTru", emp.DiaChiThuongTruKH));
            paras.Add(new SqlParameter("@Email", emp.EmailKH));
            try
            {
                return (dp.ExcuteNonQuery("sp_SuaKhachHang", System.Data.CommandType.StoredProcedure, paras));
            }
            catch (SqlException ex)
            {
                
                throw ex;
            }
        }
    }

}

