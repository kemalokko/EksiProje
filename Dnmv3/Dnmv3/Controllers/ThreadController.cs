using Dnmv3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dnmv3.Controllers
{
    [Authorize]
    public class ThreadController : Controller
    {
        // GET: Thread
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        // GET: Thread/Details/5
        public ActionResult Details()
        {
            var model =
                 from r in Threads
                 orderby r.ThreadId
                 select r;
            return View(model);
        }

        // GET: Thread/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Thread/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Thread/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Thread/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Thread/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Thread/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
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
