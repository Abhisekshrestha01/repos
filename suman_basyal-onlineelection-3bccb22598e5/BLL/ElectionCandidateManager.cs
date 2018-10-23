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
    public class ElectionCandidateManager
    {
        public ElectionCandidateService _electionCandidateService;
        public ElectionCandidateManager()
        {
            _electionCandidateService = new ElectionCandidateService();
        }

        public List<Candidate> GetAllCandidatesForElection(int? electionId)
        {
            var list=_electionCandidateService.GetAllCandidatesForElection(Convert.ToInt32(electionId));
            return list;
        }

        public void Save(CastVoteViewModel model)
        {
            VoterElection voterElection = new VoterElection();
            voterElection.voterId = model.voterId;
            voterElection.electionId = model.electionId;
            voterElection.userId = model.candidateId;
            voterElection.datetime = DateTime.Now;


        }
    }
}
