using BOL;
using BOL.ViewModel;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class VoterElectionManager
    {
        VoterElectionService _voterElectionService = null;
        public VoterElectionManager()
        {
            _voterElectionService = new VoterElectionService();
        }

        public  string SaveVoterElection(CastVoteViewModel model)
        {
            VoterElection _voterElection = new VoterElection();
            _voterElection.voterId = model.voterId;
            _voterElection.electionId = model.electionId;
            _voterElection.userId = model.candidateId;
            _voterElection.datetime = DateTime.Now;
            return _voterElectionService.SaveVoterElection(_voterElection);
        }
    }
}
