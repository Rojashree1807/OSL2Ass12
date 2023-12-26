using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppAss12.Models;

namespace WebAppAss12.Controllers
{
    public class CricketController : Controller
    {
        static List<CricketTeam> listCricketTeams = new List<CricketTeam>()
        {
           new CricketTeam() { TeamId =1,TeamName="india",NOWC=2},
           new CricketTeam() { TeamId =2,TeamName="Australia",NOWC=4},
           new CricketTeam() { TeamId =3,TeamName="Weat Indies",NOWC=2},
           new CricketTeam() { TeamId =4,TeamName="England",NOWC=1},
        };
        // GET: Cricket
        [HttpGet]
        public ActionResult create()
        {
            return View(new CricketTeam());
        }
        [HttpPost]
        public ActionResult Create(CricketTeam team)
        {
            if (ModelState.IsValid)
            {
                listCricketTeams.Add(team);
            }
            return RedirectToAction("Index");
        }
        
        public ActionResult Index()
        {
            return View(listCricketTeams);
        }
       public ActionResult PAction()
       {
            return PartialView("PView");
       }

    }
}