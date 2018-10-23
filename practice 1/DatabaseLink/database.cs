using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLink
{
    public class Database
    {
        //string CS = @"Data Source=DESKTOP-0Q267P3\SQLEXPRESS;Initial Catalog=practice1;Integrated Security=True";
        String CS = System.Configuration.ConfigurationManager.ConnectionStrings["DBCS"].ToString();
        public Boolean LoginCheck(string username, string password)
        {
            
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("spChecklogin", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                con.Open();
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }
        
        public Boolean CheckUserName(string username)
        {
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("spCheckUsername", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", username);
                con.Open();
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count > 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }

            }
        }
        
        public string Getlocation(string name)
        {
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("spGetLocation", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", name);
                con.Open();
                return cmd.ExecuteScalar().ToString();
                

            }
        }
        public void Editdata(string name, string gender, string email, string age, string username)
        {
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("spEditUser", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Gender", gender);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Age", int.Parse(age));
               
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public void Insertdata(string name, string gender, string email, string education, string address_continent, string address_country, string address_city, string filename, string age, string password, string username)
        {
            
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("spAddUser", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Gender", gender);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Education", education);
                cmd.Parameters.AddWithValue("@Address_continent", address_continent);
                cmd.Parameters.AddWithValue("@Address_country", address_country);
                cmd.Parameters.AddWithValue("@Address_city", address_city);
                cmd.Parameters.AddWithValue("@Filelocation", filename);
                cmd.Parameters.AddWithValue("@Age", int.Parse(age));
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@username", username);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataSet GetDetail(string username)
        {
            using (SqlConnection con = new SqlConnection(CS))
            {
               
                SqlCommand cmd = new SqlCommand("spGetDetailFromName", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", username);
                con.Open();
                SqlDataAdapter sdr = new SqlDataAdapter();
                sdr.SelectCommand = cmd;
                DataSet ds = new DataSet();
                sdr.Fill(ds);
                return ds;
            }

        }
        public DataSet GetDetailEdit(int Id)
        {
            using (SqlConnection con = new SqlConnection(CS))
            {

                SqlCommand cmd = new SqlCommand("spGetDetailFromNameEdit", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", Id);
                con.Open();
                SqlDataAdapter sdr = new SqlDataAdapter();
                sdr.SelectCommand = cmd;
                DataSet ds = new DataSet();
                sdr.Fill(ds);
                return ds;
            }
        }
        public DataSet GetDetailAll()
        {
            using (SqlConnection con = new SqlConnection(CS))
            {

                SqlCommand cmd = new SqlCommand("spGetDetailAll", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                con.Open();
                SqlDataAdapter sdr = new SqlDataAdapter();
                sdr.SelectCommand = cmd;
                DataSet ds = new DataSet();
                sdr.Fill(ds);
                return ds;
            }
        }
        public DataSet Getdata(string spname, SqlParameter spparameter)
        {

            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlDataAdapter sda = new SqlDataAdapter(spname, con);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                if (spparameter != null)
                {
                    sda.SelectCommand.Parameters.Add(spparameter);
                }
                DataSet ds = new DataSet();
                sda.Fill(ds);
                return ds;
            }
            
        }



    }

}
