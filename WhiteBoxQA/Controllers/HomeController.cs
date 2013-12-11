using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WhiteBoxQA.Models;

namespace WhiteBoxQA.Controllers
{
    public class HomeController : Controller
    {
        private int myFavoriteNumber = 100;

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Candidate candidate)
        {

            if (ModelState.IsValid)
            {
                candidate.Remainder = myFavoriteNumber % candidate.FavoriteNumber;
                return View("Success", candidate);
            }

            return View(candidate);
        }
    }
}