using BOL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class GenderManager
    {
        private GenderService _genderService;
        public GenderManager()
        {
            _genderService = new GenderService();
        }

        public List<Gender> GetAll()
        {
            return _genderService.GetAll().ToList<Gender>();
        }
    }
}
