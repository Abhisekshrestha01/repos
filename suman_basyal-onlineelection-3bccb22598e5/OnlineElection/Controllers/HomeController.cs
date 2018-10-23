using BLL;
using BOL.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineElection.Controllers
{
    public class HomeController : Controller
    {
        ElectionManager _electionManager; 
        public HomeController()
        {
            _electionManager = new ElectionManager();
        }

       

        // GET: Home
        public ActionResult Index()
        {
            HomePageViewModel homePageViewModel = new HomePageViewModel();
            homePageViewModel.listElection = _electionManager.GetAllElectionOfAdmin(User.Identity.Name);
            return View(homePageViewModel);
        }
    }
}