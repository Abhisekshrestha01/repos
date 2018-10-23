using BOL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UserManager
    {
        private UserService _userService;
        public UserManager()
        {
            _userService = new UserService();
        }
        public IEnumerable<User> GetAll()
        {
            return _userService.GetAll();
        }
        public User GetByID(int id)
        {
            return _userService.GetByID(id);
        }
        public void Insert(User user)
        {
             _userService.Insert(user);
        }
        public void Delete(int id)
        {
             _userService.Delete(id);
        }
        public void Update(User user)
        {
            _userService.Update(user);
        }

        public User FindUserByEmail(string email)
        {
            return _userService.FindUserByEmail(email);
        }
    }
}
