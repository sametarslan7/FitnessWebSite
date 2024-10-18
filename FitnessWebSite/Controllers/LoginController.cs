﻿using FitnessWebSite.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace FitnessWebSite.Controllers
{
    public class LoginController : Controller
    {
        Context c = new Context();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Admin ad)
        {
            var infos = c.Admins.FirstOrDefault(x => x.username == ad.username && x.password == ad.password);
            if (infos != null)
            {
                FormsAuthentication.SetAuthCookie(infos.username, false);
                Session["username"]=infos.username.ToString();
                return RedirectToAction("Index","Admin");
            }
            else
            {
                return View();
            }
        }

    }
}