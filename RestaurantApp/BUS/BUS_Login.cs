﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

using DTO;
using DAO;// Lớp tương tác với Database

namespace BUS
{
    public class BUS_Login
    {
        //sử lý đăng nhập thành công hay ko, thành công trả về 1, ko thành công trả về 0
        public int IsLogin(string username, string password)
        {
            DTO_Login lgDTO = new DTO_Login(username,password);
            if (lgDTO.userName == "User Name" || lgDTO.passWord == "Password")
                return 2;
            else
            {
                DAO_Login lgDAO = new DAO_Login();
                if (lgDAO.IsLogin(username, password) == 1)
                    return 1;
                else
                    return 0;
            }
        }
    }
}