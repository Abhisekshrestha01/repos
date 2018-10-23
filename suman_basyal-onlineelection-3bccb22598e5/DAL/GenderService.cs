using BOL;
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class GenderService : IDal<Gender>
    {
        private ElectionDBEntities _electionDbEntites = null;
        public GenderService()
        {
            _electionDbEntites = new ElectionDBEntities();
        }
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Gender> GetAll()
        {
            return _electionDbEntites.Genders.ToList<Gender>();
        }

        public Gender GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Gender entity)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            _electionDbEntites.SaveChanges();
        }

        public void Update(Gender entity)
        {
            throw new NotImplementedException();
        }
    }
}
