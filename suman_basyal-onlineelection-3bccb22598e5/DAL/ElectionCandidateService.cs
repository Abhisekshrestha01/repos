using BOL;
using BOL.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ElectionCandidateService
    {
        private ElectionDBEntities dbEntites = null;

        public ElectionCandidateService()
        {
            dbEntites = new ElectionDBEntities();
           
        }

        public List<Candidate> GetAllCandidatesForElection(int? electionId)
        {
            
            var list = dbEntites.CandidateElections.Where(x => x.electionId == electionId)
                .Select(x => new Candidate { Id = x.userId, Name = x.User.email ,ElectionName=x.Election.electionName, ElectionDescription=x.Election.Description,EndDate=x.Election.endDate})
                .ToList();
            return list;
        }

       
    }
}
