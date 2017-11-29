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
   public class AttendanceService
    {

        #region add card No

        public string AddCardNo(string cardNo)
        {
            string sql = "insert into Attendance(CardNo) values(@CardNo)";

            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@CardNo",cardNo)
            };


            try
            {
                SQLHelper.GetReader(sql, param);

                return "success";

            }
            catch (Exception ex)
            {

                throw new Exception("Swipe card fail, please connect System admin"+ex.Message);
            }

          
        }

        #endregion

        #region get student count
        public int GetStudentCount()
        {
            string sql = "select count(*) from Students ";

            return Convert.ToInt32(SQLHelper.GetSingleResult(sql));

        }

        #endregion

        #region Get Signed Students
        public int GetSignedStudent()
        {
            string sql = "select count(distinct CardNo) from Attendance where DTime between @DTime1 and @DTime2 ";

            DateTime dt1 = Convert.ToDateTime(SQLHelper.GetServerTime().ToShortDateString());

            DateTime dt2 = dt1.AddDays(1.0);

            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@DTime1",dt1),
                new SqlParameter("@DTime2",dt2),
            };

            return Convert.ToInt32(SQLHelper.GetSingleResult(sql,param));
        }

        public int GetSignedStudent(DateTime beginTime,DateTime endTime)
        {
            string sql = "select count(distinct CardNo) from Attendance where DTime between @BeginTime and @EndTime";

            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@BeginTime",beginTime),
                new SqlParameter("@EndTime",endTime),
            };

            return Convert.ToInt32(SQLHelper.GetSingleResult(sql, param));

        }
       
        #endregion




        public List<Student> GetStudentBySignDate(DateTime beginTime,DateTime endTime, string name)
        {
            string sql = "select DTime,StudentId,Attendance.CardNo,StudentName,Gender,ClassName from Students ";
            sql += " inner join StudentClass on StudentClass.ClassId = Students.ClassId ";
            sql += " inner join Attendance on Attendance.CardNo = Students.CardNo ";

            sql += "where DTime between @BeginTime and @EndTime ";

            if(name!=null && name.Length != 0)
            {
                sql+=" and StudentName=@StudentName";
            }

            sql += " Order by DTime ASC";

            List<Student> list = new List<Student>();

            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@BeginTime",beginTime),
                new SqlParameter("@EndTime",endTime),
                new SqlParameter("@StudentName",name)

            };

            SqlDataReader objReader = SQLHelper.GetReader(sql, param);
            while (objReader.Read())
            {
                list.Add(

                    new Student()
                    {
                        StudentId = Convert.ToInt32(objReader["StudentId"]),
                        StudentName = objReader["StudentName"].ToString(),
                        Gender = objReader["Gender"].ToString(),
                        CardNo= objReader["CardNo"].ToString(),
                        SignedTime= Convert.ToDateTime(objReader["DTime"]),
                        ClassName=objReader["ClassName"].ToString()
                    }
                    );
            }

            objReader.Close();

            return list;

        }

    }
}
