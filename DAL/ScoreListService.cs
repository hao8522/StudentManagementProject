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

    }
}
