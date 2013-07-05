using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcSiteMapProvider_WrongNode.Controllers
{
    public class ControllerController : Controller
    {
        //
        // GET: /Controller/Action1

        public ActionResult Action1(string type)
        {
            ViewBag.type = type;
            return View();
        }

        //
        // GET: /Controller/Action2

        public ActionResult Action2(string type)
        {
            ViewBag.type = type;
            return View();
        }

    
    }
}
