using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL
{
    public class SQLHelper
    {
        public static readonly string connStr = ConfigurationManager.ConnectionStrings["connString"].ToString();

        #region insert,update modify ,delete data without parameter

        /// <summary>
        ///  insert, update ,delete data
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static int Update(string sql)
        {
            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand cmd = new SqlCommand(sql,conn);

            try
            {
                conn.Open();

                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }


        /// <summary>
        /// get one data 
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static object GetSingleResult(string sql)
        {
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(sql,conn);

            try
            {
                conn.Open();
                return cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }

        // get a set of data
        public static SqlDataReader GetReader(string sql)
        {

            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(sql, conn);

            try
            {
                conn.Open();

                return cmd.ExecuteReader(CommandBehavior.CloseConnection);

            }
            catch (Exception ex)
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }

                throw ex;
            }

        }
        #endregion

        #region  insert,update modify ,delete data with parameter
        public static int Update(string sql,SqlParameter[] param)
        {
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(sql, conn);

            if(param != null)
            {
                cmd.Parameters.AddRange(param);
            }

            try
            {
                conn.Open();
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conn.Close();
            }  
        }


        public static object GetSingleResult(string sql, SqlParameter[] param)
        {
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(sql,conn);

            if(param != null)
            {
                cmd.Parameters.AddRange(param);
            }

            try
            {
                conn.Open();
                return cmd.ExecuteScalar();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conn.Close();
            }

        }

        public static SqlDataReader  GetReader(string sql, SqlParameter[] param)
        {
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(sql,conn);

            if(param != null)
            {
                cmd.Parameters.AddRange(param);
             
            }

            try
            {
                conn.Open();
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion
        /// <summary>
        /// get data set
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static DataSet GetDataSet(string sql)
        {
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(sql,conn);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            try
            {
                conn.Open();

                da.Fill(ds);

                return ds;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// get server time
        /// </summary>
        /// <returns></returns>
        public static DateTime GetServerTime()
        {
            return Convert.ToDateTime(GetSingleResult("select getdate()"));
        }

        public static bool UpdateByTran(List<string> sqlList)
        {
            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conn;
            try
            {
                conn.Open();

                cmd.Transaction = conn.BeginTransaction();

                foreach(string itemSql in sqlList)
                {
                    cmd.CommandText = itemSql;
                    cmd.ExecuteNonQuery();
                   
                }
                cmd.Transaction.Commit();
                return true;
            }
            catch (Exception ex)
            {

                if(cmd.Transaction != null)
                {
                    cmd.Transaction.Rollback();
                }

                throw new Exception("UpdateByTran Error?" + ex.Message);
            }
            finally
            {
                if(cmd.Transaction != null)
                {
                    cmd.Transaction = null;
                }

                conn.Close();
            }
        }


    }
}
