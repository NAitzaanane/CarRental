﻿using ProjetASP.net.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetASP.net.Controllers
{

    public class HomeController : Controller
    {
        private DataBaseDataContext db = new DataBaseDataContext();
        public ActionResult Index()
        {
            var listVoiture = from v in db.Voitures
                              join p in db.Users on v.Proprietaire equals p.Id
                              where v.Offre == 1
                              select new Voiture_info { voiture = v, user = p };
            return View(listVoiture.ToList());
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }



    }
}