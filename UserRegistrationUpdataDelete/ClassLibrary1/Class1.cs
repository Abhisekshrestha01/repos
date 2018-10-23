using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary2;

namespace ClassLibrary1
{

    public class Class1
    {
        
        Dictionary<int, User> dict = new Dictionary<int, User>();
        

        public void Register(int id, string name, int age, long phone)
        {
            User u = new User();
            u.Id = id;
            u.Name = name;
            u.Age = age;
            u.Phone = phone;
            dict.Add(u.Id, u);
            foreach(User x in dict.Values)
            {
                Console.WriteLine(x.Id+""+x.Name);
            }
        }
        public void Remove(int id)
        {
            dict.Remove(id);
        }
        public List<User> ViewAll()
        {
            List<User> ulist = new List<User>();
            return dict.Values.ToList();
            
        }
        public User ViewDetail(int id)
        {
            User u = dict[id];
            return u;      
        }
        public bool Checkid(int id)
        {
            if (dict.TryGetValue(id, out User u))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
