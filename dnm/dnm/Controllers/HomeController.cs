using dnm.Models;
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
            var model =
                from r in _threads
                orderby r.Id
                select r;
            return View(model);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        static List<Thread> _threads = new List<Thread>
        {
            new Thread
            {
                Id = 0,
                Content = "Bıktım sanki bu hayattan",
            },
            new Thread
            {
                Id = 1,
                Content = "Şaka la",
            }
        };
    }
}