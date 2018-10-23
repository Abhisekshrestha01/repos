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
    
    public partial class Election
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Election()
        {
            this.CandidateElections = new HashSet<CandidateElection>();
            this.CapableVoters = new HashSet<CapableVoter>();
            this.ElectionResults = new HashSet<ElectionResult>();
            this.VoterElections = new HashSet<VoterElection>();
        }
    
        public int electionId { get; set; }
        public string electionName { get; set; }
        public int adminId { get; set; }
        public System.DateTime endDate { get; set; }
        public System.DateTime startDate { get; set; }
        public Nullable<System.DateTime> votingRequestDeadline { get; set; }
        public string Description { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CandidateElection> CandidateElections { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CapableVoter> CapableVoters { get; set; }
        public virtual User User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ElectionResult> ElectionResults { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VoterElection> VoterElections { get; set; }
    }
}