﻿using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.DataAccess
{
    class DAO
    {
        public static SqlConnection GetConnection()
        {
            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            string ConStr = config.GetConnectionString("StudentConStr");
            return new SqlConnection(ConStr);
        }

        public static DataTable GetDataBySql(string sql, SqlParameter[] parameters = null)
        {
            SqlCommand command = new SqlCommand(sql, GetConnection());
            if (parameters != null)
                command.Parameters.AddRange(parameters);
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(dt);
            return dt;
        }

        public static int ExecuteSql(string sql, params SqlParameter[] parameters)
        {
            SqlCommand command = new SqlCommand(sql, GetConnection());
            if (parameters != null)
                command.Parameters.AddRange(parameters);
            command.Connection.Open();
            int k = command.ExecuteNonQuery();
            command.Connection.Close();
            return k;
        }
    }
}
