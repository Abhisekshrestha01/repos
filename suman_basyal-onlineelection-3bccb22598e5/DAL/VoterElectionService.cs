using BOL;
using BOL.Constant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class VoterElectionService
    {
        private ElectionDBEntities dbEntites;
        public VoterElectionService()
        {
            dbEntites = new ElectionDBEntities();
        }
        public string SaveVoterElection(VoterElection election)
        {
            //check if the record exists
            var entity=dbEntites.VoterElections.FirstOrDefault(x => x.voterId == election.voterId && x.userId == election.userId && x.electionId == election.electionId);
            DateTime startDateTime = dbEntites.Elections.FirstOrDefault(x => x.electionId == election.electionId).startDate;
            if(DateTime.Now>=startDateTime)
            {
                if (entity == null)
                {
                    dbEntites.VoterElections.Add(election);
                    dbEntites.SaveChanges();
                    return ElectionConstant.VOTE_SUCCESSFULLY_CASTED;
                }
                else
                {
                    return ElectionConstant.VOTE_ALREADY_EXITS;
                }
            }
            else
            {
                return ElectionConstant.ELECTION_NOT_STARTED;
            }
            
            
        }
    }
}
