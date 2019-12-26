using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Recruitment.DAL
{
    
    public class AuthorizeRolesAttribute : AuthorizeAttribute
    {
       public string UserRole { get; set; }
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            //var IsAuthorized= base.AuthorizeCore(httpContext);
            //if (!IsAuthorized)
            //{
            //    return false;
            //}

            string CurrentUserRole = BaseClass.RoleName;
            if (this.UserRole.Contains(CurrentUserRole))
            { return true;}
            else
            { return false; }
        }

    }
}