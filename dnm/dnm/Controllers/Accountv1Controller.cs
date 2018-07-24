using dnm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace dnm.Controllers
{
    public class Accountv1Controller : Controller
    {
        // GET: Accountv1
        [HttpGet]
        public ActionResult Giris()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Giris(LoginModels logmodel)
        {
            if(logmodel.Name == _LoginModels[0].Name)
            {
                ViewBag.Message = "giriş başarılı";
                return View();
            }
            ViewBag.Message = "bi sakatlık var tekrar dene";
            return View(ViewBag);
        }

        public ActionResult Show()
        {
            return View();
        }

        public ActionResult CreateUser()
        {
            var NewUser = new LoginModels();
            return View(NewUser);
        }

        
        static List<LoginModels> _LoginModels = new List<LoginModels>
        {
            new LoginModels
            {
                UserName = "gapçuk",
                Name = "jeff",
                Password = "jeff"
            },
        };
    }
}