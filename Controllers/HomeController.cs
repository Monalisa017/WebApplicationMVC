﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplicationMVC.Models;
using System.Web.Mvc;

namespace WebApplicationMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = new HomeViewData();
            model.Nome = "Monalisa";
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

   
    }
}