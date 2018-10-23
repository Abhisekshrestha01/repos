using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace Mvc4Application.Models
{
    public class ChannelDbContext : DbContext
    {
        public DbSet<MyChannels> Mychannel { get; set; }
    }
}