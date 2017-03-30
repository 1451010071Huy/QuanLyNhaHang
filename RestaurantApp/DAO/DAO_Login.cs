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
        public int IsLogin(string username, string password)
        {
            try
            {
                DTO_Login lg = new DTO_Login(username, password);
                DataProvider dt = new DataProvider();
                dt.Connect();
                SqlCommand command = dt.CountLogin();
                command.Parameters.Add(new SqlParameter("@username", lg.userName));
                command.Parameters.Add(new SqlParameter("@password", lg.passWord));
                int kq = (int)command.ExecuteScalar();
                return kq;// đăng nhập thàng công = 1, ko thành công = 0;
            }
            catch (SqlException ex)
            {

                throw ex;
            }
            
        }
    }
}
