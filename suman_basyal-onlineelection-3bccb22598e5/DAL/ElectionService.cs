using BOL;
using BOL.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ElectionService
    {
        private ElectionDBEntities dbEntites=null;
        


        public ElectionService()
        {
            dbEntites = new ElectionDBEntities();
        }
        public IEnumerable<Election> GetAll()
        {
            return dbEntites.Elections.ToList();
        }
        public Election GetByID(int id)
        {
            return dbEntites.Elections.Find(id);
        }
        public void Insert(Election election)
        {
            dbEntites.Elections.Add(election);
            Save();
        }
        public void Delete(int id)
        {
            var election = GetByID(id);
            dbEntites.Elections.Remove(election);
            Save();
        }
        public void Update(Election election)
        {
            //todo :- update election
            //date :- 2/14/2018
        }
        private void Save()
        {
            dbEntites.SaveChanges();
        }

        public void CastVote(VoterElection voterElection)
        {
            dbEntites.VoterElections.Add(voterElection);
            dbEntites.SaveChanges();
        }

        public void CreateElection(Election election)
        {
            using (DbContextTransaction transaction = dbEntites.Database.BeginTransaction())
            {
                try
                {

                    //create the election
                    
                    dbEntites.Elections.Add(election);
                    dbEntites.SaveChanges();

                    //save all the candidates for the election
                    foreach (string v in election.listOfCandidates)
                    {
                        CandidateElection candidateElection = new CandidateElection();
                        candidateElection.electionId = election.electionId;
                        candidateElection.userId = Convert.ToInt32(v);
                        candidateElection.isApproved = true;
                        candidateElection.datetime = DateTime.Now;

                        dbEntites.CandidateElections.Add(candidateElection);
                        dbEntites.SaveChanges();

                    }

                    //save the capable voters for the election
                    foreach(string v in election.listOfVoters)
                    {
                        CapableVoter capableVoter = new CapableVoter();
                        capableVoter.electionId = election.electionId;
                        capableVoter.userId = Convert.ToInt32(v);
                        capableVoter.datetime = DateTime.Now;
                        dbEntites.CapableVoters.Add(capableVoter);
                        dbEntites.SaveChanges();
                    }

                    //create all the notifications for voters
                    //foreach(string v in election.listOfVoters)
                    //{
                    //    Notification notification = new Notification();
                    //    notification.message = "Please cast vote for " + election.electionName;
                    //    notification.url = "Election/CastVote?electionId="+election.electionId;
                    //    notification.unseen = true;
                    //    notification.userId = Convert.ToInt32(v);
                    //    dbEntites.Notifications.Add(notification);
                    //    dbEntites.SaveChanges();
                    //}

                    //create all notifications for candidates
                    //foreach(string v in election.listOfCandidates)
                    //{
                    //    Notification notification = new Notification();
                    //    notification.message = "You are candidate for " + election.electionName;
                    //    notification.url = "temp";
                    //    notification.unseen = true;
                    //    notification.userId = Convert.ToInt32(v);
                    //    dbEntites.Notifications.Add(notification);
                    //    dbEntites.SaveChanges();
                    //}


                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
            }
        }

        public void FindElectionResult(string email)
        {
            try
            {
                var user = dbEntites.Users.FirstOrDefault(x => x.email == email);
                int userID = user.userId;
                List<int> listElectionIds=dbEntites.CapableVoters.Where(x => x.userId == userID).Select(x=> x.electionId).ToList<int>();
                foreach(int electionId in listElectionIds)
                {
                    var election=dbEntites.Elections.FirstOrDefault(x => x.electionId == electionId);
                    if (DateTime.Now >= election.endDate)
                    {
                        //election is over

                        //notify the client about the over of election

                        //find the winner
                        var result=dbEntites.VoterElections.Where(x=>x.electionId==electionId).GroupBy(x => x.userId)
                            .Select(group => new
                            {
                                candidateId = group.Key,
                                count = group.Count(),
                                Name=group.FirstOrDefault(x=>x.userId==group.Key).User.email
                            })
                            .OrderByDescending(x => x.count).ToList();

                        //
                        
                    }
                }

            }
            catch (Exception ex)
            {

            }
        }
        
        public List<Item> GetElectionForUser(string email)
        {
            var user = dbEntites.Users.FirstOrDefault(x => x.email == email);
            List<Item> list=dbEntites.CapableVoters.Where(x => x.userId == user.userId)
                .Select(x => new Item { Id = x.Election.electionId, Name = x.Election.electionName }).ToList();
            return list;
        }

        public List<Item> GetElectionForCandidate(string email)
        {
            var user = dbEntites.Users.FirstOrDefault(x => x.email == email);
            List<Item> list = dbEntites.CandidateElections.Where(x => x.userId == user.userId)
                      .Select(x => new Item { Id = x.Election.electionId, Name = x.Election.electionName }).ToList();
            return list;
        }

        /// <summary>
        /// works for both candidate and voter
        /// </summary>
        /// <param name="electionId"></param>
        /// <returns></returns>
        public List<ResultViewModel> ElectionResult(int electionId)
        {
            List<ResultViewModel> list=dbEntites.VoterElections.Where(x => x.electionId == electionId).GroupBy(x => x.userId)
                           .Select(group => new ResultViewModel
                           {
                               candidateId = group.Key,
                               totalVotes = group.Count(),
                               EndTime=group.FirstOrDefault(x=>x.userId==group.Key).Election.endDate,
                               Name = group.FirstOrDefault(x => x.userId == group.Key).User.email
                               
                           })
                            .OrderByDescending(x => x.totalVotes).ToList();

           

            var listOfCandidates = dbEntites.CandidateElections.Where(x => x.electionId == electionId).ToList();
            foreach(var candidate in listOfCandidates)
            {
                if (!list.Select(x => x.candidateId).ToList().Contains(candidate.userId))
                {
                    list.Add(new ResultViewModel() { candidateId = candidate.userId, totalVotes = 0, Name = candidate.User.email,EndTime=candidate.Election.endDate });
                }

                //bool isPresent = false;
                //foreach(var resultViewModel in list)
                //{
                //    if (resultViewModel.candidateId != candidate.userId)
                //    {
                //        isPresent = true;
                //    }
                //}
                //if(isPresent)
                //{
                //    list.Add(new ResultViewModel() { candidateId = candidate.userId, totalVotes = 0, Name = candidate.User.email });
                //}
                
            }
            return list;
        }

        public List<ResultViewModel> FindElectionResultAsAdmin(string email)
        {
            var admin = dbEntites.Users.FirstOrDefault(x => x.email == email);
            int adminId = admin.userId;
            //List<int> electionListId=dbEntites.Elections.Where(x=>x.adminId==adminId)

            List<ResultViewModel> list=dbEntites.VoterElections.Where(x => x.Election.adminId == adminId)
                .GroupBy(x => x.userId)
                .Select(group => new ResultViewModel
                {
                    candidateId=group.Key,
                    totalVotes=group.Count(),
                    Name=group.FirstOrDefault(x=>x.userId==group.Key).User.email
                }).ToList();
            return list;
        }

        public List<Item> GetAllElectionOfAdmin(string email)
        {
            var user = dbEntites.Users.FirstOrDefault(x => x.email == email);
            int adminId = user.userId;
            List<Item> listOfElections= dbEntites.Elections.Where(x => x.adminId == adminId).Select(x => new Item
            {
                Id=x.electionId,
                Name=x.electionName
            }).ToList();
            return listOfElections;
        }

        public List<Item> GetAllElectionsForaVoter(string email)
        {
            var user = dbEntites.Users.FirstOrDefault(x => x.email == email);
            int userId = user.userId;
            List<Item> list=dbEntites.CapableVoters.Where(x => x.userId == userId).Select(m => new Item()
            {
                Id = m.electionId,
                Name = m.Election.electionName
            }).ToList();
            return list;
        }

        public string DeleteElection(int electionId)
        {
            string errors = string.Empty;
                using (DbContextTransaction transaction = dbEntites.Database.BeginTransaction())
                {
                    try
                    {
                        //delete election from voterElection table
                        //this is the table that keeps track of which voter voted to which candidate
                        List<VoterElection> list = dbEntites.VoterElections.Where(x => x.electionId == electionId).ToList();
                        if(list!=null)
                        {
                            dbEntites.VoterElections.RemoveRange(list);
                            dbEntites.SaveChanges();
                        }
                       

                        //delete the election from cadidate election
                        //this table keep tracks of which cadidate is assigned to which election
                        List<CandidateElection> listCandidate = dbEntites.CandidateElections.Where(x => x.electionId == electionId).ToList();
                        if(listCandidate!=null)
                        {
                            dbEntites.CandidateElections.RemoveRange(listCandidate);
                            dbEntites.SaveChanges();
                        }

                        //delete the election from capable voter
                        //this is the table that contains voters assigend to an election
                        List<CapableVoter> listVoters = dbEntites.CapableVoters.Where(x => x.electionId == electionId).ToList();
                        if(listVoters!=null)
                        {
                            dbEntites.CapableVoters.RemoveRange(listVoters);
                            dbEntites.SaveChanges();
                        }

                        //delete the election from election table 
                        var election = dbEntites.Elections.FirstOrDefault(x => x.electionId == electionId);
                        dbEntites.Elections.Remove(election);
                        dbEntites.SaveChanges();

                        transaction.Commit();
                    errors = "The election has been deleted successfully";
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        errors = ex.Message.ToString();
                        
                    }
                    
                }

            return errors;
           
        }

        public void EditElection(Election election)
        {
            try
            {
                DeleteElection(election.electionId);
                CreateElection(election);
            }
            catch(Exception ex)
            {
                
            }
        }
    }
}
