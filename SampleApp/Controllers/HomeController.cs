﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page for Home Page1.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page. Vishal Ingole , Tanmay Gujar Test, Aziz Nagpurwala , Mahesh Gondugade";
            viewBag.Branches = "master,  Branch1";

            return View();
        }
    }
}