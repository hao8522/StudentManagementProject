using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

using DAL;
using System.Data;
using System.Data.SqlClient;


namespace DAL
{
   public class StudentClassService
    {

        #region GetAll ClassName

        public List<StudentClass> GetAllStudentClass()
        {
            string sql = "select ClassId ,ClassName from StudentClass";

            SqlDataReader objReader = SQLHelper.GetReader(sql);

            List<StudentClass> listStuClass = new List<StudentClass>();

            while(objReader.Read())
            {
                listStuClass.Add( new StudentClass()
                {
                    ClassId= Convert.ToInt32(objReader["ClassId"]),
                    ClassName= objReader["ClassName"].ToString()

                });
            }

            objReader.Close();

            return listStuClass;
        }
     
          public DataSet GetAllClassesName()
        {
            string sql = "select ClassId,ClassName from StudentClass";

            return SQLHelper.GetDataSet(sql);

        }

        #endregion

    }
}
