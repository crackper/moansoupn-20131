using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Configuration;

namespace DBSystem.DataAccess
{
    public abstract class MasterDataAccess
    {
        SqlConnection cnx = null;

        public MasterDataAccess()
        {
            if (cnx == null)
            {
                cnx = new SqlConnection();
                cnx.ConnectionString = "Data Source=(local);Initial Catalog=DBSystem;Integrated Security=True";//ConfigurationManager.ConnectionStrings["cnx"].ConnectionString;
            }
        }

        protected SqlCommand CreateComand(string query)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = query;
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = cnx;
            return command;
        }

        protected void AddParameter(SqlCommand command, string paramName, object value)
        {
            command.Parameters.AddWithValue(paramName, value);
        }

        protected SqlDataReader ExecuteReader(SqlCommand command)
        {
            cnx.Open();

            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }

        protected int ExecuteNonQuery(SqlCommand command)
        {
            var affect = 0;

            cnx.Open();
            affect = command.ExecuteNonQuery();
            cnx.Close();

            return affect;
        }
    }
}
