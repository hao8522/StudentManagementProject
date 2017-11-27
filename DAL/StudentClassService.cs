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
        public DataSet GetAllClasses()
        {
            string sql = "select ClassId,ClassName from StudentClass";

            return SQLHelper.GetDataSet(sql);

        }
    }
}
