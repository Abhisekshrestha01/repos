using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace CustomException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new UserAlreadyLoggedinException("User is logged in - no dublicate session allowed");
            }
            catch(UserAlreadyLoggedinException ex)
            {
                Console.WriteLine(ex.Message);
            } 
        }
    }
    public class UserAlreadyLoggedinException : Exception
    {
        public UserAlreadyLoggedinException() : base()
        {
             
        }
        public UserAlreadyLoggedinException(string message) : base(message)
        {

        }
        public UserAlreadyLoggedinException(string message, Exception innerException) : base(message, innerException)
        {

        }
        public UserAlreadyLoggedinException(SerializationInfo info, StreamingContext context) :base(info, context)
        {

        }
    }
}
