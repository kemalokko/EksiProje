using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace dnm.Controllers
{
    public class CuisineController : Controller
    {
        public ActionResult Search(string name = "french")
        {
            //throw new Exception("sth terble has happened!");
            var message = Server.HtmlEncode(name);
            return Content(message);
        }

        
    }
}