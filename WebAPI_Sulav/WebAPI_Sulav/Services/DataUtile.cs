using System;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WebAPI_Sulav.Services
{
    
    public class DataUtile
    {
        private static SqlConnection Conn;
        private static void CreateConnection()
        {
            string connectionString = @"Data Source=DESKTOP-0Q267P3\SQLEXPRESS;Initial Catalog=EmployeeDb;Integrated Security=True";
            Conn = new SqlConnection(connectionString);
        }
        public static DataTable Getdata()
        {
            CreateConnection();
            string SqlString = "SELECT * FROM Employees";
            SqlDataAdapter sda = new SqlDataAdapter(SqlString, Conn);
            DataTable dt = new DataTable();
            try
            {
                Conn.Open();
                sda.Fill(dt);
            }
            catch (SqlException Ex)
            {
                
            }
            finally
            {
                Conn.Close();
            }
            return dt;

        }
    }
    
}
