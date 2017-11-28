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

        #region GetScore Info 
        /// <summary>
        /// count absent number, and score result- avg score and number
        /// </summary>
        /// <param name="classId"></param>
        /// <returns></returns>
        public Dictionary<string,string> QueryScoreInfo(string classId)
        {

            string sql = "select stuCount=count(*) ,avgCSharp=avg(CSharp), avgDB= avg(SQLServerDB) from ScoreList";
            sql += "inner join Students on Students.StudnetId= ScoreList.StudentId ";

            if(classId !=null && classId.Length != 0)
            {
                sql += "where ClassId=@ClassId";
            }


            // absent number
            sql += ";select absentCount=count(*) from Students where StudentId not in (select studentId from ScoreList)";

           if(classId!=null && classId.Length != 0)
            {
                sql += "where ClassId=@ClassId ";
            }

            SqlParameter[] param = new SqlParameter[]
            {
               new SqlParameter("@ClassId",classId)
           };

            SqlDataReader objReader = SQLHelper.GetReader(sql,param);

            Dictionary<string, string> scoreInfo = null;
            if (objReader.Read())
            {
                scoreInfo = new Dictionary<string, string>();

                scoreInfo.Add("stuCount",objReader["stuCount"].ToString());
                scoreInfo.Add("avgCSharp",objReader["avgCsharp"].ToString());
                scoreInfo.Add("avgDB",objReader["avgDB"].ToString());

            }


            if (objReader.NextResult())
            {
                if (objReader.Read())
                {
                    scoreInfo.Add("absentCount",objReader["absentCount"].ToString());
                }
            }

            objReader.Close();

            return scoreInfo;
        }

        #endregion
    }
}
