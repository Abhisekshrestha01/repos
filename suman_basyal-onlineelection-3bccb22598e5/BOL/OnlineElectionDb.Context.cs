﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BOL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ElectionDBEntities : DbContext
    {
        public ElectionDBEntities()
            : base("name=ElectionDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CandidateElection> CandidateElections { get; set; }
        public virtual DbSet<CapableVoter> CapableVoters { get; set; }
        public virtual DbSet<Election> Elections { get; set; }
        public virtual DbSet<Gender> Genders { get; set; }
        public virtual DbSet<Notification> Notifications { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<VoterElection> VoterElections { get; set; }
        public virtual DbSet<ElectionResult> ElectionResults { get; set; }
    }
}
