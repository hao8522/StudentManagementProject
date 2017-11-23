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
        #region admin login

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
        #endregion


        #region modify admin password
        public int ModifyPassword(SysAdmin objAdmin)
        {

            string sql = "update Admins set LoginPwd=@LoginPwd where LoginId=@LoginId ";

         
            try
            {

                SqlParameter[] param = new SqlParameter[]
                {
                    new SqlParameter("@LoginId",objAdmin.LoginId),
                    new SqlParameter("@LoginPwd",objAdmin.LoginPwd)
                };

                return SQLHelper.Update(sql, param);

            }
            catch (Exception ex)
            {

                throw new Exception("Modify Admin Password"+ex.Message);
            }
        }
        #endregion
    }
}
