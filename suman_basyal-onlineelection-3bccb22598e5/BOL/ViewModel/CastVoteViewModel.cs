using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.ViewModel
{
    public class CastVoteViewModel
    {
        public int electionId { get; set; }
        public string ElectionName { get; set; }
        public string ElectionDescription { get; set; }
        public List<Candidate>listOfCandidates{get;set;}
        public int voterId { get; set; }
        public int candidateId { get; set; }
        public DateTime endDate { get; set; }
    }

   
}
