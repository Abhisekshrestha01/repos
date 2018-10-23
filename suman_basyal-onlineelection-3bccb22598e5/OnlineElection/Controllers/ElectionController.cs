using BLL;
using BOL;
using BOL.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineElection.Controllers
{
    public class ElectionController : Controller
    {
        private ElectionManager _electionManager;
        private UserManager _userManager;
        private ElectionCandidateManager _electionCandidateManager;
        private VoterElectionManager _voterElectionManager;
        public ElectionController()
        {
            _electionManager = new ElectionManager();
            _userManager = new UserManager();
            _electionCandidateManager = new ElectionCandidateManager();
            _voterElectionManager = new VoterElectionManager();
        }

        // GET: Election
        public ActionResult Index()
        {
            IList<User> userList = _userManager.GetAll().Where(x=>x.email!=User.Identity.Name).Select(s=>new User { userId=s.userId, email=s.email}).ToList();
            ViewBag.userList = userList;
            return View();
        }


        [HttpPost]
        public ActionResult Create(Election election)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    election.adminId = _userManager.GetAll().FirstOrDefault(x => x.email == User.Identity.Name).userId;
                    _electionManager.CreateElection(election);
                    TempData["Msg"] = "Election was created successfully";
                    
                }
                else
                {
                    TempData["Msg"] = "Election was not created";
                }
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                TempData["Msg"] = "An error occured " + ex.Message.ToString();
                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public ActionResult CastVote(int ? electionId)
        {
            CastVoteViewModel _castVote = new CastVoteViewModel();
            Election election=_electionManager.GetByID(Convert.ToInt32(electionId));
            _castVote.endDate = election.endDate;
            _castVote.electionId = Convert.ToInt32(electionId);
            _castVote.ElectionName = election.electionName;
            _castVote.ElectionDescription = election.Description;
            _castVote.listOfCandidates = _electionCandidateManager.GetAllCandidatesForElection(Convert.ToInt32(electionId));


            return View(_castVote);
        }

        [HttpPost]
        public ActionResult CastVotePost(CastVoteViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    model.voterId = _userManager.GetAll().FirstOrDefault(x => x.email == User.Identity.Name).userId;
                    _voterElectionManager.SaveVoterElection(model);
                    TempData["Msg"] = "Vote casted successfully";
                }
                return RedirectToAction("CastVote", new { @electionId = model.electionId });
            }
            catch(Exception ex)
            {
                TempData["Msg"] = "An error occured " + ex.Message;
                return RedirectToAction("CastVote", new { @electionId = model.electionId });
            }
        }

        public ActionResult Test()
        {
            _electionManager.FindElectionResult(User.Identity.Name);
            return View();
        }

        public JsonResult GetAllElectionAsVoter()
        {
            var list=_electionManager.GetElectionForUser(User.Identity.Name);
            return Json(list,JsonRequestBehavior.AllowGet);
        }

        public ActionResult ViewResult()
        {
            return View();
        }

        public JsonResult GetElectionResult(int electionId)
        {
            var list=_electionManager.ElectionResult(electionId);
            return Json(list, JsonRequestBehavior.AllowGet);
        }

        public JsonResult  GetElectionForCandidate()
        {
            var list = _electionManager.GetElectionForCandidate(User.Identity.Name);
           // var list = _electionManager.FindElectionResultAsAdmin(User.Identity.Name);
            return Json(list, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetElectionResultForAdmin(int electionId)
        {
            try
            {
                
                var list = _electionManager.ElectionResult(electionId);
                return Json(list, JsonRequestBehavior.AllowGet);
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public JsonResult GetAllElectionOfAdmin(string email)
        {
            var list= _electionManager.GetAllElectionOfAdmin(email);
            return Json(list, JsonRequestBehavior.AllowGet);
        }

        public ActionResult CastVoteIndex()
        {
            VotingViewModel _votingViewModel = new VotingViewModel();
            _votingViewModel.electionList= _electionManager.GetAllElectionsForaVoter(User.Identity.Name);
            _votingViewModel.candidateList = new List<Item>();
            _votingViewModel.castVoteViewModel = new CastVoteViewModel();
            
            return View(_votingViewModel);
        }

        [HttpPost]
        public ActionResult CastVoteIndexPost(VotingViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    model.castVoteViewModel.voterId = _userManager.GetAll().FirstOrDefault(x => x.email == User.Identity.Name).userId;
                    string result=_voterElectionManager.SaveVoterElection(model.castVoteViewModel);
                    TempData["Msg"] = result;
                }
                return RedirectToAction("CastVoteIndex");
            }
            catch (Exception ex)
            {
                TempData["Msg"] = "An error occured " + ex.Message;
                return RedirectToAction("CastVoteIndex");
            }
        }

        public bool IsVoteExist()
        {
            return true;
        }
        public JsonResult GetElectionInfo(int electionId)
        {
            var election=_electionManager.GetAll().FirstOrDefault(x => x.electionId == electionId);
            return Json(election, JsonRequestBehavior.AllowGet);
        }

        public ActionResult AllElection()
        {
            string name = User.Identity.Name;
            var user=_userManager.GetAll().FirstOrDefault(x => x.email == name);
            List<Election> list=_electionManager.GetAll().Where(x => x.adminId == user.userId).ToList();
            return View(list);
        }

     
        public ActionResult DeleteElection(int ?Id)
        {
            _electionManager.DeleteElection(Convert.ToInt32(Id));
            return RedirectToAction("AllElection", "Election");
        }

        public ActionResult EditElection(int ?Id)
        {
            IList<User> userList = _userManager.GetAll().Where(x => x.email != User.Identity.Name).Select(s => new User { userId = s.userId, email = s.email }).ToList();
            ViewBag.userList = userList;
            Election election=_electionManager.GetByID(Convert.ToInt32(Id));
            if( DateTime.Now >= election.startDate)
            {
                TempData["Msg"] = "The election has already started. You can't edit it.";
                return RedirectToAction("AllElection", "Election");
            }
            return View(election);
            
        }

        [HttpPost]
        public ActionResult Edit(Election election)
        {
            election.adminId=_userManager.GetAll().FirstOrDefault(x => x.email == User.Identity.Name).userId;
            _electionManager.EditElection(election);
            return RedirectToAction("AllElection", "Election");
        }
    }
}