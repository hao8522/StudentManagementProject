using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class StudentService
    {

        #region  check student Id No exist at db
        /// <summary>
        /// check student Id No exist at db
        /// </summary>
        /// <param name="stuIdNo"></param>
        /// <returns></returns>
        public bool IsIdNoExisted(string stuIdNo)
        {
            string sql = "select COUNT(*) from Students where StudentIdNo=@StudentIdNo";

            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@StudentIdNo",stuIdNo),


            };


            int result = Convert.ToInt32(SQLHelper.GetSingleResult(sql, param));

            if (result == 1)
            {
                return true;
            }
            else
            {
                return false;
            }


        }


        #endregion


        #region check attendance card exist at db

        public bool IsCardNoExist(string cardNo)
        {
            string sql = "select COUNT(*) from Students where CardNo=@CardNo";

            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@CardNo",cardNo)
            };

            int result = Convert.ToInt32(SQLHelper.GetSingleResult(sql, param));

            if (result == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion

    }
}
