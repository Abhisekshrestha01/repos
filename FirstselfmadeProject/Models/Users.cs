using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace FirstselfmadeProject.Models
{
    public class Users
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime DOB { get; set; }
        

        public Users(string name, string username, string pwd, string email, DateTime dob)
        {
            this.Name = name;
            this.Password = pwd;
            this.Email = email;
            this.Username = username;
            this.DOB = dob;
        }

        public void Save()
        {
            SqlConnection con = new SqlConnection(Config.ConString);
            SqlCommand cmd = new SqlCommand();
            String context = @"INSERT INTO [Userss]
           ([Name]
           ,[UserName]
           ,[Password]
           ,[Email] 
           ,[DOB]
           ,[IsActive])
     VALUES
           ('" +this.Name+ "','"+this.Username+ "','" + this.Password+ "','" + this.Email + "','" +this.DOB +"',1)";
            cmd.CommandText = context;
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            con.Open();
            cmd.ExecuteNonQuery();
        }
    }
}