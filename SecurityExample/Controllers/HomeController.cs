﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SecurityExample.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Account()
        {
            return View();
        }
    }
}