﻿using dnm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace dnm.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var controller = RouteData.Values["controller"];
            var action = RouteData.Values["action"];
            var id = RouteData.Values["id"];

            var message = string.Format("{0}::{1} {2}",controller,action,id);

            ViewBag.Message = message;
            return View();
        }

        public ActionResult About()
        {
            //ViewBag.Blyat = "Oy napen asd";
            //ViewBag.Name = "Kemçük";
            //ViewBag.Location = "kek";
            var model = new AboutModel();
            model.Name = "Kemal";
            model.Location = "İstanbul";
            return View(model);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}