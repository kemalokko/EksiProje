using dnm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
                Session["LoginModels"] = new LoginModels() { Kek = "test" };
                TempData["Message"] = "başarılı";
                ViewBag.Message = TempData["Message"].ToString();
                
                return RedirectToAction("Index","Home");
            }
            ViewBag.Message = "bi sakatlık var tekrar dene";
            return View();
        }


        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> TestLogin(LoginModels model)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser user = await ApplicationUserManager.fi
            }
            else
            {
                return View(model);
            }
        }



        public ActionResult Show()
        {
            return View();
        }
        public ActionResult Test()
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