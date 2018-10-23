using BOL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UserService
    {
        private ElectionDBEntities dbEntites;

        public UserService()
        {
            dbEntites = new ElectionDBEntities();
        }
        public IEnumerable<User> GetAll()
        {
            return dbEntites.Users.ToList();
        }
        public User GetByID(int id)
        {
            return dbEntites.Users.Find(id);
        }
        public void Insert(User user)
        {
            dbEntites.Users.Add(user);
            Save();
        }
        public void Delete(int id)
        {
            var user = GetByID(id);
            dbEntites.Users.Remove(user);
            Save();
        }
        public void Update(User user)
        {
            var entityUser = GetByID(user.userId);
            entityUser.email = user.email;
            entityUser.firstName = user.firstName;
            entityUser.middleName = user.middleName;
            entityUser.lastName = user.lastName;
            entityUser.genderId = user.genderId;
            entityUser.photo = user.photo;
            Save();
        }
        private void Save()
        {
            dbEntites.SaveChanges();
        }

        public User FindUserByEmail(string email)
        {
            var entityUser=dbEntites.Users.FirstOrDefault(x => x.email == email);
            return entityUser;
        }

       
    }
}
