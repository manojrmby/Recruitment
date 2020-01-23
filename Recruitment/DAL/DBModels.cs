using Recruitment.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Recruitment.DAL
{
    public class DBModels
    {
       
        public List<EmployeeModel> listAll_Emp()
        {
            List<EmployeeModel> lst = new List<EmployeeModel>();
            DataSet ds = new DataSet();

            DBHelper DB = new DBHelper("Sp_Employee", CommandType.StoredProcedure);
            DB.addIn("@Action", "ALL");
            ds = DB.ExecuteDataSet();

            var myData = ds.Tables[0].AsEnumerable().Select(r => new EmployeeModel
            {
                ID=r.Field<int>("ID"),
                EmployeeID = r.Field<string>("EmpID"),
                Name = r.Field<string>("empName"),
                Age = r.Field<int>("Age"),
                State=r.Field<string>("State"),
                Country = r.Field<string>("Country")
            });
            return myData.ToList();

        }
        public int Add_Emp(EmployeeModel Emp)
        {
            int i;

            DBHelper DB = new DBHelper("Sp_Employee", CommandType.StoredProcedure);
            DB.addIn("@Action", "Insert");
            DB.addIn("@Name", Emp.Name);
            DB.addIn("@EmpId", Emp.EmployeeID);

            DB.addIn("@Age", Emp.Age);
            DB.addIn("@State", Emp.State);
            DB.addIn("@Country", Emp.Country);

            i = DB.Execute();
            return i;


        }
        public int Update_Emp(EmployeeModel Emp)
        {
            int i;
            DBHelper DB = new DBHelper("Sp_Employee", CommandType.StoredProcedure);
            DB.addIn("@Action", "Update");
            DB.addIn("@EmpId", Emp.EmployeeID);
            DB.addIn("@Name", Emp.Name);

            DB.addIn("@Age", Emp.Age);
            DB.addIn("@State", Emp.State);
            DB.addIn("@Country", Emp.Country);
            DB.addIn("@Id", Emp.ID);
            i = DB.Execute();
            return i;
        }
        public int Delete_Emp(int EmpID)
        {
            int i;
            DBHelper DB = new DBHelper("Sp_Employee", CommandType.StoredProcedure);
            DB.addIn("@Action", "Delete");
            DB.addIn("Id", EmpID);
            i = DB.Execute();
            return i;
        }


        public List<RoleModel> listAll_Role()
        {
            List<RoleModel> lst = new List<RoleModel>();
            DataSet ds = new DataSet();

            DBHelper DB = new DBHelper("SP_Role", CommandType.StoredProcedure);
            DB.addIn("@Action", "ALL");
            ds = DB.ExecuteDataSet();

            var myData = ds.Tables[0].AsEnumerable().Select(r => new RoleModel
            {
                ID = r.Field<int>("Roleid"),
                RoleName = r.Field<string>("Role"),
             });

            lst= myData.ToList();
            return lst;

        }
    }
}