using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Reflection.Metadata;
namespace Final_project.DBConnection
{
    public class DBconnection
    {
        string ConnStr = "Data Source=(local);Initial Catalog=Thesis_management;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        SqlConnection conn = null;
        SqlCommand comm = null;
        SqlDataAdapter da = null;
        public DBconnection()
        {
            conn = new SqlConnection(ConnStr);
            comm = conn.CreateCommand();
        }
        public DataSet ExecuteQueryDataSet(string strSQL, CommandType ct)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            da = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public bool MyExecuteNonQuery(string strSQL, CommandType ct, ref string error)
        {
            bool f = false;
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            try
            {
                comm.ExecuteNonQuery();
                f = true;
            }
            catch (SqlException ex)
            {
                error = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return f;
        }
        public bool QueryCanbeRollback(string strSQL, CommandType ct, ref string error)
        {
            bool f = false;
            SqlTransaction transaction = conn.BeginTransaction();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            comm.Transaction = transaction;
            try
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                conn.Open();


                comm.ExecuteNonQuery();
                f = true;
                transaction.Commit();
            }
            catch (SqlException ex)
            {
                error = ex.Message;
                transaction.Rollback();
            }
            finally
            {
                conn.Close();
            }
            return f;
        }
        public string Getparameter(string query,string parametername, CommandType ct, ref string error)
        {
            string parameter = string.Empty;
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.CommandText = query;
            comm.CommandType = ct;
            try
            {
                SqlDataReader reader=comm.ExecuteReader();
                if (reader.Read())
                {
                    parameter = reader[parametername].ToString();
                }
            }
            catch (SqlException ex)
            {
                error = ex.Message;
            }
            finally
            {
                conn.Close();
            }


            return  parameter;
        }
        public List<string> GetColumn (string query, string column, CommandType ct, ref string error)
        {
            List<string> list = new List<string>();
            try
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            conn.Open();
            comm.CommandText = query;
            comm.CommandType = ct;

                SqlDataReader reader = comm.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string valueToAdd = reader[column].ToString();

                        list.Add(valueToAdd);
                    }
                }

            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            finally
            {
                conn.Close();
            }


            return list;
        }
        public List<string> GetRowInfo(string query, CommandType ct, ref string error)
        {
            List<string> list = new List<string>();

            try
            {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.CommandText = query;
            comm.CommandType = ct;

                SqlDataReader reader = comm.ExecuteReader();
                if (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        list.Add(reader[i].ToString());
                    }
                }

            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            finally
            {
                conn.Close();
            }


            return list;
        }

    }
}
