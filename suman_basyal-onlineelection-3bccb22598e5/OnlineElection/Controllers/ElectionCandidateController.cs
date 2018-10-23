using BLL;
using BOL.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineElection.Controllers
{
    public class ElectionCandidateController : Controller
    {
        private ElectionCandidateManager _electionCandidateManager;
        public ElectionCandidateController()
        {
            _electionCandidateManager = new ElectionCandidateManager();
        }
        // GET: ElectionCandidate
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetAllCandidatesForElection(int electionId)
        {
            var list=_electionCandidateManager.GetAllCandidatesForElection(electionId).ToList();
            return Json(list, JsonRequestBehavior.AllowGet);
        }
    }
}