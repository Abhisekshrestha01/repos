using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace ADOpractice
{
    public class CustomerInformation
    {
        static void Main(String[] args)
        {
            //1. Prepare the connection String
            string conString = "Data Source=DESKTOP-9V6EBK0;Initial Catalog=test;Integrated Security=True";

            //2.Create  the connection object
            SqlConnection sqlCon = new SqlConnection(conString);

            //3.Create the Command object
            SqlCommand sqlCom = new SqlCommand {
                Connection = sqlCon,
                CommandText = "SELECT Name, Username, Password, Email, DOB FROM Userss",
                CommandType = CommandType.Text
            };

            //4. Prepare the data adapter
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCom);

            //5. Prepare the data holder
            DataSet ds = new DataSet();

            adapter.Fill(ds);
            for (int i=0; i < ds.Tables[0].Rows.Count; i++)
            {
                DataRow dr = ds.Tables[0].Rows[i];
                Console.WriteLine("Name:- " + dr["Name"].ToString());
                Console.WriteLine("Username:-" + dr["Username"].ToString());
            }
            Console.Read();
        }
    }
}