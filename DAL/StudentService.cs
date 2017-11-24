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

        #region get Students By  Class Name
        public List<Student> GetStudentByClassName(string className)
        {

            string sql = "select StudentId,StudentName,Gender,StudentIdNo,Birthday,PhoneNumber,ClassName from Students ";
            sql += "inner join StudentClass on StudentClass.ClassId= Students.ClassId ";
            sql += " where ClassName=@ClassName ";

            try
            {

                SqlParameter[] param = new SqlParameter[]
                {
                new SqlParameter("@ClassName",className),
                };

                List<Student> list = new List<Student>();

                SqlDataReader objReader = SQLHelper.GetReader(sql,param);

                while (objReader.Read())
                {
                    list.Add(new Student()
                    {
                        StudentId= Convert.ToInt32(objReader["StudentId"]),
                        StudentName= objReader["StudentName"].ToString(),
                        Gender=objReader["Gender"].ToString(),
                        StudentIdNo= objReader["StudentIdNo"].ToString(),
                        Birthday= Convert.ToDateTime(objReader["Birthday"]),
                        PhoneNumber= objReader["PhoneNumber"].ToString(),
                        ClassName=objReader["ClassName"].ToString()

                    });
                }


                objReader.Close();

                return list;

            }
            catch (Exception ex)
            {

                throw new Exception("Get Student By Class Name Error:"+ex.Message);
            }

           
        }

        #endregion


        #region Get Student By Student Id
        public Student GetStudentById(string studentId)
        {

            string sql = "select StudentId,StudentName,Gender,Birthday,StudentIdNo,CardNo,StuImage,PhoneNumber,StudentAddress,ClassName from Students ";
            sql += "inner join StudentClass on StudentClass.ClassId= Students.ClassId ";
            sql += " where StudentId=@StudentId";

            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@StudentId",studentId)
            };

            try
            {
                Student objStu = null;

                SqlDataReader objReader = SQLHelper.GetReader(sql, param);

                if (objReader.Read())
                {
                    objStu = new Student()
                    {
                        StudentId= Convert.ToInt32(objReader["StudentId"]),
                        StudentName= objReader["StudentName"].ToString(),
                        Gender= objReader["Gender"].ToString(),
                        Birthday= Convert.ToDateTime(objReader["Birthday"]),
                        StudentIdNo= objReader["StudentIdNo"].ToString(),
                        CardNo= objReader["CardNo"].ToString(),
                        StuImage=objReader["StuImage"].ToString(),
                        PhoneNumber=objReader["PhoneNumber"].ToString(),
                        StudentAddress=objReader["StudentAddress"].ToString(),
                        ClassName= objReader["ClassName"].ToString()
                    };
                }

                objReader.Close();

                return objStu;
            }
            catch (Exception ex)
            {

                throw new Exception("get Student by StudentId database connection error:"+ex.Message);
            }
        }
        #endregion
    }
}
