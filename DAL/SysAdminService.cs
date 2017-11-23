using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class SysAdminService
    {

        public SysAdmin AdminLogin(SysAdmin objAdmin)
        {
            string sql = "select AdminName from Admins where LoginId=@LoginId and LoginPwd=@LoginPwd";

            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@LoginId",objAdmin.LoginId),
                new SqlParameter("@LoginPwd",objAdmin.LoginPwd)
            };


            try
            {
                SqlDataReader objReader = SQLHelper.GetReader(sql, param);

                if (objReader.Read())
                {
                    objAdmin.AdminName = objReader["AdminName"].ToString();
                }
                else
                {
                    objAdmin = null;
                }

                objReader.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }



            return objAdmin;
           
        }
    }
}
