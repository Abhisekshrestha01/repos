//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class VoterElection
    {
        public int voterId { get; set; }
        public int electionId { get; set; }
        public int userId { get; set; }
        public System.DateTime datetime { get; set; }
    
        public virtual Election Election { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
    }
}
