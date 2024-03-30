using System;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace WebApplication2.App_Code.Sql
{
    public class connection
    {
        protected static string strConnectionString;
        public connection()
        {
            strConnectionString = ConfigurationSettings.AppSettings["sqlConnectionString"];
        }
        public SqlConnection GetConnection()

        {
            SqlConnection objSqlConnection = new SqlConnection(strConnectionString);

            return objSqlConnection;
        }
        public void CloseConnection(ref SqlConnection objConnection)
        {
            if (objConnection.State == ConnectionState.Open)
                objConnection.Close();
        }
        public SqlCommand GetCommand(string strSQLStmt, ref SqlConnection objConnection)
        {
            return (new SqlCommand(strSQLStmt, objConnection));
        }
        public void CloseDataReader(ref SqlDataReader objDataReader)
        {
            if (objDataReader != null)
                if (!objDataReader.IsClosed)
                    objDataReader.Close();
        }
        public SqlDataAdapter GetDataAdapter(string strSQLStmt, ref SqlConnection objConnection)
        {
            return (new SqlDataAdapter(strSQLStmt, objConnection));
        }
    }
}