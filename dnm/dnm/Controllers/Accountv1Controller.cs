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

            //v1

            //if(logmodel.Name == _LoginModels[0].Name)
            //{
            //    Session["LoginModels"] = new LoginModels();
            //    TempData["Message"] = "başarılı";
            //    ViewBag.Message = TempData["Message"].ToString();

            //    return RedirectToAction("Index","Home");
            //}
            //ViewBag.Message = "bi sakatlık var tekrar dene";
            //return View();

            //v2->
            if (logmodel.UserName == _LoginModels[0].Name)
            {
                string authId = Guid.NewGuid().ToString();
                Session["AuthID"] = authId;
                var cookie = new HttpCookie("AuthID");
                cookie.Value = authId;
                Response.Cookies.Add(cookie);

                return RedirectToAction("Test");
            }

            return View();
        }


        public ActionResult Login()
        {
            return View();
        }



        public ActionResult Show()
        {
            return View();
        }
        
        public ActionResult Test() 
        {
            if (Request.Cookies["AuthID"].Value ==null || Session["AuthID"].ToString() == null)  //null olması durumunda ölümün yeşil ekranı çıkıyor. 
            {
                return RedirectToAction("Index","Home");
            }
            else if (Request.Cookies["AuthID"].Value == Session["AuthID"].ToString())
            {
                return View();
            }
            else //bilinmeyen durum. tanımlanacak 
            {
                return RedirectToAction("Giris", "Accountv1");
            }
            
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