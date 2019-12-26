using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using Recruitment.Models;

namespace Recruitment.DAL
{
    public class BaseClass
    {
        public static string RoleName;
        public LoginModel loginValidate(string Username, string Password)
        {
            LoginModel loginModel = new LoginModel();
            DataTable dt = new DataTable();
           
            if (Username != null && Username != "" && Password != null && Password != "")
            {
                DBHelper dB = new DBHelper("Sp_Login", CommandType.StoredProcedure);
                dB.addIn("@Type", "LoginValidate");
                dB.addIn("@username", Username);
                dB.addIn("@password", Password);

                dt = dB.ExecuteDataTable();
                if (dt.Rows.Count== 1)
                {
                    loginModel.Empid= Convert.ToString(dt.Rows[0]["EmpId"]);
                    loginModel.Role= Convert.ToString(dt.Rows[0]["Role"]);
                    
                    RoleName = Convert.ToString(dt.Rows[0]["Role"]).ToString();
                }
             }
            return loginModel;
        } 

    }
}