using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using MTATOEIc.Models.EF;

namespace MTATOEIc.Models
{
    
    public class AccountLogin
    {
        private DATABASE da;
        public AccountLogin()
        {
            da = new DATABASE();
        }
        
        public bool Login(string username, string password)
        {
            object[] ob =
            {
                new SqlParameter("@Username",username),
                new SqlParameter("@Password", password)
            };
            var res = da.Database.SqlQuery<bool>("SP_Login @Username,@PassWord", ob).SingleOrDefault();
            return res;
        }

        
    }
}