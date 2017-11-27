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
   public class ScoreListService
    {

        #region get All Students Score list with DataSet
       

        public DataSet GetAllScoreList()
        {
            string sql = "select Students.StudentId,StudentName,Gender,PhoneNumber,ClassName,CSharp,SQLServerDB from Students ";
            sql += "inner join StudentClass on StudentClass.ClassId= Students.ClassId ";
            sql += "inner join ScoreList on ScoreList.StudentId= Students.StudentId ";

            return SQLHelper.GetDataSet(sql);

        }


        #endregion


        #region Get ScoreList by classname
        public List<Student> QueryScoreListByClassName(string className)
        {
            string sql = "select Students.StudentId,StudentName,Gender,PhoneNumber,ClassName,CSharp,SQLServerDB from Students ";
            sql += "inner join StudentClass on StudentClass.ClassId = Students.ClassId ";
            sql += "inner join ScoreList on ScoreList.StudentId= Students.StudentId ";


            if(className!=null && className.Length != 0)
            {

                sql += "where ClassName= @ClassName";
            }

            SqlParameter[] param = new SqlParameter[]
             {
                   new SqlParameter("@ClassName",className)
             };

            SqlDataReader objReader = SQLHelper.GetReader(sql, param);

            List<Student> list = new List<Student>();

            while (objReader.Read())
            {
                list.Add(new Student()
                {
                    StudentId= Convert.ToInt32(objReader["StudentId"]),
                    StudentName= objReader["StudentName"].ToString(),
                    Gender=objReader["Gender"].ToString(),
                    ClassName= objReader["ClassName"].ToString(),
                    CSharp= Convert.ToInt32(objReader["CSharp"]),
                    SQLServerDB= Convert.ToInt32(objReader["SQLServerDB"])

                });
            }

            objReader.Close();

            return list;

        }

        #endregion
    }
}
