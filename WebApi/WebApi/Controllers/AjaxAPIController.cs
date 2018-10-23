using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Web.Http;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class AjaxAPIController : ApiController
    {
        [Route("api/AjaxAPI/SendEmail")]
        

        [HttpPost]
        public void SendEmail(Emails email2)
        {
            string name = email2.name;
            string email1 = email2.email;
            string comment = email2.comment;
            string email = "flightmanagementsystemimcs@gmail.com";
            string adminemail = "abhisek.shrestha1991@gmail.com";
            System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
            System.Net.Mail.MailMessage mail1 = new System.Net.Mail.MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

            mail.From = new MailAddress(email);
            mail.To.Add(email1);
            mail.Subject = "Admin is successfully notified";
            mail.Body = "Hello " + name + ",\n Admin has been successfully notified about the issus:\n\"" + comment + "\" \n\n With Regards, \n Flight Management System \n Dallas, TX";

            mail1.From = new MailAddress(email);
            mail1.To.Add(adminemail);
            mail1.Subject = "Comment from customer";
            mail1.Body = "Hello Admin,\n " + name + " has some comment on your system:\n\"" + comment + "\" \n\n With Regards, \n Flight Management System \n Dallas, TX";

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("flightmanagementsystemimcs@gmail.com", "flight@123");
            SmtpServer.EnableSsl = true;
            try
            {
                SmtpServer.Send(mail);
                SmtpServer.Send(mail1);
            }
            catch (Exception ex)
            {
                Exception ex2 = ex;
                string errorMessage = string.Empty;
            }
        }
    }
}
