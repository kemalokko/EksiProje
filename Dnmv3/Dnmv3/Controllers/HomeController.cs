using Dnmv3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dnmv3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model =
                 from r in Threads
                 orderby r.ThreadId
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

        public List<ThreadModels> Threads = new List<ThreadModels>
        {
            new ThreadModels
            {
                AuthorName = "Jeff",
                DateAdded = DateTime.Now,
                Thread = "ölsenize",
                ThreadId = 1,
                Content = new List<ContentModels>
                {
                    new ContentModels
                    {
                        ContentId = 1,
                        Author = "Jeff2",
                        Content = "jeff2 bunu yazdı",
                        FavCount = 5,
                        VoteCount = -6,
                        DateAdded = DateTime.Now,
                    }
                },
            },
            new ThreadModels
            {
                ThreadId = 2,
                AuthorName = "Corç",
                DateAdded = DateTime.Now,
                Thread = "gebersenize",
                Content = new List<ContentModels>
                {
                    new ContentModels
                    {
                        ContentId = 2,
                        Author = "corç",
                        Content = "corç bunu yazdı",
                        FavCount = 5,
                        VoteCount = -6,
                        DateAdded = DateTime.Now,
                    },
                    new ContentModels
                    {
                        ContentId = 3,
                        Author = "kek",
                        Content = "kek bunu yazdı",
                        FavCount = 5,
                        VoteCount = -6,
                        DateAdded = DateTime.Now,
                    }
                },
            },
        };

    }
}