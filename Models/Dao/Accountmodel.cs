using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.EF;

namespace Models.Dao
{
    public class Accountmodel
    {
        private Mydatabase context=null;
        public Accountmodel()
        {
            context = new Mydatabase();
        }
        public bool login(string UserName, string Password)
        {
            object[] sqlpara =
            {
                new SqlParameter("@Username", UserName),
                new SqlParameter("@Pass", Password),
            };
            var res = context.Database.SqlQuery<bool>("Sp_Account_Login @Username,@Pass", sqlpara).SingleOrDefault();
            return res;

        }

  
    }
}
