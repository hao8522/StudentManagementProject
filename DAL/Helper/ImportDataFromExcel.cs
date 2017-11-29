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
    public class ImportDataFromExcel
    {
        public List<Student> GetStudentByExcel(string path)
        {
            string sql = "select * from [Student$]";

            DataSet ds = OleDbHelper.GetDataSet(sql, path);

            DataTable dt = ds.Tables[0];
            List<Student> list = new List<Student>();

            foreach(DataRow row in dt.Rows)
            {

                list.Add(new Student()
                {
                    StudentName = row["Name"].ToString(),
                    Gender=row["Gender"].ToString(),
                    Birthday=Convert.ToDateTime(row["Birthday"]),
                    Age= DateTime.Now.Year- Convert.ToDateTime(row["Birthday"]).Year,
                    CardNo =row["CardNo"].ToString(),
                    StudentIdNo=row["StudentIdNo"].ToString(),
                    PhoneNumber=row["PhoneNumber"].ToString(),
                    StudentAddress=row["Address"].ToString(),
                    ClassId= Convert.ToInt32(row["ClassId"])
                });
            }

            return list;
        }

        public bool Import(List<Student> list)
        {
            StringBuilder sqlBuilder = new StringBuilder("insert into Students(StudentName,Gender,Birthday,StudentIdNo,CardNo,Age,PhoneNumber,StudentAddress,ClassId) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')");
            List<string> sqlList = new List<string>();


            foreach(Student objStu in list)
            {


                string sql = string.Format(sqlBuilder.ToString(), objStu.StudentName, objStu.Gender, objStu.Birthday.ToString("yyyy-MM-dd"), objStu.StudentIdNo, objStu.CardNo, objStu.Age, objStu.PhoneNumber, objStu.StudentAddress, objStu.ClassId);



                sqlList.Add(sql);
            }


            return SQLHelper.UpdateByTran(sqlList);
        }

    }
}
