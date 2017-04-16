using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

using DTO;
namespace DAO
{
    public class DAO_Login
    {
        public int IsLogin(DTO_Login lg)
        {
            try
            {
                DataProvider dp = new DataProvider();
                dp.getConnect();
                dp.Connect();
                SqlCommand cmd = dp.CountLogin();
                cmd.Parameters.Add(new SqlParameter("@username", lg.userName));
                cmd.Parameters.Add(new SqlParameter("@password", lg.passWord));
                int kq = (int)cmd.ExecuteScalar();//tra ve so nguyen 1, 0
                dp.DisConnect();
                return kq;// đăng nhập thàng công = 1, ko thành công = 0;
            }
            catch (SqlException ex)
            {

                throw ex;
            }
            

        }
    }
}
