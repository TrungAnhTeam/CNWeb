using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using MTATOEIc.Models.EF;


namespace MTATOEIc.Models
{
    public class QuesstionModel
    {
        private DATABASE da;
        public QuesstionModel()
        {
            da = new DATABASE();
        }

        public List<Question> ListAll( )
        {

            return da.Questions.ToList();
        }

        
    }
}