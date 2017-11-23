using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Models;

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


        #region Add Student

        public int AddStudent(Student objStu)
        {

            string sql = "insert into Students(StudentName,Gender,Birthday,StudentIdNo,CardNo,StuImage,Age,PhoneNumber,StudentAddress,ClassId) values(@StudentName,@Gender,@Birthday,@StudentIdNo,@CardNo,@StuImage,@Age,@PhoneNumber,@StudentAddress,@ClassId); select @@identity";

          

            try
            {
                        SqlParameter[] param = new SqlParameter[]
                        {
                            new SqlParameter("@StudentName",objStu.StudentName),
                            new SqlParameter("@Gender",objStu.Gender),
                            new SqlParameter("@Birthday",objStu.Birthday.ToString("yyyy-MM-dd")),
                            new SqlParameter("@StudentIdNo",objStu.StudentIdNo),
                            new SqlParameter("@CardNo",objStu.CardNo),
                            new SqlParameter("@StuImage",objStu.StuImage),
                            new SqlParameter("@Age",objStu.Age),
                            new SqlParameter("@PhoneNumber",objStu.PhoneNumber),
                            new SqlParameter("@StudentAddress",objStu.StudentAddress),
                            new SqlParameter("@ClassId",objStu.ClassId)

                        };


                return Convert.ToInt32(SQLHelper.GetSingleResult(sql, param));

            }
            catch (Exception ex)
            {

                throw new Exception("Add Student database connection error:"+ex.Message);
            }
        }

        #endregion

    }
}
