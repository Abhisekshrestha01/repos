using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace codeFirstStiredProcedureInsertUpdate
{
    public class RegistrationRepository
    {
        RegistrationDBcontext registrationDBcontext = new RegistrationDBcontext();

        public List<Registration> GetRegistrations()
        {
            return registrationDBcontext.Registrations.ToList();
        }

        public void InsertRegistration(Registration re)
        {
            registrationDBcontext.Registrations.Add(re);
            registrationDBcontext.SaveChanges();
        }

        public void Updateregistration(Registration re)
        {
            Registration regtoupdate = registrationDBcontext.Registrations.FirstOrDefault(n => n.Id == re.Id);
            regtoupdate.Name = re.Name;
            regtoupdate.Email = re.Email;
            registrationDBcontext.SaveChanges();
        }

        public void DeleteRegistration(Registration re)
        {
            Registration regtodel = registrationDBcontext.Registrations.FirstOrDefault(n => n.Id == re.Id);
            registrationDBcontext.Registrations.Remove(regtodel);
            registrationDBcontext.SaveChanges();
        }
    }
}