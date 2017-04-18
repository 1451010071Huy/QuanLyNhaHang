using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;//Thư viện chứa thuộc tính .State


namespace DAO
{
    //Class DAO sẽ chức hàm kết nối, thao tác với Database
    public class DataProvider
    {
        string cnStr = "";
        SqlConnection cn;
        public DataProvider()
        {
            cnStr = @"Data Source=DESKTOP-Q75A6S2;Initial Catalog=QLNhaHang;Integrated Security=True";
            cn = new SqlConnection(cnStr);
        }
        public SqlConnection getConnect()
        {
            cnStr = @"Data Source=DESKTOP-Q75A6S2;Initial Catalog=QLNhaHang;Integrated Security=True";
            cn = new SqlConnection(cnStr);
            return cn;
        }


        public SqlCommand CountLogin()
        {
            string sql = "SELECT COUNT(*) FROM DanhSachTaiKhoan WHERE DanhSachTaiKhoan.Username =@username AND DanhSachTaiKhoan.Password = @password";   
            return new SqlCommand(sql, cn);
        }

        /// <summary>
        /// Hàm Connect() để mở kết nối, nếu có lỗi xảy ra thì sẽ ném ra lỗi
        /// </summary>
        public void Connect()
        {
            try
            {
                if (cn != null && cn.State == ConnectionState.Closed)
                    cn.Open();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Hàm DisConnect() để đóng kết nối, nếu có lỗi xảy ra thì sẽ ném ra lỗi
        /// </summary>
        public void DisConnect()
        {
            try
            {
                if (cn != null && cn.State == ConnectionState.Open)
                    cn.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public SqlDataReader ExecuteReader(String sql)
        {
            Connect();
            try
            {
                SqlCommand cmd = new SqlCommand(sql, cn);
                return (cmd.ExecuteReader());
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        public int ExcuteNonQuery(string sql,CommandType type, List<SqlParameter> paras)
        {
            Connect();
            try
            {
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.CommandType = type;
                if(paras != null)
                {
                    foreach(SqlParameter para in paras)
                    {
                        cmd.Parameters.Add(para);
                    }
                }
                cmd.ExecuteNonQuery();
                return 1;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                DisConnect();
            }
        }
    }
}
