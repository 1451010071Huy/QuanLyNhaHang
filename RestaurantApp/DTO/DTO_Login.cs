using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Login
    {
        public string userName { get; set; }
        public string passWord { get; set; }

        public DTO_Login(string user, string pass)
        {
            userName = user;
            passWord = pass;
        }
    }
}
