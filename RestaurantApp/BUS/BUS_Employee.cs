using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

using DTO;
using DAO;
using System.Data;

namespace BUS
{
    public class BUS_Employee
    {
        public List<DTO_Employee> GetEmployee()
        {
            try
            {
                return new DAO_Employee().GetEmployee();
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
        public int Add(DTO_Employee emp)
        {
            if (emp.HoNV == "" || emp.TenNV == "" || emp.SoDienThoai == "" || emp.ChucVu == "" || emp.GioiTinh == "" || emp.SoCMND == "" || emp.DiaChiThuongTru == "" || emp.Email == "")           
                    return -2;
            if (true)
            { 
            
            }
            try
            {          
                return (new DAO_Employee().Add(emp));
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int Delete(DTO_Employee emp)
        {
            if (emp.MaNV.ToString() == "")
                return -2;

            if (true)
                {

                }
            try
            {
                return (new DAO_Employee().Delete(emp));
            }
            catch (SqlException ex)
            {
                throw ex;
            }

        }
        public int Update (DTO_Employee emp)
        {
            if (emp.MaNV.ToString() == "" || emp.HoNV == "" || emp.TenNV == "" || emp.SoDienThoai == "" || emp.ChucVu == "" || emp.GioiTinh == "" || emp.SoCMND == "" || emp.DiaChiThuongTru == "" || emp.Email == "")
                return -2;
            if (true)
            {

            }
            try
            {
                return (new DAO_Employee().Update(emp));
            }
            catch (SqlException ex)
            {
                
                throw ex;
            }
        }
        
        public DataTable SearchByMaNV(DTO_Employee emp)
        {
            DAO_Employee em = new DAO_Employee();
            return em.SearchByMaNV(emp);
        }
        public DataTable SearchByChucVu(DTO_Employee emp)
        {
            DAO_Employee em = new DAO_Employee();
            return em.SearchByChucVu(emp);
        }
        public DataTable SearchByHoNhanVien(DTO_Employee emp)
        {
            DAO_Employee em = new DAO_Employee();
            return em.SearchByHoNV(emp);
        }
        public DataTable SearchByTenNhanVien(DTO_Employee emp)
        {
            DAO_Employee em = new DAO_Employee();
            return em.SearchByTenNV(emp);
        }
        
    }
}
