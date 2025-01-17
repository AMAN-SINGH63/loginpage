﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

namespace WebApplication2.App_Code.Sql
{
    public class Common : connection
    {
        SqlConnection con = null;

        SqlCommand cmd = null;
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet dsmain = new DataSet();
        ArrayList outputParameter = new ArrayList();
        ArrayList parameterNameArray = new ArrayList();
        ArrayList parameterDataTypeArray = new ArrayList();
        public Common()
        {
            con = null;
            cmd = null;
            dsmain = new DataSet();
            da = new SqlDataAdapter();
            con = GetConnection();
        }
        public static object GetStringOrDBNull(string value)
        {
            object o;
            if (string.IsNullOrEmpty(value))
            {
                o = DBNull.Value;
            }
            else
            {
                o = value;
            }
            return o;
        }
        public DataSet DynamicBindProcedure(string procedureName, string[] parameterValueArray)
        {
            try
            {
                con.Open();
                GetParameters(procedureName);
                cmd = GetCommand(procedureName, ref con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                int x = 0;
                foreach (var paramsValue in parameterValueArray)
                {
                    if (parameterDataTypeArray[x].ToString().ToUpper() == "VARCHAR")
                    {
                        cmd.Parameters.Add(parameterNameArray[x].ToString(), SqlDbType.VarChar).Value = GetStringOrDBNull(paramsValue);
                    }
                    else if (parameterDataTypeArray[x].ToString().ToUpper() == "DATETIME")
                    {
                        cmd.Parameters.Add(parameterNameArray[x].ToString(), SqlDbType.DateTime).Value = GetStringOrDBNull(paramsValue);
                    }
                    else if (parameterDataTypeArray[x].ToString().ToUpper() == "NUMERIC")
                    {
                        cmd.Parameters.Add(parameterNameArray[x].ToString(), SqlDbType.Float).Value = GetStringOrDBNull(paramsValue);
                    }
                    else if (parameterDataTypeArray[x].ToString().ToUpper() == "DECIMAL")
                    {
                        cmd.Parameters.Add(parameterNameArray[x].ToString(), SqlDbType.Decimal).Value = GetStringOrDBNull(paramsValue);
                    }
                    else
                    {
                        cmd.Parameters.Add(parameterNameArray[x].ToString(), SqlDbType.VarChar).Value = GetStringOrDBNull(paramsValue);
                    }
                    x++;
                }
                da.SelectCommand = cmd;
                da.Fill(dsmain);
                return dsmain;
            }
            catch (Exception objException)
            {
                throw (objException);
            }
            finally
            {
                con.Close();
            }
        }
        void GetParameters(string procedureName)
        {
            DataSet ds = new DataSet();
            cmd = GetCommand("get_procedure_all_parameters", ref con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@pprocedure_nm", SqlDbType.VarChar).Value = GetStringOrDBNull(procedureName);
            cmd.Parameters.Add("@pextra1", SqlDbType.VarChar).Value = System.DBNull.Value;
            cmd.Parameters.Add("@pextra2", SqlDbType.VarChar).Value = System.DBNull.Value;
            da.SelectCommand = cmd;
            da.Fill(ds);
            for (int z = 0; z < ds.Tables[0].Rows.Count; z++)
            {
                parameterNameArray.Insert(z, ds.Tables[0].Rows[z]["PARAMETER_NAME"].ToString());
                parameterDataTypeArray.Insert(z, ds.Tables[0].Rows[z]["DATA_TYPE"].ToString());
            }
            //for (int z = 0; z < ds.Tables[1].Rows.Count; z++)
            //{
            //    outputParameter.Insert(z, ds.Tables[1].Rows[z]["PARAMETER_NAME"].ToString());
            //}
        }

        public DataSet BindCommanFunction(string procedureName, string[] parameterValueArray)
        {
            con.Open();
            try
            {
                con.Open();
                string query = "select  " + procedureName + "('" + parameterValueArray + "')";
                cmd.CommandText = query;
                cmd.Connection = con;
                //cmd.ExecuteNonQuery();

                da.SelectCommand = cmd;
                da.Fill(dsmain);
                return dsmain;

            }
            catch (Exception ex)
            {
                throw (ex);
            }
            finally
            {
                CloseConnection(ref con);
            }
        }
    }
}





