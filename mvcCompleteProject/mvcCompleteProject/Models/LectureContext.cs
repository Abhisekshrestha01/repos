using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace mvcCompleteProject.Models
{
    public class LectureContext : DbContext
    {
        public DbSet<Lecture> Lectures { get; set; }
    }
}