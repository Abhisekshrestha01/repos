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

    public class ElectionManager
    {
        private ElectionService _electionService;
        public ElectionManager()
        {
            _electionService = new ElectionService();
        }

        public IEnumerable<Election> GetAll()
        {
            return _electionService.GetAll();
        }
        public Election GetByID(int id)
        {
            return _electionService.GetByID(id);
        }
        public void Insert(Election election)
        {
            _electionService.Insert(election);
        }
        public void Delete(int id)
        {
            _electionService.Delete(id);
        }
        public void Update(Election election)
        {
            _electionService.Update(election);
        }

        public void CreateElection(Election election)
        {
            
            _electionService.CreateElection(election);
        }

        public void CastVote(VoterElection voterElection)
        {
            _electionService.CastVote(voterElection);
        }

        public void FindElectionResult(string email)
        {
            _electionService.FindElectionResult(email);
        }

        public List<Item> GetElectionForUser(string email)
        {
            return _electionService.GetElectionForUser(email);
        }

        public List<ResultViewModel> ElectionResult(int electionId)
        {
           return  _electionService.ElectionResult(electionId);
        }

        public List<Item> GetElectionForCandidate(string email)
        {
            return _electionService.GetElectionForCandidate(email);
        }

        public List<ResultViewModel> FindElectionResultAsAdmin(string email)
        {
            return _electionService.FindElectionResultAsAdmin(email);
        }

        public List<Item> GetAllElectionOfAdmin(string email)
        {
            return _electionService.GetAllElectionOfAdmin(email);
        }

        public List<Item> GetAllElectionsForaVoter(string email)
        {
            return _electionService.GetAllElectionsForaVoter(email);
        }

        public string DeleteElection(int electionId)
        {
            return _electionService.DeleteElection(electionId);
        }

        public void EditElection(Election election)
        {
            _electionService.EditElection(election);
        }
    }
}
