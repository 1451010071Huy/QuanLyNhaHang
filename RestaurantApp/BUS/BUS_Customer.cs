using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

using DTO;
using DAO;

namespace BUS
{
    public class BUS_Customer
    {
        public List<DTO_Customer> GetCustomer()
        {
            try
            {
                return new DAO_Customer().GetCustomer();

            }
            catch (SqlException ex)
            {
                
                throw ex;
            }
        }
        public int AddCustomer(DTO_Customer emp)
        {
            if (emp.HoKH == "" || emp.TenKH == "" || emp.SoDienThoaiKH == "" || emp.NoiSinhKH == "" || emp.GioiTinhKH == "" || emp.SoCMNDKH == "" || emp.DiemTichLuy.ToString() == "" || emp.DiaChiThuongTruKH == "" || emp.EmailKH == "")
                return -2;
            if (true)
            {

            }
            try
            {
                return (new DAO_Customer().AddCustomer(emp));
            }           
            catch (SqlException ex)
            {
                
                throw ex;
            }
        }
        public int DeleteCustomer (DTO_Customer emp)
        {
            if (emp.MaKH.ToString() == "")
                return -2;
            if (true)
            {

            }
            try
            {
                return (new DAO_Customer().DeleteCustomer(emp));
            }
            catch (SqlException ex)
            {
                
                throw ex;
            }
        }
        public int UpdateCustomer (DTO_Customer emp)
        {
            if (emp.MaKH.ToString() == "" || emp.HoKH == "" || emp.TenKH == "" || emp.SoDienThoaiKH == "" || emp.NoiSinhKH == "" || emp.GioiTinhKH == "" || emp.SoCMNDKH == "" || emp.DiemTichLuy.ToString() == "" || emp.DiaChiThuongTruKH == "" || emp.EmailKH == "")
                return -2;
            if (true)
            {

            }
            try
            {
                return (new DAO_Customer().UpdateCustomer(emp));
            }
            catch (SqlException ex)
            {
                
                throw ex;
            }
        }

    }
}
