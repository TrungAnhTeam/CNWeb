using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.EF;

namespace Models.Dao
{
    public class Qestionmodel
    {
        private Mydatabase context = null;
        public Qestionmodel()
        {
            context = new Mydatabase();
        }
        public List<Question> qes()
        {

        }


    }
}
