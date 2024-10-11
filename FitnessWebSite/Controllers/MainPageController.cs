using FitnessWebSite.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FitnessWebSite.Controllers
{
    public class MainPageController : Controller
    {
        Context c = new Context();
        // GET: MainPage

        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult Trainer()
        {
            var deger = c.Trainers.ToList();
            return PartialView(deger);
        }

    }
}