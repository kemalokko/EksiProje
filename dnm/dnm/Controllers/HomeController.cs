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

        public ActionResult About()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }






        static List<Thread> _threads = new List<Thread>
        {
            new Thread
            {
                Id = 0,
                Content = "İçeriki de budur",
                _Thread = "Başlıkı budur",
            },
            new Thread
            {
                Id = 0,
                Content = "İçeriki de budur",
                _Thread = "Başlıkı budur",
            },
            new Thread
            {
                Id = 0,
                Content = "İçeriki de budur",
                _Thread = "Başlıkı budur",
            },
            new Thread
            {
                Id = 0,
                Content = "İçeriki de budur",
                _Thread = "Başlıkı budur",
            },
            new Thread
            {
                Id = 0,
                Content = "İçeriki de budur",
                _Thread = "Başlıkı budur",
            },
new Thread
            {
                Id = 0,
                Content = "İçeriki de budur",
                _Thread = "Başlıkı budur",
            },
            new Thread
            {
                Id = 0,
                Content = "İçeriki de budur",
                _Thread = "Başlıkı budur",
            },
new Thread
            {
                Id = 0,
                Content = "İçeriki de budur",
                _Thread = "Başlıkı budur",
            },
            new Thread
            {
                Id = 0,
                Content = "İçeriki de budur",
                _Thread = "Başlıkı budur",
            },
new Thread
            {
                Id = 0,
                Content = "İçeriki de budur",
                _Thread = "Başlıkı budur",
            },
            new Thread
            {
                Id = 0,
                Content = "İçeriki de budur",
                _Thread = "Başlıkı budur",
            },
new Thread
            {
                Id = 0,
                Content = "İçeriki de budur",
                _Thread = "Başlıkı budur",
            },
            new Thread
            {
                Id = 0,
                Content = "İçeriki de budur",
                _Thread = "Başlıkı budur",
            },
new Thread
            {
                Id = 0,
                Content = "İçeriki de budur",
                _Thread = "Başlıkı budur",
            },
            new Thread
            {
                Id = 0,
                Content = "İçeriki de budur",
                _Thread = "Başlıkı budur",
            },
new Thread
            {
                Id = 0,
                Content = "İçeriki de budur",
                _Thread = "Başlıkı budur",
            },
            new Thread
            {
                Id = 0,
                Content = "İçeriki de budur",
                _Thread = "Başlıkı budur",
            },
new Thread
            {
                Id = 0,
                Content = "İçeriki de budur",
                _Thread = "Başlıkı budur",
            },
            new Thread
            {
                Id = 0,
                Content = "İçeriki de budur",
                _Thread = "Başlıkı budur",
            },
new Thread
            {
                Id = 0,
                Content = "İçeriki de budur",
                _Thread = "Başlıkı budur",
            },
            new Thread
            {
                Id = 0,
                Content = "İçeriki de budur",
                _Thread = "Başlıkı budur",
            },
new Thread
            {
                Id = 0,
                Content = "İçeriki de budur",
                _Thread = "Başlıkı budur",
            },
            new Thread
            {
                Id = 0,
                Content = "İçeriki de budur",
                _Thread = "Başlıkı budur",
            },
new Thread
            {
                Id = 0,
                Content = "İçeriki de budur",
                _Thread = "Başlıkı budur",
            },
            new Thread
            {
                Id = 0,
                Content = "İçeriki de budur",
                _Thread = "Başlıkı budur",
            },
new Thread
            {
                Id = 0,
                Content = "İçeriki de budur",
                _Thread = "Başlıkı budur",
            },
            new Thread
            {
                Id = 0,
                Content = "İçeriki de budur",
                _Thread = "Başlıkı budur",
            },
new Thread
            {
                Id = 0,
                Content = "İçeriki de budur",
                _Thread = "Başlıkı budur",
            },
            new Thread
            {
                Id = 0,
                Content = "İçeriki de budur",
                _Thread = "Başlıkı budur",
            },
new Thread
            {
                Id = 0,
                Content = "İçeriki de budur",
                _Thread = "Başlıkı budur",
            },
            new Thread
            {
                Id = 0,
                Content = "İçeriki de budur",
                _Thread = "Başlıkı budur",
            },
new Thread
            {
                Id = 0,
                Content = "İçeriki de budur",
                _Thread = "Başlıkı budur",
            },
            new Thread
            {
                Id = 0,
                Content = "İçeriki de budur",
                _Thread = "Başlıkı budur",
            },
new Thread
            {
                Id = 0,
                Content = "İçeriki de budur",
                _Thread = "Başlıkı budur",
            },
            new Thread
            {
                Id = 0,
                Content = "İçeriki de budur",
                _Thread = "Başlıkı budur",
            },
new Thread
            {
                Id = 0,
                Content = "İçeriki de budur",
                _Thread = "Başlıkı budur",
            },
            new Thread
            {
                Id = 0,
                Content = "İçeriki de budur",
                _Thread = "Başlıkı budur",
            },
new Thread
            {
                Id = 0,
                Content = "İçeriki de budur",
                _Thread = "Başlıkı budur",
            },
            new Thread
            {
                Id = 0,
                Content = "İçeriki de budur",
                _Thread = "Başlıkı budur",
            },
new Thread
            {
                Id = 0,
                Content = "İçeriki de budur",
                _Thread = "Başlıkı budur",
            },
            new Thread
            {
                Id = 0,
                Content = "İçeriki de budur",
                _Thread = "Başlıkı budur",
            },
new Thread
            {
                Id = 0,
                Content = "İçeriki de budur",
                _Thread = "Başlıkı budur",
            },
            new Thread
            {
                Id = 0,
                Content = "İçeriki de budur",
                _Thread = "Başlıkı budur",
            },
new Thread
            {
                Id = 0,
                Content = "İçeriki de budur",
                _Thread = "Başlıkı budur",
            },
            new Thread
            {
                Id = 0,
                Content = "İçeriki de budur",
                _Thread = "Başlıkı budur",
            },
new Thread
            {
                Id = 0,
                Content = "İçeriki de budur",
                _Thread = "Başlıkı budur",
            },
            new Thread
            {
                Id = 0,
                Content = "İçeriki de budur",
                _Thread = "Başlıkı budur",
            },

        };
    }
}