using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MTATOEIc.Models.code
{
    public class Sessionhelper
    {
        public static void SetSession(UsernameSession session)
        {
            HttpContext.Current.Session["loginSession"] = session;
        }
        public static UsernameSession GetSession()
        {
            var session = HttpContext.Current.Session["loginSession"];
            if (session == null)
                return null;
            else
            {
                return session as UsernameSession;
            }

        }
    }
}