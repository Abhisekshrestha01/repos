using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace codeFirstStiredProcedureInsertUpdate
{
    public class RegistrationDBcontext : DbContext
    {
        public DbSet<Registration> Registrations { get; set; }

        //  This is where we tell Entity to use store Procedure
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //We are telling entity registration to map to stored procedure
            modelBuilder.Entity<Registration>().MapToStoredProcedures();
            base.OnModelCreating(modelBuilder); 
        }
    }
}